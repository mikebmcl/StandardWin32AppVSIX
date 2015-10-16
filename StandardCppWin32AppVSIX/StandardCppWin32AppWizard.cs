using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.IO;

namespace StandardCppWin32AppVSIX
{
    public class StandardCppWin32AppWizard : IWizard
    {
        private DTE m_dte = null;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            string projectName = null;
            try
            {
                m_dte = (DTE)automationObject;

                projectName = replacementsDictionary["$projectname$"];
                var safeProjectName = replacementsDictionary["$safeprojectname$"];
                replacementsDictionary.Add("$safeprojectnameuppercase$", safeProjectName.ToUpperInvariant());

                var userInputForm = new UserInputForm();
                userInputForm.SetApplicationTitle(projectName);
                userInputForm.SetCopyrightOwner(replacementsDictionary["$registeredorganization$"]);
                var result = userInputForm.ShowDialog();
                if (result != DialogResult.OK)
                {
                    throw new WizardBackoutException();
                }
                replacementsDictionary.Add("$applicationtitle$", userInputForm.GetApplicationTitle());
                replacementsDictionary.Add("$copyrightowner$", userInputForm.GetCopyrightOwner());
            }
            catch (WizardBackoutException)
            {
                try
                {
                    const string exclusiveprojectKey = "$exclusiveproject$";
                    const string solutiondirectoryKey = "$solutiondirectory$";
                    const string destinationdirectoryKey = "$destinationdirectory$";
                    string exclusiveProject = null;
                    string solutionDir = null;
                    string destinationDir = null;
                    bool isExclusive = false;
                    if (replacementsDictionary.TryGetValue(exclusiveprojectKey, out exclusiveProject))
                    {
                        if (String.Equals(exclusiveProject, "True", StringComparison.InvariantCultureIgnoreCase))
                        {
                            isExclusive = true;
                        }
                    }
                    else
                    {
                        if (replacementsDictionary.TryGetValue(solutiondirectoryKey, out solutionDir))
                        {
                            if (Directory.GetFileSystemEntries(solutionDir).GetLength(0) == 1)
                            {
                                isExclusive = true;
                            }
                        }
                    }
                    if (isExclusive == true)
                    {
                        if (replacementsDictionary.TryGetValue(solutiondirectoryKey, out solutionDir))
                        {
                            var fsEntries = Directory.GetFileSystemEntries(solutionDir);
                            if (fsEntries.Length == 1)
                            {
                                var entry = fsEntries[0];
                                if (Path.IsPathRooted(entry) == false)
                                {
                                    entry = Path.Combine(solutionDir, entry);
                                }
                                if (Directory.GetFileSystemEntries(entry).Length == 0)
                                {
                                    Directory.Delete(solutionDir, true);
                                }
                            }
                            else
                            {
                                // Allow for "Create solution directory" not being checked.
                                if (fsEntries.Length == 0)
                                {
                                    Directory.Delete(solutionDir);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (replacementsDictionary.TryGetValue(destinationdirectoryKey, out destinationDir))
                        {
                            if (Directory.GetFileSystemEntries(destinationDir).Length == 0)
                            {
                                Directory.Delete(destinationDir, true);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new WizardBackoutException(ex.Message, ex);
                }

                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new WizardBackoutException(ex.Message, ex);
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
