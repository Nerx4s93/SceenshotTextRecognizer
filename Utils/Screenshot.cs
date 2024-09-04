using System.Drawing;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.Utils
{
    internal static class Screenshot
    {
        public static Bitmap Take()
        {
            var screenBounds = Screen.PrimaryScreen.Bounds;

            var point = new Point(screenBounds.X, screenBounds.Y);
            var size = new Size(screenBounds.Width, screenBounds.Height);

            var screenshot = Take(point, size);

            return screenshot;
        }

        public static Bitmap Take(Point point, Size size)
        {
            var screenshot = new Bitmap(size.Width, size.Height);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(point, new Point(0, 0), size);
            }

            return screenshot;
        }
    }
}
