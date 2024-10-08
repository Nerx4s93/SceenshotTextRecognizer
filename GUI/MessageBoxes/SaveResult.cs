﻿using System;
using System.IO;
using System.Windows.Forms;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class SaveResult : BaseForm
    {
        public SaveResult(ImageTextResult form, string text)
        {
            parant = form;
            this.text = text;

            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);
        }

        private ImageTextResult parant;
        private string text;

        private void hopeButtonBrowseDirectory_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();

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

                            var body = new Body();
                            var paragraph = new Paragraph();
                            var run = new Run();
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
    }
}
