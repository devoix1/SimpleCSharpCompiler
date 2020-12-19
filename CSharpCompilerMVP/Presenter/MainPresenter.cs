using CSharpCompilerMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerMVP.Presenter
{
    class MainPresenter
    {
        private IMainFormView view;
        public MainPresenter(IMainFormView view)
        {
            this.view = view;
            view.FileCreated += View_FileCreated;
            Program.CurrentProject.Directories.CollectionChanged += Directories_CollectionChanged;
            view.RedoCommandClicked += View_RedoCommandClicked;
            view.UndoCommandClicked += ViewUndoCommandClicked;
            view.SaveAsCommandClicked += ViewSaveAsCommandClicked;
            view.ExitCommandClicked += ViewExitCommandClicked;

            view.CutCommandClicked += ViewCutCommandClicked;
            view.CopyCommandClicked += ViewCopyCommandClicked;
            view.PasteCommandClicked += ViewPasteCommandClicked;
            view.SelectAllCommandClicked += ViewSelectAllCommandClicked;

            view.FileOpened += ViewFileOpened;

        }

        private void ViewFileOpened()
        {
            view.UpdateTree();
            view.ExpandTreeView();
        }

        private void ViewSelectAllCommandClicked()
        {
            view.SelectAllCommand();
        }

        private void ViewPasteCommandClicked()
        {
            view.PasteCommand();
        }

        private void ViewCopyCommandClicked()
        {
            view.CopyCommand();
        }

        private void ViewCutCommandClicked()
        {
            view.CutCommand();
        }

        private void ViewExitCommandClicked()
        {
            view.ExitCommand();
        }

        private void ViewSaveAsCommandClicked()
        {
            view.SaveAsCommand();
        }

        private void ViewUndoCommandClicked()
        {
            view.UndoCommand();
        }

        private void View_RedoCommandClicked()
        {
            view.RedoCommand();
        }

        private void Directories_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (var path in e.NewItems)
                {
                    view.AddPage(path as string);
                }
            }
        }

        private void View_FileCreated()
        {
            view.UpdateTree();
            view.ExpandTreeView();
        }
    }
}
