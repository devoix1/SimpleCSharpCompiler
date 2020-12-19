using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompilerMVP.Model
{
    class NewProject
    {
        public string Name { get; set; }
        public string FileRepostitory { get; set; }
        public NewProject()
        {
            Directories = new ObservableCollection<string>();
        }

        public override string ToString()
        {
            return Name;
        }

        public ObservableCollection<string> Directories { get; set; }
    }
}
