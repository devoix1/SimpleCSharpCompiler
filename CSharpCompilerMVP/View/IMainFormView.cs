using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerMVP.View
{
    interface IMainFormView
    {
        event Action UndoCommandClicked;
        event Action RedoCommandClicked;
        event Action CutCommandClicked;
        event Action CopyCommandClicked;
        event Action PasteCommandClicked;
        event Action SelectAllCommandClicked;
        /////////////////////////////////////////
        event Action SaveCommandClicked;
        event Action SaveAsCommandClicked;
        event Action LoadCommandClicked;
        event Action ExitCommandClicked;

        event Action FileCreated;
        event Action FileOpened;

        void AddPage(string path);
        void UpdateTree();
        void ExpandTreeView();
        /////////////////////////////////////////
        void UndoCommand();
        void RedoCommand();
        void CutCommand();
        void CopyCommand();
        void PasteCommand();
        void SelectAllCommand();
        ///////////////////////////////////////
        void SaveCommand();
        void SaveAsCommand();
        void LoadCommand();
        

        void ExitCommand();
    }
}
