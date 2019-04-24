using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveScreenshot();
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            screenshot = TakeScreenshot();
            screenshotTime = DateTime.Now;
        }
    }
}
