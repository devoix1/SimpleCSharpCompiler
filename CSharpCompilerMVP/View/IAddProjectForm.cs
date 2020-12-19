using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerMVP.View
{
    interface IAddProjectForm
    {
        string FileName { get; }
        string Repository { get; }

        event Action FileCreated;
        void ShowMessageBox(string msg);

    }
}
