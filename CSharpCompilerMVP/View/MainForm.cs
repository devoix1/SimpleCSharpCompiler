using CSharpCompilerMVP.Presenter;
using CSharpCompilerMVP.Services;
using CSharpCompilerMVP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Controls.SyntaxEditor.Palettes;
using Telerik.WinForms.Controls.SyntaxEditor.Taggers;
using Telerik.WinForms.SyntaxEditor.Core.Text;

namespace CSharpCompilerMVP
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm, IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event Action UndoCommandClicked;
        public event Action RedoCommandClicked;
        public event Action SaveCommandClicked;
        public event Action SaveAsCommandClicked;
        public event Action LoadCommandClicked;
        public event Action CutCommandClicked;
        public event Action SelectAllCommandClicked;
        public event Action ExitCommandClicked;
        public event Action FileCreated;
        public event Action CopyCommandClicked;
        public event Action PasteCommandClicked;
        public event Action FileOpened;

        Compiler compiler = new Compiler();

        public void AddPage(string path)
        {
            RadPageViewPage radPageViewPage = new RadPageViewPage() { Text = Path.GetFileName(path) };
            RadSyntaxEditor editor = new RadSyntaxEditor() { ThemeName = "VisualStudio2012Dark" };

            radPageViewPage.Controls.Add(editor);

            var customPalette = new SyntaxEditorPalette();
            customPalette.KeywordColor = Color.FromArgb(0, 132, 255);
            customPalette.PreprocessorKeywordColor = Color.FromArgb(132, 132, 132);
            customPalette.CommentColor = Color.FromArgb(0, 102, 51);
            customPalette.IdentifierColor = Color.FromArgb(191, 191, 191);
            customPalette.OperatorColor = Color.FromArgb(2, 163, 101);
            editor.Palette = customPalette;
            editor.Dock = DockStyle.Fill;

            CSharpTagger cSharptagger = new CSharpTagger(editor.SyntaxEditorElement);
            editor.TaggersRegistry.RegisterTagger(cSharptagger);
           

            radPageView.Controls.Add(radPageViewPage);
            
        }

        public void CutCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.CutCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        public void ExitCommand()
        {
            Close();
        }

        public void ExpandTreeView()
        {
            radTreeView.ExpandAll();
        }

        public void LoadCommand()
        {
            throw new NotImplementedException();
        }

        public void RedoCommand()
        {

            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.RedoCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        public void SaveAsCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                
                 var sfd = new SaveFileDialog();
                sfd.Filter = "CSharp files (.cs) |  *.cs";
                if (sfd.ShowDialog() == DialogResult.OK)
                 {
                     using (var stream = new StreamWriter(sfd.FileName))
                     {
                         stream.Write(editor.Document.CurrentSnapshot.GetText());
                     }
                 }
            }
        }

        public void SaveCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {

                    using (var stream = new StreamWriter(Path.GetFileName(Directory.GetCurrentDirectory())))
                    {
                        stream.Write(editor.Document.CurrentSnapshot.GetText());
                    }
            }
        }

        public void SelectAllCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.SelectAllCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        public void UndoCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.UndoCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        public void UpdateTree()
        {

            string title;
            if (Program.CurrentProject.Directories.Count > 0){ title = Path.GetDirectoryName(Program.CurrentProject.Directories[0]).Split('\\').Last();}
            else { title = "Untitled"; }
            RadTreeNode root = new RadTreeNode() {Text = title, ImageIndex = 0 };
            foreach (var item in Program.CurrentProject.Directories)
            {
                root.Nodes.Add(new RadTreeNode() { Text = Path.GetFileName(item), ImageIndex = 1 });
                
            }
            radTreeView.Nodes.Clear();
            radTreeView.Nodes.Add(root);
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            new AddProjectPresenter(form);
            form.FileCreated += () => FileCreated?.Invoke();
            form.ShowDialog(); 
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                compiler.Compile(editor, Path.GetDirectoryName(Program.CurrentProject.Directories[0]));
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            UndoCommandClicked?.Invoke();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            RedoCommandClicked?.Invoke();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "CSharp files (.cs) |  *.cs";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddPage(ofd.FileName);
            }

            if (radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                using (var stream = new StreamReader(ofd.FileName))
                {
                    editor.Document = new TextDocument(stream);
                }
            }
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            UndoCommandClicked?.Invoke();
        }

        public void CopyCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.CopyCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        public void PasteCommand()
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                editor.Commands.PasteCommand.Execute(editor.Document.CurrentSnapshot.GetText());
            }
        }

        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            RedoCommandClicked?.Invoke();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            CutCommandClicked?.Invoke();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            CopyCommandClicked?.Invoke();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            PasteCommandClicked?.Invoke();
        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllCommandClicked?.Invoke();
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            new AddProjectPresenter(form);
            form.FileCreated += () => FileCreated?.Invoke();
            form.ShowDialog();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsCommandClicked?.Invoke();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            ExitCommandClicked?.Invoke();
        }

        private void runMenuItem_Click(object sender, EventArgs e)
        {
            if (radPageView.SelectedPage != null && radPageView.SelectedPage.Controls.Count > 0 && radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                compiler.Compile(editor, Path.GetDirectoryName(Program.CurrentProject.Directories[0]));
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "CSharp files (.cs) |  *.cs";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddPage(ofd.FileName);
                FileOpened?.Invoke();
            }


            if (radPageView.SelectedPage.Controls[0] is RadSyntaxEditor editor)
            {
                using (var stream = new StreamReader(ofd.FileName))
                {
                    editor.Document = new TextDocument(stream);
                }
            }
        }


    }
}
