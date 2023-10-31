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

        // Обрабатываемое изображение
        private Bitmap _bitmap;

        // Конекст для поиска языковой модели/комбинации
        private string _find;

        // Выбраная модель/комбинация для обработки изображения
        private string _tag;

        // Идёт ли загрузка
        private bool _loading;

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            // Изменить критерий поиска
            _find = textBoxFind.Text;
            FormUpdate();
        }

        private void listViewSelectModels_DoubleClick(object sender, EventArgs e)
        {
            //Если элемент не выбран, то завершить метод
            if (listViewSelectModels.SelectedItems.Count < 1)
                return;

            //Выбать переменную
            textBoxSelected.Text = listViewSelectModels.SelectedItems[0].Text;
            _tag = (string)listViewSelectModels.SelectedItems[0].Tag;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            //Начать загрузку
            _loading = true;
            buttonScan.Enabled = false;
            buttonScan.Text = "Загрузка";

            //Обработка в новом потоке
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

                //Показать Результат обработки
                ImageTextResult imageTextResult = new ImageTextResult(res.GetText());
                imageTextResult.ShowDialog();
            })
            {
                IsBackground = true
            };
            //Запуск потока
            thread.Start();
        }

        private void ScanSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Отмена закрытия, если идёт загрузка
            if (_loading)
                e.Cancel = true;
        }

        public void FormUpdate()
        {
            //Удалить все элементы ListView
            listViewSelectModels.Clear();

            //Добавить в лист языковые модели
            foreach (Model model in Model.Downloaded)
            {
                ListViewItem listViewItem = new ListViewItem(model.model);
                listViewItem.Tag = "Model";

                if (string.IsNullOrEmpty(_find))
                    listViewSelectModels.Items.Add(listViewItem);
                else if (model.model.IndexOf(_find) != -1)
                    listViewSelectModels.Items.Add(listViewItem);
            }

            //Добавить в лист языковые комбинации
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
