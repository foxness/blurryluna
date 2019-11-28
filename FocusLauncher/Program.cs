using System;
using System.Diagnostics;
using System.IO;

namespace FocusLauncher
{
    public class Program
    {
        private static readonly string configFilename = "FocusLauncher.cfg";
        private static readonly string messageFilename = "FocusLauncherMessage.txt";

        private static readonly string configRunPath = "runPath=";

        private static string runPath = null;

        public static void Main(string[] args)
        {
            LoadConfig();
            RunApp();
        }

        private static void RunApp()
        {
            if (runPath == null)
            {
                return;
            }

            // https://stackoverflow.com/questions/1112981/how-do-i-launch-application-one-from-another-in-c

            var app = new Process();
            app.StartInfo.FileName = runPath;

            // firstProc.EnableRaisingEvents = true;

            app.Start();

            // firstProc.WaitForExit();
        }

        private static void LoadConfig()
        {
            var startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var configPath = Path.Combine(startupPath, configFilename);

            string message = null;
            if (File.Exists(configPath))
            {
                var configRaw = File.ReadAllText(configPath);
                if (configRaw.StartsWith(configRunPath))
                {
                    var loadedRunPath = configRaw.Substring(configRunPath.Length).Trim();
                    if (File.Exists(loadedRunPath))
                    {
                        runPath = loadedRunPath;
                    }
                    else
                    {
                        message = "The run path in the config was bad";
                    }
                }
                else
                {
                    message = "The config format was bad";
                }
            }
            else
            {
                message = "No config was found";
            }

            if (message != null)
            {
                var configRaw = $"{configRunPath}insertPathHere";
                File.WriteAllText(configPath, configRaw);

                var messagePath = Path.Combine(startupPath, messageFilename);
                File.WriteAllText(messagePath, message);
            }
        }
    }
}
