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
        }

        public bool saveProcess;

        private void imageButtonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void imageButtonFormMin_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void hopeButtonSave_Click(object sender, System.EventArgs e)
        {
            saveProcess = true;

            var saveResult = new SaveResult(this, dungeonRichTextBoxText.Text);
            saveResult.Show();
        }
    }
}
