using System;
using System.Drawing;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.UI
{
    public class ImageButton : ButtonBase
    {
        private bool _onMouseEnter;

        public ImageButton()
        {
            DoubleBuffered = true;
        }

        public Image ImageDeffault { get; set; }

        public Image ImageOnMouseEnter { get; set; }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            _onMouseEnter = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _onMouseEnter = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (_onMouseEnter && ImageOnMouseEnter != null)
            {
                pevent.Graphics.DrawImage(ImageOnMouseEnter, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else if (ImageDeffault != null)
            {
                pevent.Graphics.DrawImage(ImageDeffault, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Size.Width, Size.Height);
            }
        }
    }
}
