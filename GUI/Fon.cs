using System;
using System.Drawing;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data.Setting;

namespace SceenshotTextRecognizer.GUI
{
    public partial class Fon : Form
    {
        private Bitmap originalImage;
        private Rectangle selectionRectangle;
        private Point startPoint;
        private Point endPoint;
        private bool isMouseDown;

        public Fon()
        {
            new OnTopControl(Handle);
            InitializeComponent();
            Location = new Point(0, 0);
            InitializeImage();
            isMouseDown = false;
            DoubleBuffered = true;
        }

        private Bitmap TakeScreenshot()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(screenBounds.X, screenBounds.Y, 0, 0, screenBounds.Size);
            }

            return screenshot;
        }

        private void InitializeImage()
        {
            originalImage = TakeScreenshot();

            ClientSize = new Size(originalImage.Width, originalImage.Height);

            selectionRectangle = new Rectangle(0, 0, 0, 0);
        }

        private void Fon_Paint(object sender, PaintEventArgs e)
        {
            int x = Math.Min(endPoint.X, startPoint.X);
            int y = Math.Min(endPoint.Y, startPoint.Y);
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);
            selectionRectangle = new Rectangle(x, y, width, height);

            e.Graphics.DrawImage(originalImage, 0, 0);

            if (Program.config.selectArea.typeFon == TypeFon.Black)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, Color.Black)))
                {
                    Rectangle topRect = new Rectangle(0, 0, this.ClientSize.Width, selectionRectangle.Top);
                    Rectangle bottomRect = new Rectangle(0, selectionRectangle.Bottom, this.ClientSize.Width, this.ClientSize.Height - selectionRectangle.Bottom);
                    Rectangle leftRect = new Rectangle(0, selectionRectangle.Top, selectionRectangle.Left, selectionRectangle.Height);
                    Rectangle rightRect = new Rectangle(selectionRectangle.Right, selectionRectangle.Top, this.ClientSize.Width - selectionRectangle.Right, selectionRectangle.Height);

                    e.Graphics.FillRectangle(brush, topRect);
                    e.Graphics.FillRectangle(brush, bottomRect);
                    e.Graphics.FillRectangle(brush, leftRect);
                    e.Graphics.FillRectangle(brush, rightRect);
                }
            }

            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, selectionRectangle);
            }
        }

        private void Fon_MouseDown(object sender, MouseEventArgs e)
        {
            if (Program.config.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = true;
                    startPoint = e.Location;
                    selectionRectangle = new Rectangle(startPoint, new Size(0, 0));
                    Invalidate();
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint = new Point(e.X, e.Y);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    endPoint = new Point(e.X, e.Y);
                }

                Invalidate();
            }
        }

        private void Fon_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                endPoint = new Point(e.X, e.Y);
                Invalidate();
            }
        }

        private void Fon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        public void FormKeyDown(Keys key)
        {
            if (key == Program.config.selectArea.closeSelectArea)
            {
                DialogResult dialogResult = MessageBox.Show("Отменить сканирование области?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    ProgramData.SelectSone = false;
                    Dispose();
                }
            }
            else if (key == Program.config.selectArea.enterArea && ProgramData.SelectSone == true)
            {
                DialogResult dialogResult = MessageBox.Show("Подтверидить выделеную область для сканирования?", "Сканирование области", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Invalidate();

                    Bitmap result = originalImage.Clone(new Rectangle(
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Max(startPoint.X, endPoint.X) - Math.Min(startPoint.X, endPoint.X),
                        Math.Max(startPoint.Y, endPoint.Y) - Math.Min(startPoint.Y, endPoint.Y)), originalImage.PixelFormat);

                    ProgramData.SelectSone = false;
                    ScanSettings scanSettings = new ScanSettings(result);
                    scanSettings.Show();

                    Dispose();
                }
            }
        }
    }
}
