using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.UI
{
    public class ImageButton : ButtonBase
    {
        private Image _imageNoHovered;
        private Image _imageOnHover;
        private bool _onHover;

        [Localizable(true)]
        public Image ImageNoHovered
        {
            get
            {
                return _imageNoHovered;
            }
            set
            {
                if (_imageNoHovered != value)
                {
                    _imageNoHovered = value;
                    Invalidate();
                }
            }
        }

        [Localizable(true)]
        public Image ImageOnHovered
        {
            get
            {
                return _imageOnHover;
            }
            set
            {
                if (_imageOnHover != value)
                {
                    _imageOnHover = value;
                    Invalidate();
                }
            }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            _onHover = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _onHover = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (_onHover && _imageOnHover != null)
            {
                pevent.Graphics.DrawImage(_imageOnHover, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else if (_imageNoHovered != null)
            {
                pevent.Graphics.DrawImage(_imageNoHovered, 0, 0, ClientSize.Width, ClientSize.Height);
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Size.Width, Size.Height);
            }
        }
    }
}
