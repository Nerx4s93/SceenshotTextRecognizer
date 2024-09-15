using System;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class ImageTextResult : BaseForm
    {
        public ImageTextResult(string text)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            dungeonRichTextBoxText.Text = text;
        }

        private void hopeButtonSave_Click(object sender, EventArgs e)
        {
            var saveResult = new SaveResult(this, dungeonRichTextBoxText.Text);
            saveResult.Show();
        }
    }
}
