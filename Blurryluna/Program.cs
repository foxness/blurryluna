using System;
using System.Threading;
using System.Windows.Forms;

namespace Blurryluna
{
    static class Program
    {
        private static readonly string mutexName = Application.ProductName + Application.ProductVersion;

        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(false, mutexName))
            {
                bool firstInstance = mutex.WaitOne(TimeSpan.Zero);
                if (firstInstance)
                {
                    RunApp();
                    mutex.ReleaseMutex();
                }
            }
        }

        static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
