using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CSharpCompilerMVP.View
{
    public partial class AddForm : Telerik.WinControls.UI.RadForm, IAddProjectForm
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public string Repository => repositoryTextBox.Text;
        public string FileName => fileNameTextBox.Text;

        public event Action FileCreated;

        public void ShowMessageBox(string msg)
        {
            MessageBox.Show(msg);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    repositoryTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FileCreated?.Invoke();
            Close();
        }
    }
}
