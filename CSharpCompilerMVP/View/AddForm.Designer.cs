namespace CSharpCompilerMVP.View
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.repositoryLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.repositoryTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.browseButton = new Telerik.WinControls.UI.RadButton();
            this.okButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 82);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(76, 19);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File Name :";
            // 
            // repositoryLabel
            // 
            this.repositoryLabel.AutoSize = true;
            this.repositoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.repositoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repositoryLabel.Location = new System.Drawing.Point(12, 140);
            this.repositoryLabel.Name = "repositoryLabel";
            this.repositoryLabel.Size = new System.Drawing.Size(81, 19);
            this.repositoryLabel.TabIndex = 1;
            this.repositoryLabel.Text = "Repository :";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(107, 82);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(204, 24);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // repositoryTextBox
            // 
            this.repositoryTextBox.Location = new System.Drawing.Point(107, 141);
            this.repositoryTextBox.Name = "repositoryTextBox";
            this.repositoryTextBox.Size = new System.Drawing.Size(204, 24);
            this.repositoryTextBox.TabIndex = 3;
            this.repositoryTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(326, 141);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(32, 24);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = ". . .";
            this.browseButton.ThemeName = "VisualStudio2012Dark";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 254);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(67, 31);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.ThemeName = "VisualStudio2012Dark";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(393, 254);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 31);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ThemeName = "VisualStudio2012Dark";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // radLabel
            // 
            this.radLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.radLabel.ForeColor = System.Drawing.Color.White;
            this.radLabel.Location = new System.Drawing.Point(16, 12);
            this.radLabel.Name = "radLabel";
            this.radLabel.Size = new System.Drawing.Size(258, 31);
            this.radLabel.TabIndex = 7;
            this.radLabel.Text = "Configure your new project";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.radLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.repositoryTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.repositoryLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 323);
            this.Name = "AddForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(480, 323);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add file";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.fileNameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label repositoryLabel;
        private Telerik.WinControls.UI.RadTextBox fileNameTextBox;
        private Telerik.WinControls.UI.RadTextBox repositoryTextBox;
        private Telerik.WinControls.UI.RadButton browseButton;
        private Telerik.WinControls.UI.RadButton okButton;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadLabel radLabel;
    }
}
