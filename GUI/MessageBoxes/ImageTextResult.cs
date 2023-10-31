using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class ImageTextResult : Form
    {
        public ImageTextResult(string text)
        {
            InitializeComponent();
            richTextBoxText.Text = text;
        }
    }
}
