using System.Collections.Generic;
using System.Windows.Forms;
using System;
using SceenshotTextRecognizer.Data;
using System.Drawing;
using System.Net;
using System.Threading;
using System.ComponentModel;
using System.IO;
using SceenshotTextRecognizer.Properties;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class DownloadModel : Form
    {
        private class Item
        {
            public Item(Model model, bool selected)
            {
                this.model = model;
                this.selected = selected;
            }

            public Model model;
            public bool selected;
        }

        public DownloadModel(FormMain formMain)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            this.formMain = formMain;

            foreach (Model model in Model.CanDownload)
                items.Add(new Item(model, false));

            UpdateForm();

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;
        }

        private FormMain formMain;

        List<Item> items = new List<Item>();

        #region panelSelectDownload

        private void checkedListBoxLanguages_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxLanguages.CheckedItems.Count != 0)
            {
                hopeButtonStartDownload.Enabled = true;
            }
            else
            {
                hopeButtonStartDownload.Enabled = false;
            }

            foreach (var checkedItemCollection in checkedListBoxLanguages.CheckedItems)
            {
                Item _item = items.Find(item => item.model.name == checkedItemCollection.ToString());
                _item.selected = true;
            }
        }

        private void hopeTextBoxSearchLanguageModel_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void hopeButtonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != checkedListBoxLanguages.Items.Count; i++)
            {
                Item item = items.Find(find => find.model.name == (string)checkedListBoxLanguages.Items[i]);
                item.selected = true;
            }

            UpdateForm();
        }

        private void hopeButtonCanselAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != checkedListBoxLanguages.Items.Count; i++)
            {
                Item item = items.Find(find => find.model.name == (string)checkedListBoxLanguages.Items[i]);
                item.selected = false;
            }

            UpdateForm();
        }

        private void hopeButtonStartDownload_Click(object sender, EventArgs e)
        {
            List<Model> models = new List<Model>();
            foreach (Item item in items)
            {
                if (item.selected)
                {
                    Model model = Model.CanDownload.Find(find => find.name == item.model.name);
                    models.Add(model);
                }
            }

            if (models.Count != 0)
            {
                paneDownload.Location = new Point(0, 40);
                panelSelectDownload.Location = new Point(541, 40);

                _models = models;
                iModel = 0;

                imageButtonClose.Visible = false;
                Download(models[iModel], iModel);
            }
        }

        #endregion
        #region panelDownload

        private List<Model> _models;
        private int iModel = 0;

        private Thread _thread;
        private WebClient _client;

        private bool _endDownload;

        private void Download(Model model, int iModel)
        {
            _thread = new Thread(() =>
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    labelStatusDownloadedModels.Text = $"Загружено моделей: {iModel}/{_models.Count}";
                    lostProgressBarDownloadedModels.Progress = (int)((double)iModel / (double)_models.Count * 100);
                });

                Model.Load();
                formMain.BeginInvoke((MethodInvoker)delegate
                {
                    formMain.UpdateForm();
                });

                _client = new WebClient();
                _client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                _client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                _client.DownloadFileAsync(new Uri(model.url), $@"tessdata\{model.model}.traineddata");
            });
            _thread.Start();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double downloaded = (double)e.BytesReceived;
            double file = (double)e.TotalBytesToReceive;

            BeginInvoke((MethodInvoker)delegate
            {
                labelStatusModel.Text = $"Загрузка модели: {Math.Round(downloaded / 1048576, 2)}мб/{Math.Round(file / 1048576, 2)}мб";
                lostProgressBarDownloadModel.Progress = (int)(downloaded / file * 100);
            });
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Model.Load();
            formMain.BeginInvoke((MethodInvoker)delegate
            {
                formMain.UpdateForm();
            });

            if (e.Cancelled == false && iModel + 1 != _models.Count)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    labelStatusModel.Text = $"Загрузка модели";
                    lostProgressBarDownloadModel.Progress = 0;
                });

                iModel++;
                Download(_models[iModel], iModel);
            }
            else
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    if (e.Cancelled)
                    {
                        File.Delete($@"tessdata\{_models[iModel].model}.traineddata");

                        Model.Load();
                        formMain.BeginInvoke((MethodInvoker)delegate
                        {
                            formMain.UpdateForm();
                        });

                        hopeForm.Text = "Загрузка отменена";
                        Text = "Загрузка отменена";
                    }
                    else
                    {
                        hopeForm.Text = "Загрузка завершена";
                        Text = "Загрузка завершена";

                        labelStatusDownloadedModels.Text = $"Загружено моделей: {_models.Count}/{_models.Count}";
                        lostProgressBarDownloadedModels.Progress = 100;
                    }

                    hopeButtonClose.Text = "Закрыть";
                    hopeButtonClose.Refresh();
                    _endDownload = true;
                });
            }
        }

        private void hopeButtonClose_Click(object sender, EventArgs e)
        {
            if (_endDownload == false)
            {
                _client.CancelAsync();
                _thread.Abort();
            }
            else
            {
                Dispose();
            }
        }

        #endregion

        private void UpdateForm()
        {
            checkedListBoxLanguages.Items.Clear();

            foreach (Item item in items)
            {
                if (string.IsNullOrEmpty(hopeTextBoxSearchLanguageModel.Text) || item.model.name.IndexOf(hopeTextBoxSearchLanguageModel.Text) != -1)
                {
                    checkedListBoxLanguages.Items.Add(item.model.name, item.selected);
                }
            }

            if (checkedListBoxLanguages.CheckedItems.Count != 0)
            {
                hopeButtonStartDownload.Enabled = true;
            }
            else
            {
                hopeButtonStartDownload.Enabled = false;
            }
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
