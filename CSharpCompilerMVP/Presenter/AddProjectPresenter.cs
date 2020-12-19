using CSharpCompilerMVP.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerMVP.Presenter
{
    class AddProjectPresenter 
    {
       private readonly IAddProjectForm view;
        public AddProjectPresenter(IAddProjectForm view)
        {
            this.view = view;
            view.FileCreated += View_FileCreated;
        }

        private void View_FileCreated()
        {
            string path = $@"{view.Repository}\{view.FileName}.cs";

            if (Program.CurrentProject.Directories.Contains(path))
            {
                view.ShowMessageBox("File is already exist");
                return;
            }
            using (FileStream fs = File.Create(path)){

                Program.CurrentProject.Directories.Add(path);
            }
        }
    }
}
