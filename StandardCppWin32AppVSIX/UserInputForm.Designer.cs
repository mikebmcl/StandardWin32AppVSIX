namespace StandardCppWin32AppVSIX
{
    partial class UserInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputForm));
            this.copyrightOwnerLabel = new System.Windows.Forms.Label();
            this.copyrightOwnerTextBox = new System.Windows.Forms.TextBox();
            this.applicationTitleLabel = new System.Windows.Forms.Label();
            this.applicationTitleTextBox = new System.Windows.Forms.TextBox();
            this.applicationTitleTextBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.copyrightOwnerTextBoxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cancelButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // copyrightOwnerLabel
            // 
            this.copyrightOwnerLabel.AutoSize = true;
            this.copyrightOwnerLabel.Location = new System.Drawing.Point(9, 48);
            this.copyrightOwnerLabel.Name = "copyrightOwnerLabel";
            this.copyrightOwnerLabel.Size = new System.Drawing.Size(88, 13);
            this.copyrightOwnerLabel.TabIndex = 2;
            this.copyrightOwnerLabel.Text = "&Copyright Owner:";
            // 
            // copyrightOwnerTextBox
            // 
            this.copyrightOwnerTextBox.Location = new System.Drawing.Point(12, 64);
            this.copyrightOwnerTextBox.Name = "copyrightOwnerTextBox";
            this.copyrightOwnerTextBox.Size = new System.Drawing.Size(335, 20);
            this.copyrightOwnerTextBox.TabIndex = 3;
            this.copyrightOwnerTextBoxToolTip.SetToolTip(this.copyrightOwnerTextBox, resources.GetString("copyrightOwnerTextBox.ToolTip"));
            // 
            // applicationTitleLabel
            // 
            this.applicationTitleLabel.AutoSize = true;
            this.applicationTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.applicationTitleLabel.Name = "applicationTitleLabel";
            this.applicationTitleLabel.Size = new System.Drawing.Size(85, 13);
            this.applicationTitleLabel.TabIndex = 0;
            this.applicationTitleLabel.Text = "&Application Title:";
            // 
            // applicationTitleTextBox
            // 
            this.applicationTitleTextBox.Location = new System.Drawing.Point(12, 25);
            this.applicationTitleTextBox.Name = "applicationTitleTextBox";
            this.applicationTitleTextBox.Size = new System.Drawing.Size(338, 20);
            this.applicationTitleTextBox.TabIndex = 1;
            this.applicationTitleTextBoxToolTip.SetToolTip(this.applicationTitleTextBox, "This is the name of the application. It will appear as the title of the main wind" +
        "ow and in the About window.\r\nChanging this value will not affect the project nam" +
        "e or the solution name.");
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(194, 98);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButtonToolTip.SetToolTip(this.okButton, "Completes creation of the new Project.");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(275, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButtonToolTip.SetToolTip(this.cancelButton, "Cancels completion of the new Project.");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UserInputForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(362, 133);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.applicationTitleTextBox);
            this.Controls.Add(this.applicationTitleLabel);
            this.Controls.Add(this.copyrightOwnerTextBox);
            this.Controls.Add(this.copyrightOwnerLabel);
            this.Name = "UserInputForm";
            this.Text = "Application Creation Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyrightOwnerLabel;
        private System.Windows.Forms.TextBox copyrightOwnerTextBox;
        private System.Windows.Forms.Label applicationTitleLabel;
        private System.Windows.Forms.TextBox applicationTitleTextBox;
        private System.Windows.Forms.ToolTip applicationTitleTextBoxToolTip;
        private System.Windows.Forms.ToolTip copyrightOwnerTextBoxToolTip;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolTip okButtonToolTip;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip cancelButtonToolTip;
    }
}