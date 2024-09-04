using System;
using System.IO;
using System.Windows.Forms;

using SceenshotTextRecognizer.Properties;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class SaveResult : Form
    {
        public SaveResult(ImageTextResult form, string text)
        {
            parant = form;
            this.text = text;

            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;
        }

        private ImageTextResult parant;
        private string text;

        private void hopeButtonBrowseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                hopeTextBoxDirectoryPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void hopeButtonSave_Click(object sender, EventArgs e)
        {
            string selected = hopeComboBoxFileExtension.GetItemText(hopeComboBoxFileExtension.SelectedItem);

            if (hopeTextBoxDirectoryPath.Text == string.Empty || hopeTextBoxFileName.Text == string.Empty || selected == string.Empty)
            {
                MessageBox.Show("Вы заполнили не все поля.", "Введены не все данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = Path.Combine(hopeTextBoxDirectoryPath.Text, $"{hopeTextBoxFileName.Text}{selected}");

            switch (selected)
            {
                case ".txt":
                    {
                        File.WriteAllText(path, text);

                        break;
                    }
                case ".docx":
                    {
                        using (WordprocessingDocument document = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
                        {
                            MainDocumentPart mainPart = document.AddMainDocumentPart();
                            mainPart.Document = new Document();

                            Body body = new Body();
                            Paragraph paragraph = new Paragraph();
                            Run run = new Run();
                            run.Append(new Text(text));
                            paragraph.Append(run);
                            body.Append(paragraph);

                            mainPart.Document.Append(body);
                        }

                        break;
                    }
            }

            MessageBox.Show("Файл успешно сохранён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            parant.saveProcess = false;
            Close();
        }

        private void imageButtonFormMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
