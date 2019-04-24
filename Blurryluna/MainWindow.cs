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
        private Bitmap screenshot;

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

        private void okButton_Click(object sender, EventArgs e)
        {
            var name = nameTextbox.Text;

            if (name == String.Empty)
            {
                name = "testy";
            }

            name += ".png";

            screenshot.Save(name, ImageFormat.Png);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            screenshot = TakeScreenshot();
        }
    }
}
