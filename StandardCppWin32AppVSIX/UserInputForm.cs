using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCppWin32AppVSIX
{
    public partial class UserInputForm : Form
    {
        private string applicationTitle;
        private string copyrightOwner;

        public UserInputForm()
        {
            InitializeComponent();
        }

        public void SetApplicationTitle(string value)
        {
            applicationTitle = value;
            applicationTitleTextBox.Text = value;
        }

        public string GetApplicationTitle()
        {
            return applicationTitle ?? "";
        }

        public void SetCopyrightOwner(string value)
        {
            copyrightOwner = value;
            copyrightOwnerTextBox.Text = value;
        }

        public string GetCopyrightOwner()
        {
            return copyrightOwner ?? "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applicationTitle = applicationTitleTextBox.Text;
            copyrightOwner = copyrightOwnerTextBox.Text;
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
