using System.Net;
using System;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using SceenshotTextRecognizer.Data;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class DownloadModel : Form
    {
        public DownloadModel(Model model)
        {
            InitializeComponent();

            Text = $"Загрузка языковой модели \"{model.name}\"";
            this._model = model;

            StartDownload();
        }

        private Model _model;

        private Thread _thread;
        private WebClient _client;

        private bool _endDownload;

        public bool _cansel { get; private set; }

        private void DownloadModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_endDownload)
                e.Cancel = true;
        }

        private void StartDownload()
        {
            _thread = new Thread(() =>
            {
                _client = new WebClient();
                _client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                _client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                _client.DownloadFileAsync(new Uri(_model.url), $@"tessdata\{_model.model}.traineddata");
            });
            _thread.Start();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                labelStatus.Text = "Загружено " + e.BytesReceived + " из " + e.TotalBytesToReceive;
                progressBarStatus.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                if (e.Cancelled)
                {
                    labelStatus.Text = "Загрузка отменена";
                    File.Delete($@"tessdata\{_model.model}.traineddata");
                }
                else labelStatus.Text = "Загрузка завершена";

                button_Cansel.Text = "Закрыть";
                _endDownload = true;
            });
        }

        private void button_Cansel_Click(object sender, EventArgs e)
        {
            if (_endDownload == false)
            {
                _cansel = true;
                _client.CancelAsync();
                _thread.Abort();
            }
            else
                Dispose();
        }
    }
}
