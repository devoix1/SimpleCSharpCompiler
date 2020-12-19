using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CSharpCompilerMVP.Services
{
    class Compiler
    {
        public void Compile(RadSyntaxEditor syntaxEditor, string projectName)
        {
            var domProvider = CodeDomProvider.CreateProvider("CS");

            var cstextCode = syntaxEditor.Document.CurrentSnapshot.GetText();

            CompilerParameters compilerParams = new System.CodeDom.Compiler.CompilerParameters();

            compilerParams.GenerateExecutable = true;

            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add("System.Core.dll");
            compilerParams.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            compilerParams.ReferencedAssemblies.Add("System.IO.dll");
            compilerParams.ReferencedAssemblies.Add("System.Linq.dll");

            compilerParams.CompilerOptions = "/optimize /target:exe";

            compilerParams.OutputAssembly = projectName + ".exe";

            var resultCompiler = domProvider.CompileAssemblyFromSource(compilerParams, new string[] { cstextCode });

            if (resultCompiler.Errors.HasErrors)
            {
                MessageBox.Show(resultCompiler.Errors[0].ErrorText);
            }
            else
                Process.Start($"{projectName}.exe");
        }

    }
}

