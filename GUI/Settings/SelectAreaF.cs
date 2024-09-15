using System;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data.Setting;

namespace SceenshotTextRecognizer.GUI.Settings
{
    public partial class SelectAreaF : Form
    {
        public SelectAreaF()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            hopeCheckBoxSelectTypeClamping.Checked = Program.settings.selectArea.typeAreaSelection == TypeAreaSelection.Clamping;
            hopeCheckBoxFonTypeBlack.Checked = Program.settings.selectArea.typeFon == TypeFon.Black;

            FormUpdate();
        }

        #region Top

        private void imageButtonFormMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Select Type

        private void hopeCheckBoxTypeClamping_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxSelectTypeClamping.Checked)
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = false;
                Program.settings.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }
            else
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = true;
                Program.settings.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }

            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxTypePKMLKM_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxSelectTypePKMLKM.Checked)
            {
                hopeCheckBoxSelectTypeClamping.Checked = false;
                Program.settings.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }
            else
            {
                hopeCheckBoxSelectTypeClamping.Checked = true;
                Program.settings.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }

            Data.Settings.Save(Program.settings);
        }

        #endregion

        #region Fon Settings

        private void hopeCheckBoxFonTypeBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeBlack.Checked)
            {
                hopeCheckBoxFonTypeNone.Checked = false;
                Program.settings.selectArea.typeFon = TypeFon.Black;
            }
            else
            {
                hopeCheckBoxFonTypeNone.Checked = true;
                Program.settings.selectArea.typeFon = TypeFon.None;
            }

            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxFonTypeNone_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeNone.Checked)
            {
                hopeCheckBoxFonTypeBlack.Checked = false;
                Program.settings.selectArea.typeFon = TypeFon.None;
            }
            else
            {
                hopeCheckBoxFonTypeBlack.Checked = true;
                Program.settings.selectArea.typeFon = TypeFon.Black;
            }

            Data.Settings.Save(Program.settings);
        }

        #endregion

        #region Bind

        private bool _bindClose;
        private bool _bindEnter;

        private void hopeButtonBindClose_Click(object sender, EventArgs e)
        {
            if (_bindEnter == true)
            {
                _bindEnter = false;
                hopeButtonBindEnter.Enabled = true;
            }

            _bindClose = true;
            hopeButtonBindClose.Enabled = false;
        }

        private void hopeButtonBindEnter_Click(object sender, EventArgs e)
        {
            if (_bindClose == true)
            {
                _bindClose = false;
                hopeButtonBindClose.Enabled = true;
            }

            _bindEnter = true;
            hopeButtonBindEnter.Enabled = false;
        }

        #endregion

        public void FormKeyDown(Keys keys)
        {
            if (keys == Program.settings.bind)
            {
                hopeButtonBindClose.Enabled = true;
                hopeButtonBindEnter.Enabled = true;

                _bindClose = false;
                _bindEnter = false;
            }

            if (_bindClose)
            {
                hopeButtonBindClose.Enabled = true;

                if (Program.settings.selectArea.enterArea == keys || Program.settings.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hopeButtonBindClose.Refresh();
                Program.settings.selectArea.closeSelectArea = keys;
                Data.Settings.Save(Program.settings);

                FormUpdate();
            }
            else if (_bindEnter)
            {
                hopeButtonBindEnter.Enabled = true;

                if (Program.settings.selectArea.closeSelectArea == keys || Program.settings.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hopeButtonBindEnter.Refresh();
                Program.settings.selectArea.enterArea = keys;
                Data.Settings.Save(Program.settings);

                FormUpdate();
            }
        }

        private void FormUpdate()
        {
            hopeButtonBindClose.Text = "Отмена bind: " + Program.settings.selectArea.closeSelectArea;
            hopeButtonBindEnter.Text = "Подтвердить bind: " + Program.settings.selectArea.enterArea;
        }
    }
}
