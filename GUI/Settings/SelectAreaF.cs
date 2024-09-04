using System;
using System.Windows.Forms;

using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.Data.Setting;
using SceenshotTextRecognizer.Properties;

namespace SceenshotTextRecognizer.GUI.Settings
{
    public partial class SelectAreaF : Form
    {
        public SelectAreaF()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;

            if (Program.config.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                hopeCheckBoxSelectTypeClamping.Checked = true;
            }
            else
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = true;
            }

            if (Program.config.selectArea.typeFon == TypeFon.Black)
            {
                hopeCheckBoxFonTypeBlack.Checked = true;
            }
            else
            {
                hopeCheckBoxFonTypeNone.Checked = true;
            }

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
                Program.config.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }
            else
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = true;
                Program.config.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }

            Config.Save(Program.config);
        }

        private void hopeCheckBoxTypePKMLKM_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxSelectTypePKMLKM.Checked)
            {
                hopeCheckBoxSelectTypeClamping.Checked = false;
                Program.config.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }
            else
            {
                hopeCheckBoxSelectTypeClamping.Checked = true;
                Program.config.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }

            Config.Save(Program.config);
        }

        #endregion

        #region Fon Settings

        private void hopeCheckBoxFonTypeBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeBlack.Checked)
            {
                hopeCheckBoxFonTypeNone.Checked = false;
                Program.config.selectArea.typeFon = TypeFon.Black;
            }
            else
            {
                hopeCheckBoxFonTypeNone.Checked = true;
                Program.config.selectArea.typeFon = TypeFon.None;
            }

            Config.Save(Program.config);
        }

        private void hopeCheckBoxFonTypeNone_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeNone.Checked)
            {
                hopeCheckBoxFonTypeBlack.Checked = false;
                Program.config.selectArea.typeFon = TypeFon.None;
            }
            else
            {
                hopeCheckBoxFonTypeBlack.Checked = true;
                Program.config.selectArea.typeFon = TypeFon.Black;
            }

            Config.Save(Program.config);
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
            if (keys == Program.config.bind)
            {
                hopeButtonBindClose.Enabled = true;
                hopeButtonBindEnter.Enabled = true;

                _bindClose = false;
                _bindEnter = false;
            }

            if (_bindClose)
            {
                hopeButtonBindClose.Enabled = true;

                if (Program.config.selectArea.enterArea == keys || Program.config.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hopeButtonBindClose.Refresh();
                Program.config.selectArea.closeSelectArea = keys;
                Config.Save(Program.config);

                FormUpdate();
            }
            else if (_bindEnter)
            {
                hopeButtonBindEnter.Enabled = true;

                if (Program.config.selectArea.closeSelectArea == keys || Program.config.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hopeButtonBindEnter.Refresh();
                Program.config.selectArea.enterArea = keys;
                Config.Save(Program.config);

                FormUpdate();
            }
        }

        private void FormUpdate()
        {
            hopeButtonBindClose.Text = "Отмена bind: " + Program.config.selectArea.closeSelectArea;
            hopeButtonBindEnter.Text = "Подтвердить bind: " + Program.config.selectArea.enterArea;
        }
    }
}
