using System.Windows.Forms;
using WorkingScreen;
using System.Drawing;
using System;
using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.Data.Setting;

namespace SceenshotTextRecognizer.GUI
{
    public partial class Fon : Form
    {
        public Fon()
        {
            new OnTopControl(Handle);
            InitializeComponent();

            Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Location = new Point(0, 0);

            _screenshot = TakeSceenShow();
            _screenshotWithBorders = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private Bitmap _screenshot;

        private Bitmap _screenshotWithBorders;

        private bool _drawed = false;

        private void Fon_Paint(object sender, PaintEventArgs e)
        {
            if (_drawed == false)
            {
                Graphics graphics = CreateGraphics();
                graphics.DrawImage(_screenshot, new Point(0, 0));

                if (Main.main.selectArea.typeFon == TypeFon.Black)
                {
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(124, 0, 0, 0)), 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                }
            }
        }

        #region Select

        private bool _moseDown = false;

        private Point _startPoint = new Point(0, 0);
        private Point _endPoint = new Point(0, 0);

        private void Fon_MouseDown(object sender, MouseEventArgs e)
        {
            if (Main.main.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                _startPoint = new Point(e.X, e.Y);
                _moseDown = true;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    _startPoint = new Point(e.X, e.Y);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    _endPoint = new Point(e.X, e.Y);
                }

                Draw();
            }
        }

        private void Fon_MouseUp(object sender, MouseEventArgs e)
        {
            if (Main.main.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                _endPoint = new Point(e.X, e.Y);
                _moseDown = false;
            }
        }

        private void Fon_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moseDown == true && Main.main.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                _endPoint = new Point(e.X, e.Y);
                Draw();
            }
        }

        #endregion

        public void FormKeyDown(Keys key)
        {
            if (key == Main.main.selectArea.closeSelectArea)
            {
                DialogResult dialogResult = MessageBox.Show("Отменить сканирование области?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    ProgramData.SelectSone = false;
                    Dispose();
                }
            }
            else if (key == Main.main.selectArea.enterArea && ProgramData.SelectSone == true)
            {
                DialogResult dialogResult = MessageBox.Show("Подтверидить выделеную область для сканирования?", "Сканирование области", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    CreateGraphics().DrawImage(_screenshotWithBorders, new Point(0, 0));

                    Bitmap result = _screenshot.Clone(new Rectangle(
                        Math.Min(_startPoint.X, _endPoint.X),
                        Math.Min(_startPoint.Y, _endPoint.Y),
                        Math.Max(_startPoint.X, _endPoint.X) - Math.Min(_startPoint.X, _endPoint.X),
                        Math.Max(_startPoint.Y, _endPoint.Y) - Math.Min(_startPoint.Y, _endPoint.Y)), _screenshot.PixelFormat);

                    ProgramData.SelectSone = false;
                    ScanSettings scanSettings = new ScanSettings(result);
                    scanSettings.Show();

                    Dispose();
                }
            }
        }

        private void Draw()
        {
            _screenshotWithBorders = (Bitmap)_screenshot.Clone();

            Graphics graphicsBorders = Graphics.FromImage(_screenshotWithBorders);

            int minX = Math.Min(_startPoint.X, _endPoint.X);
            int maxX = Math.Max(_startPoint.X, _endPoint.X);
            int minY = Math.Min(_startPoint.Y, _endPoint.Y);
            int maxY = Math.Max(_startPoint.Y, _endPoint.Y);

            if (Main.main.selectArea.typeFon == TypeFon.Black)
            {
                var solidBrush = new SolidBrush(Color.FromArgb(124, 0, 0, 0));
                graphicsBorders.FillRectangle(solidBrush, 0, 0, Screen.PrimaryScreen.Bounds.Width, minY);
                graphicsBorders.FillRectangle(solidBrush, 0, minY, minX, maxY - minY);
                graphicsBorders.FillRectangle(solidBrush, maxX, minY, Screen.PrimaryScreen.Bounds.Width - maxX, maxY - minY);
                graphicsBorders.FillRectangle(solidBrush, 0, maxY, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - _endPoint.Y);
            }
            else if (Main.main.selectArea.typeFon == TypeFon.None)
            {
                var solidBrush = new SolidBrush(Color.FromArgb(255, 245, 245, 245));
                graphicsBorders.FillRectangle(solidBrush, minX, minY - 5, maxX - minX, 5);
                graphicsBorders.FillRectangle(solidBrush, maxX, minY - 5, 5, maxY - minY + 10);
                graphicsBorders.FillRectangle(solidBrush, minX, maxY, maxX - minX, 5);
                graphicsBorders.FillRectangle(solidBrush, minX - 5, minY - 5, 5, maxY - minY + 10);
            }

            Graphics formGraphics = CreateGraphics();
            formGraphics.DrawImage(_screenshotWithBorders, new Point(0, 0));
        }

        private Bitmap TakeSceenShow()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);

            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(screenBounds.X, screenBounds.Y, 0, 0, screenBounds.Size);

            return screenshot;
        }
    }
}
