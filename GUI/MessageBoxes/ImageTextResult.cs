using SceenshotTextRecognizer.Properties;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class ImageTextResult : Form
    {
        public ImageTextResult(string text)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);
            dungeonRichTextBoxText.Text = text;

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;
        }

        private void imageButtonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void imageButtonFormMin_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
