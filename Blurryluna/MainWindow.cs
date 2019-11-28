using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Blurryluna
{
    public partial class MainWindow : Form
    {
        private static readonly string datetimeFormat = "yyyy-MM-dd HH-mm-ss";
        private static readonly string configName = "blurryluna.cfg";
        private static readonly string configSavePath = "savePath=";
        private static readonly string badChars = "\\/:*?\"<>|";

        private Bitmap screenshot;
        private DateTime screenshotTime;
        private string screenshotName;
        private string screenshotSavePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private Bitmap TakeScreenshot()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            var bitmap = new Bitmap(bounds.Width, bounds.Height);
            var g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);

            return bitmap;
        }

        private bool TryGetScreenshotName()
        {
            var name = nameTextbox.Text.Trim();

            string message = null;
            if (name.Length == 0)
            {
                message = "The name is empty";
            }
            else if (name.IndexOfAny(badChars.ToCharArray()) != -1)
            {
                message = "The name contains bad characters";
            }

            if (message != null)
            {
                MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                screenshotName = null;
                return false;
            }
            else
            {
                screenshotName = name;
                return true;
            }
        }

        private bool TrySaveScreenshot()
        {
            var gotName = TryGetScreenshotName();
            if (!gotName)
            {
                return false;
            }

            var name = screenshotName;
            var time = screenshotTime.ToString(datetimeFormat);
            var extension = ".png";

            time = time.Trim();
            extension = extension.Trim();

            var filename = $"{name} {time}{extension}";
            var path = Path.Combine(screenshotSavePath, filename);

            screenshot.Save(path, ImageFormat.Png);

            return true;
        }

        private void TrySaveAndExit()
        {
            var saved = TrySaveScreenshot();
            if (saved)
            {
                Exit();
            }
        }

        private void LoadScreenshot()
        {
            screenshot = TakeScreenshot();
            screenshotTime = DateTime.Now;
        }

        private void LoadConfig()
        {
            var startupPath = Application.StartupPath;
            var configPath = Path.Combine(startupPath, configName);

            string message = null;
            bool badMessageSentiment = true; 
            if (File.Exists(configPath))
            {
                var configRaw = File.ReadAllText(configPath);
                if (configRaw.StartsWith(configSavePath))
                {
                    var loadedSavePath = configRaw.Substring(configSavePath.Length).Trim();
                    if (Directory.Exists(loadedSavePath))
                    {
                        screenshotSavePath = loadedSavePath;
                    }
                    else
                    {
                        message = "The save path in your config was bad so I've created a new config";
                    }
                }
                else
                {
                    message = "Your config format was bad so I've created a new config";
                }
            }
            else
            {
                message = "You didn't have a config so I created one";
                badMessageSentiment = false;
            }

            if (message != null)
            {
                screenshotSavePath = startupPath;
                var configRaw = $"{configSavePath}{screenshotSavePath}";
                File.WriteAllText(configPath, configRaw);

                var icon = badMessageSentiment ? MessageBoxIcon.Warning : MessageBoxIcon.Information;
                MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, icon);
            }
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TrySaveAndExit();
        }

        private void dontsaveButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadScreenshot();
            LoadConfig();
        }
    }
}
