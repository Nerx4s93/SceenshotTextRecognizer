using SceenshotTextRecognizer.Data;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Tesseract;
using SceenshotTextRecognizer.GUI.MessageBoxes;

namespace SceenshotTextRecognizer.GUI
{
    public partial class ScanSettings : Form
    {
        public ScanSettings(Bitmap bitmap)
        {
            InitializeComponent();

            _bitmap = bitmap;

            FormUpdate();
        }

        private Bitmap _bitmap;

        private string _find;

        private string _tag;

        private bool _loading;

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            _find = textBoxFind.Text;
            FormUpdate();
        }

        private void listViewSelectModels_DoubleClick(object sender, EventArgs e)
        {
            if (listViewSelectModels.SelectedItems.Count < 1)
                return;

            textBoxSelected.Text = listViewSelectModels.SelectedItems[0].Text;
            _tag = (string)listViewSelectModels.SelectedItems[0].Tag;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            _loading = true;
            buttonScan.Enabled = false;
            buttonScan.Text = "Загрузка";

            Thread thread = new Thread(() =>
            {
                string model = _tag == "Model" ? textBoxSelected.Text : string.Join("+", CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == textBoxSelected.Text).models);

                var ocrengine = new TesseractEngine(@".\tessdata", model, EngineMode.Default);

                ImageConverter converter = new ImageConverter();
                var img = Pix.LoadFromMemory((byte[])converter.ConvertTo(_bitmap, typeof(byte[])));
                var res = ocrengine.Process(img);

                _loading = false;
                BeginInvoke((MethodInvoker)delegate
                {
                    buttonScan.Enabled = true;
                    buttonScan.Text = "Сканировать";
                });

                ImageTextResult imageTextResult = new ImageTextResult(res.GetText());
                imageTextResult.ShowDialog();
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        private void ScanSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loading)
                e.Cancel = true;
        }

        public void FormUpdate()
        {
            listViewSelectModels.Clear();

            foreach (Model model in Model.Downloaded)
            {
                ListViewItem listViewItem = new ListViewItem(model.model);
                listViewItem.Tag = "Model";

                if (string.IsNullOrEmpty(_find))
                    listViewSelectModels.Items.Add(listViewItem);
                else if (model.model.IndexOf(_find) != -1)
                    listViewSelectModels.Items.Add(listViewItem);
            }

            foreach (CombinationLanguagePacks combinationLanguagePacks in CombinationLanguagePacks.combinationLanguagePacks)
            {
                ListViewItem listViewItem = new ListViewItem(combinationLanguagePacks.name);
                listViewItem.Tag = "CombinationLanguagePacks";

                if (string.IsNullOrEmpty(_find))
                    listViewSelectModels.Items.Add(listViewItem);
                else if (combinationLanguagePacks.name.IndexOf(_find) != -1)
                    listViewSelectModels.Items.Add(listViewItem);
            }
        }
    }
}
