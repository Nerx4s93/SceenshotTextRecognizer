﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.GUI.MessageBoxes;
using SceenshotTextRecognizer.GUI.Settings;
using SceenshotTextRecognizer.Utils;

using Microsoft.Win32;
using ReaLTaiizor.Child.Crown;

namespace SceenshotTextRecognizer.GUI
{
    public partial class FormMain : BaseForm
    {
        public FormMain()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            UpdateForm();

            hopeCheckBoxShowOnOtherWindows.Checked = Program.settings.showOnOtherWindows;
            hopeCheckBoxWorkInFon.Checked = Program.settings.workInFon;
        }

        private Server _server;

        private bool _waitKeyBind;

        private Fon _fon;
        private SelectAreaF _selectAreaF;
        private ScanResultF _scanResultF;
        private DownloadModel _downloadMode;
        private EditCombinationLanguagePack _editCombinationLanguagePack;

        #region GlobalKeyboardHook

        private readonly GlobalKeyboardHook _globalKeyboardHook = new GlobalKeyboardHook();

        private void FormMain_Load(object sender, EventArgs e)
        {
            var keys = Enum.GetValues(typeof(Keys)).Cast<Keys>().ToList<Keys>();
            _globalKeyboardHook.HookedKeys = keys;

            _globalKeyboardHook.KeyUp += new KeyEventHandler(globalKeyboardHook_KeyUp);
        }

        private void globalKeyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (_waitKeyBind)
            {
                hopeButtonBind.Text = "Bind: " + e.KeyData.ToString();

                if (Program.settings.selectArea.closeSelectArea == e.KeyData || Program.settings.selectArea.enterArea == e.KeyData)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.settings.bind = e.KeyData;
                Data.Settings.Save(Program.settings);

                hopeButtonBind.Enabled = true;
                _waitKeyBind = false;
            }
            else if (e.KeyData == Program.settings.bind && !ProgramData.SelectSone)
            {
                _fon = new Fon();
                _fon.Show();
                ProgramData.SelectSone = true;
            }

            if (_fon != null && _fon.Disposing == false)
            {
                _fon.FormKeyDown(e.KeyData);
            }

            if (_selectAreaF != null && _selectAreaF.Disposing == false)
            {
                _selectAreaF.FormKeyDown(e.KeyData);
            }
        }

        #endregion
        #region Settings

        private void hopeButtonBind_Click(object sender, EventArgs e)
        {
            _waitKeyBind = true;
            hopeButtonBind.Enabled = false;
        }

        private void hopeButtonSettingsSelectArea_Click(object sender, EventArgs e)
        {
            if (_selectAreaF == null || _selectAreaF.IsDisposed)
            {
                _selectAreaF = new SelectAreaF();
                _selectAreaF.Show();
            }
        }

        private void hopeButtonSettingsScanResult_Click(object sender, EventArgs e)
        {
            if (_scanResultF == null || _scanResultF.IsDisposed)
            {
                _scanResultF = new ScanResultF();
                _scanResultF.Show();
            }
        }

        private void hopeCheckBoxShowOnOtherForms_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = hopeCheckBoxShowOnOtherWindows.Checked;

            Program.settings.showOnOtherWindows = hopeCheckBoxShowOnOtherWindows.Checked;
            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxWorkInFon_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.workInFon = hopeCheckBoxWorkInFon.Checked;
            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxAddToAutorun_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxAddToAutorun.Checked)
            {
                var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("SceenshotTextRecognizer", Application.ExecutablePath);
            }
            else
            {
                var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("SceenshotTextRecognizer", false);
            }

            Program.settings.autoUpload = hopeCheckBoxWorkInFon.Checked;
            Data.Settings.Save(Program.settings);
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
            var model = Model.Downloaded.Find(item => item.Name == crownListViewLanguagePacks.Items[crownListViewLanguagePacks.SelectedIndices[0]].Text);

            if (MessageBox.Show($"Вы дочно хотите удалить языковой пакет \"{model.Name}\"?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete($@"tessdata\{model.Code}.traineddata");

                Model.CanDownload.Add(model);
                Model.Downloaded.Remove(model);

                UpdateForm();
            }
        }

        private void hopeButtonDownloadLanguageModels_Click(object sender, EventArgs e)
        {
            if (_downloadMode == null || _downloadMode.IsDisposed)
            {
                _downloadMode = new DownloadModel(this);
                _downloadMode.Show();
            }
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
            if (_editCombinationLanguagePack == null || _editCombinationLanguagePack.IsDisposed)
            {
                _editCombinationLanguagePack = new EditCombinationLanguagePack(this);
                _editCombinationLanguagePack.Show();
            }
        }

        private void Edit()
        {
            var combinationLanguagePacks = CombinationLanguagePacks.combinationLanguagePacks.Find(
                item => item.name == crownListViewCombinationOfLanguagePacks.Items[crownListViewCombinationOfLanguagePacks.SelectedIndices[0]].Text);

            if (_editCombinationLanguagePack == null || _editCombinationLanguagePack.IsDisposed)
            {
                _editCombinationLanguagePack = new EditCombinationLanguagePack(combinationLanguagePacks, this);
                _editCombinationLanguagePack.Show();
            }
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
            if (Program.settings.workInFon)
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
            hopeButtonBind.Text = "Bind: " + Program.settings.bind;

            crownListViewLanguagePacks.Items.Clear();
            crownListViewCombinationOfLanguagePacks.Items.Clear();

            for (int i = 0; i != Model.Downloaded.Count; i++)
            {
                if (string.IsNullOrEmpty(hopeTextBoxSearchLanguageModel.Text) || Model.Downloaded[i].Name.IndexOf(hopeTextBoxSearchLanguageModel.Text) == 0)
                {
                    var crownListItem = new CrownListItem(Model.Downloaded[i].Name);
                    crownListViewLanguagePacks.Items.Add(crownListItem);
                }
            }

            for (int i = 0; i != CombinationLanguagePacks.combinationLanguagePacks.Count; i++)
            {
                if (string.IsNullOrEmpty(hopeTextBoxSearchCombinationOfLanguagePacks.Text) || Model.Downloaded[i].Name.IndexOf(hopeTextBoxSearchCombinationOfLanguagePacks.Text) == 0)
                {
                    var crownListItem = new CrownListItem(CombinationLanguagePacks.combinationLanguagePacks[i].name);
                    crownListViewCombinationOfLanguagePacks.Items.Add(crownListItem);
                }
            }
        }
    }
}