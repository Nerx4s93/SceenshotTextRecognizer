using System;
using System.Drawing;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI
{
    public partial class BaseForm : Form
    {
        private bool _showButtonMinimized = true;
        private bool _showButtonClose = true;

        public BaseForm()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                Title.Text = value;
                Title.Invalidate();
            }
        }

        public bool ShowButtonMinimized
        {
            get
            {
                return _showButtonMinimized;
            }
            set
            {
                _showButtonMinimized = value;
                ButtonMinimized.Visible = value;
                UpdateTitleButtonLocation();
            }
        }

        public bool ShowButtonClose
        {
            get
            {
                return _showButtonClose;
            }
            set
            {
                _showButtonClose = value;
                ButtonClose.Visible = value;
                UpdateTitleButtonLocation();
            }
        }

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateTitleButtonLocation()
        {
            if (ShowButtonMinimized && ShowButtonClose)
            {
                ButtonMinimized.Location = new Point(Width - 57, 8);
                ButtonClose.Location = new Point(Width - 33, 8);
            }
            else
            {
                ButtonMinimized.Location = new Point(Width - 34, 8);
                ButtonClose.Location = new Point(Width - 34, 8);
            }
        }
    }
}
