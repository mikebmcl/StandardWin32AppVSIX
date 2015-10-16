> Introduction

This is the source code, etc., for building the StandardCppWin32AppVSIX.vsix Visual C++ project template installation file.

The project template itself is in ProjectTemplates/StandardCppWin32App.zip .

This template includes a [custom Wizard](https://msdn.microsoft.com/en-us/library/ms185301.aspx) for customizing project parameters.

Contrary to the instructions in that link, the Wizard is not installed into the GAC. Instead, the project was created by mostly following the instructions found here: http://blogs.msdn.com/b/vsx/archive/2014/06/10/creating-a-vsix-deployable-project-or-item-template-with-custom-wizard-support.aspx . The main difference is that I already had a project template zip file and so I did not need to follow the "Create a new 'C# Project Template' project" instructions and in the "Add the template as an asset of the VSIX project" section I added it as a file rather than as a project reference. Some additional trial and error was involved to eliminate VSSDK errors I encountered. I did not record exact details but should be able to provide answers or hints if you run into such errors.

This repository does **NOT** include the *key.snk* file (for, hopefully, obvious reasons). If you wish to fork this, you will need to create your own *key.snk* in the directory that StandardCppWin32AppVSIX.csproj resides and will then need to update the public key as per steps 1 through 3 of the "Associate the Wizard with the project template" section. Since I use a project template zip file, I simply extracted the .vstemplate file from the zip, made the changes in a text editor (Notepad++), then replaced the .vstemplate file in the zip file with the updated .vstemplate.

> Release Notes for StandardCppWin32App C++ Project Template

**Version 1.0**

* Initial release.
* The "Copyright Owner" field in the "Application Creation Parameters" field might not populate correctly even if you enter a value into the Registry key indicated by the Tool Tip displayed when you hover over the "Copyright Owner" text box.
* The project is set to the "/W4" warning level (see: https://msdn.microsoft.com/en-us/library/thxezb7y.aspx ). The C++ project templates included with Visual Studio presently default to the "/W3" warning level. As such, if you include existing code from another project, you may see warnings that did not appear when you compiled that code in another project. This setting is intentional; code that compiles cleanly with "/W4" is less likely to have hidden bugs. The author also recommends using static analysis tools since these can find bugs that even "/W4" might not uncover. You can, of course, change the warning level to whatever you prefer within the Project properties.