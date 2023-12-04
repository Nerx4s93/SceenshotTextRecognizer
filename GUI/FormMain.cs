using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Utilities;
using System.Linq;
using SceenshotTextRecognizer.Data;
using ReaLTaiizor.Child.Crown;
using System.IO;
using SceenshotTextRecognizer.GUI.MessageBoxes;
using SceenshotTextRecognizer.Properties;
using Microsoft.Win32;

namespace SceenshotTextRecognizer.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);
            UpdateForm();

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;
        }

        private Server _server;

        private Keys _bindKey;
        private bool _waitKeyBind;

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
            if (_waitKeyBind)
            {
                hopeButtonBind.Text = "Bind: " + e.KeyData.ToString();
                _bindKey = e.KeyData;
                hopeButtonBind.Enabled = true;
                _waitKeyBind = false;
            }
            else if (e.KeyData == _bindKey && !ProgramData.SelectSone)
            {
                ProgramData.SelectSone = true;
                Fon fon = new Fon();
                fon.Show();
            }
        }

        #endregion
        #region Top

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imageButtonFormMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion
        #region Settings

        private void hopeButtonBind_Click(object sender, EventArgs e)
        {
            _waitKeyBind = true;
            hopeButtonBind.Enabled = false;
        }

        private void hopeCheckBoxShowOnOtherForms_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = hopeCheckBoxShowOnOtherForms.Checked;
        }

        private void hopeCheckBoxAddToAutorun_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxAddToAutorun.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("SceenshotTextRecognizer", Application.ExecutablePath);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("SceenshotTextRecognizer", false);
            }
        }

        #endregion
        #region Language packs

        private void crownListViewLanguagePacks_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (crownListViewLanguagePacks.SelectedIndices.Count > 0)
            {
                hopeButtonDeleteLanguageModel.Visible = true;
            }
            else
            {
                hopeButtonDeleteLanguageModel.Visible = false;
            }
        }

        private void hopeTextBoxSearchLanguageModel_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void hopeButtonDeleteLanguageModel_Click(object sender, EventArgs e)
        {
            Model model = Model.Downloaded.Find(item => item.name == crownListViewLanguagePacks.Items[crownListViewLanguagePacks.SelectedIndices[0]].Text);

            if (MessageBox.Show($"Вы дочно хотите удалить языковой пакет \"{model.name}\"?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete($@"tessdata\{model.model}.traineddata");

                Model.CanDownload.Add(model);
                Model.Downloaded.Remove(model);

                UpdateForm();
            }
        }

        private void hopeButtonDownloadLanguageModels_Click(object sender, EventArgs e)
        {
            DownloadModel downloadMode = new DownloadModel();
            downloadMode.ShowDialog();

            Model.Load();
            UpdateForm();
        }

        #endregion
        #region Combination of language packs

        private void crownListViewCombinationOfLanguagePacks_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (crownListViewCombinationOfLanguagePacks.SelectedIndices.Count == 0)
            {
                hopeButtonDeleteCombination.Visible = false;
                hopeButtonEditCombination.Visible = false;
            }
            else
            {
                hopeButtonDeleteCombination.Visible = true;
                hopeButtonEditCombination.Visible = true;
            }
        }

        private void hopeButtonDeleteCombination_Click(object sender, EventArgs e)
        {
            var itemDeleted = CombinationLanguagePacks.combinationLanguagePacks.Find(
               item => item.name == crownListViewCombinationOfLanguagePacks.Items[crownListViewCombinationOfLanguagePacks.SelectedIndices[0]].Text);

            CombinationLanguagePacks.combinationLanguagePacks.Remove(itemDeleted);
            CombinationLanguagePacks.Save();

            UpdateForm();
        }

        private void crownListViewCombinationOfLanguagePacks_DoubleClick(object sender, EventArgs e)
        {
            if (crownListViewCombinationOfLanguagePacks.SelectedIndices.Count == 0)
            {
                return;
            }

            Edit();
        }

        private void hopeButtonEditCombination_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void hopeButtonNewCombination_Click(object sender, EventArgs e)
        {
            EditCombinationLanguagePack editCombinationLanguagePack = new EditCombinationLanguagePack();
            editCombinationLanguagePack.ShowDialog();

            UpdateForm();
        }

        private void Edit()
        {
            var combinationLanguagePacks = CombinationLanguagePacks.combinationLanguagePacks.Find(
                item => item.name == crownListViewCombinationOfLanguagePacks.Items[crownListViewCombinationOfLanguagePacks.SelectedIndices[0]].Text);

            EditCombinationLanguagePack editCombinationLanguagePacks = new EditCombinationLanguagePack(combinationLanguagePacks);
            editCombinationLanguagePacks.ShowDialog();

            UpdateForm();
        }

        #endregion

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = true;
            }

            _server?.Dispose();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hopeCheckBoxWorkInFon.Checked)
            {
                e.Cancel = true;

                _server = new Server(this);
                _server.StartServer();

                Hide();
            }
            else Application.Exit();
        }

        public void UpdateForm()
        {
            crownListViewLanguagePacks.Items.Clear();
            crownListViewCombinationOfLanguagePacks.Items.Clear();

            for (int i = 0; i != Model.Downloaded.Count; i++)
            {
                if (string.IsNullOrEmpty(hopeTextBoxSearchLanguageModel.Text) || Model.Downloaded[i].name.IndexOf(hopeTextBoxSearchLanguageModel.Text) == 0)
                {
                    var crownListItem = new CrownListItem(Model.Downloaded[i].name);
                    crownListViewLanguagePacks.Items.Add(crownListItem);
                }
            }

            for (int i = 0; i != CombinationLanguagePacks.combinationLanguagePacks.Count; i++)
            {
                if (string.IsNullOrEmpty(hopeTextBoxSearchCombinationOfLanguagePacks.Text) || Model.Downloaded[i].name.IndexOf(hopeTextBoxSearchCombinationOfLanguagePacks.Text) == 0)
                {
                    var crownListItem = new CrownListItem(CombinationLanguagePacks.combinationLanguagePacks[i].name);
                    crownListViewCombinationOfLanguagePacks.Items.Add(crownListItem);
                }
            }
        }
    }
}