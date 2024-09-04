using System;
using System.Drawing;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.UI
{
    public class ImageButton : ButtonBase
    {
        private Image _imageDeffault;
        private Image _imageOnMouseEnter;

        private bool _onMouseEnter;

        public ImageButton()
        {
            DoubleBuffered = true;
        }

        public Image ImageNoHovered
        {
            get
            {
                return _imageDeffault;
            }
            set
            {
                if (_imageDeffault != value)
                {
                    _imageDeffault = value;
                    Invalidate();
                }
            }
        }

        public Image ImageOnHovered
        {
            get
            {
                return _imageOnMouseEnter;
            }
            set
            {
                if (_imageOnMouseEnter != value)
                {
                    _imageOnMouseEnter = value;
                    Invalidate();
                }
            }
        }

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
            if (_onMouseEnter && _imageOnMouseEnter != null)
            {
                pevent.Graphics.DrawImage(_imageOnMouseEnter, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else if (_imageDeffault != null)
            {
                pevent.Graphics.DrawImage(_imageDeffault, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Size.Width, Size.Height);
            }
        }
    }
}
