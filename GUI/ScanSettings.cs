using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.GUI.MessageBoxes;

using ReaLTaiizor.Child.Crown;
using Tesseract;

namespace SceenshotTextRecognizer.GUI
{
    public partial class ScanSettings : BaseForm
    {
        public ScanSettings(Bitmap bitmap)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);
            FormUpdate();

            _bitmap = bitmap;
        }

        private Bitmap _bitmap;

        private string _find;

        private string _tag;

        private bool _loading;

        private ImageTextResult imageTextResult;

        private void hopeTextBoxFind_TextChanged(object sender, EventArgs e)
        {
            _find = hopeTextBoxFind.Text;
            FormUpdate();
        }

        private void crownListViewSelectModels_DoubleClick(object sender, EventArgs e)
        {
            if (crownListViewSelectModels.SelectedIndices.Count == 0 || _loading)
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
            var thread = new Thread(() =>
            {
                Model model = Model.Downloaded.Find(item => item.Name == hopeTextBoxSelected.Text);

                string strModel = _tag == "Model" ?
                    model.Code :
                    string.Join("+", CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == hopeTextBoxSelected.Text).models);

                var ocrengine = new TesseractEngine(@".\tessdata", strModel, EngineMode.Default);

                ImageConverter converter = new ImageConverter();
                var img = Pix.LoadFromMemory((byte[])converter.ConvertTo(_bitmap, typeof(byte[])));
                var res = ocrengine.Process(img);

                #region Обработка текста

                string text = Program.settings.scanResult.removeExtraSpaces ? res.GetText().Replace("  ", " ") : res.GetText();
                List<string> strings = text.Split('\n').ToList();

                if (Program.settings.scanResult.deleteEmptyLines)
                {
                    strings.RemoveAll(s => string.IsNullOrEmpty(s));
                }
                if (Program.settings.scanResult.deleteLinesWithoutLetters)
                {
                    bool remove = true;

                    if (strModel.IndexOf('+') == -1 && strModel != "rus" && strModel != "eng")
                    {
                        remove = false;
                    }
                    else if (strModel.IndexOf('+') != -1)
                    {
                        List<string> strs = CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == hopeTextBoxSelected.Text).models;
                        if (strs.Count != 2 || !(strs[0] == "rus" & strs[1] == "eng") || !(strs[0] == "eng" & strs[1] == "rus"))
                        {
                            remove = false;
                        }
                    }

                    if (remove)
                    {
                        strings.RemoveAll(s => !s.Any(char.IsLetter));
                    }
                }

                string result = string.Join("\n", strings);

                #endregion

                _loading = false;
                BeginInvoke((MethodInvoker)delegate
                {
                    if (imageTextResult == null || imageTextResult.IsDisposed)
                    {
                        imageTextResult = new ImageTextResult(result);
                        imageTextResult.Show();
                    }

                    hopeButtonScan.Enabled = true;
                    hopeButtonScan.Text = "Сканировать";
                    hopeButtonScan.Refresh();
                });
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
            if (hopeTextBoxSelected.Text != string.Empty)
            {
                hopeButtonScan.Enabled = true;
            }

            crownListViewSelectModels.Items.Clear();

            foreach (Model model in Model.Downloaded)
            {
                var listViewItem = new CrownListItem(model.Name);
                listViewItem.Tag = "Model";

                if (string.IsNullOrEmpty(_find))
                {
                    crownListViewSelectModels.Items.Add(listViewItem);
                }
                else if (model.Name.IndexOf(_find) != -1)
                {
                    crownListViewSelectModels.Items.Add(listViewItem);
                }
            }

            foreach (var combinationLanguagePacks in CombinationLanguagePacks.combinationLanguagePacks)
            {
                var listViewItem = new CrownListItem(combinationLanguagePacks.name);
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
    }
}
