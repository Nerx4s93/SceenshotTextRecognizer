using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SceenshotTextRecognizer
{
    public static class CustomForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static void RoundOffTheEdges(Form form)
        {
            form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 20, 20));
        }
    }
}
