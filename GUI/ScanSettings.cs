using System.Drawing;
using System.Windows.Forms;
using System;
using SceenshotTextRecognizer.Data;
using ReaLTaiizor.Child.Crown;
using SceenshotTextRecognizer.Properties;
using System.Threading;
using Tesseract;
using SceenshotTextRecognizer.GUI.MessageBoxes;

namespace SceenshotTextRecognizer.GUI
{
    public partial class ScanSettings : Form
    {
        public ScanSettings(Bitmap bitmap)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);
            FormUpdate();

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;

            _bitmap = bitmap;
        }

        private Bitmap _bitmap;

        private string _find;

        private string _tag;

        private bool _loading;

        private void hopeTextBoxFind_TextChanged(object sender, EventArgs e)
        {
            _find = hopeTextBoxFind.Text;
            FormUpdate();
        }

        private void crownListViewSelectModels_DoubleClick(object sender, EventArgs e)
        {
            if (crownListViewSelectModels.SelectedIndices.Count == 0)
            {
                return;
            }

            hopeTextBoxSelected.Text = crownListViewSelectModels.Items[crownListViewSelectModels.SelectedIndices[0]].Text;
            _tag = (string)crownListViewSelectModels.Items[crownListViewSelectModels.SelectedIndices[0]].Tag;

            hopeButtonScan.Enabled = true;
        }

        private void hopeButtonScan_Click(object sender, EventArgs e)
        {
            _loading = true;
            hopeButtonScan.Enabled = false;
            hopeButtonScan.Text = "Загрузка";
            Thread thread = new Thread(() =>
            {
                string model = _tag == "Model"?
                    Model.Downloaded.Find(item => item.name == hopeTextBoxSelected.Text).model :
                    string.Join("+", CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == hopeTextBoxSelected.Text).models);

                var ocrengine = new TesseractEngine(@".\tessdata", model, EngineMode.Default);

                ImageConverter converter = new ImageConverter();
                var img = Pix.LoadFromMemory((byte[])converter.ConvertTo(_bitmap, typeof(byte[])));
                var res = ocrengine.Process(img);

                _loading = false;
                BeginInvoke((MethodInvoker)delegate
                {
                    hopeButtonScan.Enabled = true;
                    hopeButtonScan.Text = "Сканировать";
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
            {
                e.Cancel = true;
            }
        }

        private void FormUpdate()
        {
            crownListViewSelectModels.Items.Clear();

            foreach (Model model in Model.Downloaded)
            {
                CrownListItem listViewItem = new CrownListItem(model.name);
                listViewItem.Tag = "Model";

                if (string.IsNullOrEmpty(_find))
                {
                    crownListViewSelectModels.Items.Add(listViewItem);
                }
                else if (model.name.IndexOf(_find) != -1)
                {
                    crownListViewSelectModels.Items.Add(listViewItem);
                }
            }

            foreach (CombinationLanguagePacks combinationLanguagePacks in CombinationLanguagePacks.combinationLanguagePacks)
            {
                CrownListItem listViewItem = new CrownListItem(combinationLanguagePacks.name);
                listViewItem.Tag = "CombinationLanguagePacks";

                if (string.IsNullOrEmpty(_find))
                {
                    crownListViewSelectModels.Items.Add(listViewItem);
                }
                else if (combinationLanguagePacks.name.IndexOf(_find) != -1)
                {
                    crownListViewSelectModels.Items.Add(listViewItem);  
                }
            }
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
