using System;
using System.Drawing;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data.Setting;
using SceenshotTextRecognizer.Utils;

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

        private void InitializeImage()
        {
            originalImage = Screenshot.Take();

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

            if (Program.settings.selectArea.typeFon == TypeFon.Black)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, Color.Black)))
                {
                    var topRect = new Rectangle(0, 0, this.ClientSize.Width, selectionRectangle.Top);
                    var bottomRect = new Rectangle(0, selectionRectangle.Bottom, this.ClientSize.Width, this.ClientSize.Height - selectionRectangle.Bottom);
                    var leftRect = new Rectangle(0, selectionRectangle.Top, selectionRectangle.Left, selectionRectangle.Height);
                    var rightRect = new Rectangle(selectionRectangle.Right, selectionRectangle.Top, this.ClientSize.Width - selectionRectangle.Right, selectionRectangle.Height);

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
            if (Program.settings.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
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
            if (key == Program.settings.selectArea.closeSelectArea)
            {
                var dialogResult = MessageBox.Show("Отменить сканирование области?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    ProgramData.SelectSone = false;
                    Dispose();
                }
            }
            else if (key == Program.settings.selectArea.enterArea && ProgramData.SelectSone == true)
            {
                var dialogResult = MessageBox.Show("Подтверидить выделеную область для сканирования?", "Сканирование области", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Invalidate();

                    Bitmap result = originalImage.Clone(new Rectangle(
                        Math.Min(startPoint.X, endPoint.X),
                        Math.Min(startPoint.Y, endPoint.Y),
                        Math.Max(startPoint.X, endPoint.X) - Math.Min(startPoint.X, endPoint.X),
                        Math.Max(startPoint.Y, endPoint.Y) - Math.Min(startPoint.Y, endPoint.Y)), originalImage.PixelFormat);

                    ProgramData.SelectSone = false;
                    var scanSettings = new ScanSettings(result);
                    scanSettings.Show();

                    Dispose();
                }
            }
        }
    }
}
