using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Process firstProc = new Process();
            firstProc.StartInfo.FileName = @"R:\my\projects\blurryluna\Blurryluna\bin\Debug\Blurryluna.exe";
            //firstProc.EnableRaisingEvents = true;

            firstProc.Start();

            //firstProc.WaitForExit();
        }
    }
}
