using System.Windows.Forms;
using System;
using Utilities;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using SceenshotTextRecognizer.GUI.MessageBoxes;
using SceenshotTextRecognizer.Data;
using System.Runtime.InteropServices;

namespace SceenshotTextRecognizer.GUI
{
    // TODO: Функция автозагрузки
    public partial class FormMain : Form
    {
        #region Dll

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public FormMain()
        {
            InitializeComponent();
            UpdateForm();
        }

        private Server _server;

        // Кнопка активации выбора зоны обработки
        private Keys _bindKey;
        // Изменина ли кнопка активации выбора зоны обрабоки сейчас
        private bool _nawBind = false;

        #region GlobalKeyboardHook

        private readonly GlobalKeyboardHook _globalKeyboardHook = new GlobalKeyboardHook();

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<Keys> keys = Enum.GetValues(typeof(Keys)).Cast<Keys>().ToList<Keys>();
            _globalKeyboardHook.HookedKeys = keys;

            _globalKeyboardHook.KeyUp += new KeyEventHandler(globalKeyboardHook_KeyUp);
        }

        private void globalKeyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == _bindKey)
            {
                if (_nawBind == true)
                {
                    _nawBind = false;
                    return;
                }

                if (ProgramData.SelectSone == false)
                {
                    ProgramData.SelectSone = true;
                    Fon fon = new Fon();
                    fon.Show();
                }
            }
        }

        #endregion
        #region Settings

        private void textBox_Bind_KeyDown(object sender, KeyEventArgs e)
        {
            _bindKey = e.KeyData;
            _nawBind = true;
            textBox_Bind.Text = e.KeyData.ToString();
        }

        private void checkBoxShowOnOtherForms_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxShowOnOtherForms.Checked;
        }

        #endregion
        #region Language packs

        private void listView_Delete_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Delete.SelectedItems.Count == 0)
                return;

            Model model = Model.Downloaded.Find(item => item.name == listView_Delete.SelectedItems[0].Text);
            if (MessageBox.Show($"Вы дочно хотите удалить языковой пакет \"{model.name}\"?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete($@"tessdata\{model.model}.traineddata");

                Model.CanDownload.Add(model);
                Model.Downloaded.Remove(model);

                UpdateForm();
            }
        }

        private void listView_Download_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Download.SelectedItems.Count == 0)
                return;

            Model model = Model.CanDownload.Find(item => item.name == listView_Download.SelectedItems[0].Text);
            DownloadModel downloadModel = new DownloadModel(model);
            downloadModel.ShowDialog();

            if (downloadModel._cansel == false)
            {
                Model.CanDownload.Remove(model);
                Model.Downloaded.Add(model);
            }

            UpdateForm();
        }

        #endregion
        #region Combination of language packs

        private void listViewCombinationLanguagePacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCombinationLanguagePacks.SelectedItems.Count == 0)
            {
                buttonDeleteCombination.Visible = false;
                buttonEditCombination.Visible = false;
            }
            else if (listViewCombinationLanguagePacks.SelectedItems.Count == 1)
            {
                buttonDeleteCombination.Visible = true;
                buttonEditCombination.Visible = true;
            }
            else
            {
                buttonDeleteCombination.Visible = true;
                buttonEditCombination.Visible = false;
            }
        }

        private void listViewCombinationLanguagePacks_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCombinationLanguagePacks.SelectedItems.Count < 1)
                return;

            EditCombinationLanguagePack combinationLanguagePacks = new EditCombinationLanguagePack(
                CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == listViewCombinationLanguagePacks.SelectedItems[0].Text));
            combinationLanguagePacks.ShowDialog();

            UpdateForm();
        }

        private void buttonEditCombination_Click(object sender, EventArgs e)
        {
            EditCombinationLanguagePack combinationLanguagePacks = new EditCombinationLanguagePack(
                CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == listViewCombinationLanguagePacks.SelectedItems[0].Text));
            combinationLanguagePacks.ShowDialog();

            UpdateForm();
        }

        private void buttonNewCombination_Click(object sender, EventArgs e)
        {
            EditCombinationLanguagePack editCombinationLanguagePack = new EditCombinationLanguagePack();
            editCombinationLanguagePack.ShowDialog();

            UpdateForm();
        }

        private void buttonDeleteCombination_Click(object sender, EventArgs e)
        {
            CombinationLanguagePacks.combinationLanguagePacks.Remove(
                CombinationLanguagePacks.combinationLanguagePacks.Find(item => item.name == listViewCombinationLanguagePacks.SelectedItems[0].Text));
            CombinationLanguagePacks.Save();

            UpdateForm();
        }

        #endregion
        #region Top

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (checkBoxWorkInFon.Checked == true)
            {
                _server = new Server(this);
                _server.StartServer();

                Hide();
            }
            else Close();
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            if (_server != null)
                _server.Dispose();
        }

        private void buttonFormMin_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        public void UpdateForm()
        {
            listView_Delete.Clear();
            listView_Download.Clear();
            listViewCombinationLanguagePacks.Clear();

            for (int i = 0; i != Model.Downloaded.Count; i++)
                listView_Delete.Items.Add(Model.Downloaded[i].name);

            for (int i = 0; i != Model.CanDownload.Count; i++)
                listView_Download.Items.Add(Model.CanDownload[i].name);

            for (int i = 0; i != CombinationLanguagePacks.combinationLanguagePacks.Count; i++)
                listViewCombinationLanguagePacks.Items.Add(CombinationLanguagePacks.combinationLanguagePacks[i].name);
        }
    }
}
