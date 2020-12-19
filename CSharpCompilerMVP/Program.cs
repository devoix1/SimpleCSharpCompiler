using CSharpCompilerMVP.Model;
using CSharpCompilerMVP.Presenter;
using CSharpCompilerMVP.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpCompilerMVP
{
    static class Program
    {
        public static NewProject CurrentProject { get; set; } = new NewProject();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            new MainPresenter(mainForm);
            Application.Run(mainForm);
        }
    }
}