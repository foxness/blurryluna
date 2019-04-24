using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Blurryluna
{
    public partial class MainWindow : Form
    {
        private static readonly string datetimeFormat = "yyyy-MM-dd HH-mm-ss";

        private Bitmap screenshot;
        private DateTime screenshotTime;

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

        private void SaveScreenshot()
        {
            var name = nameTextbox.Text;
            var time = screenshotTime.ToString(datetimeFormat);
            var extension = ".png";

            var filename = $"{name} {time}{extension}".Trim();

            screenshot.Save(filename, ImageFormat.Png);
        }

        private void SaveAndExit()
        {
            SaveScreenshot();
            Exit();
        }

        private void LoadScreenshot()
        {
            screenshot = TakeScreenshot();
            screenshotTime = DateTime.Now;
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void dontsaveButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadScreenshot();
        }
    }
}
