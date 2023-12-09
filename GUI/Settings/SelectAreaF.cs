using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.Properties;
using System.Windows.Forms;
using System;
using SceenshotTextRecognizer.Data.Setting;

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

            if (Main.main.selectArea.typeAreaSelection == TypeAreaSelection.Clamping)
            {
                hopeCheckBoxSelectTypeClamping.Checked = true;
            }
            else
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = true;
            }

            if (Main.main.selectArea.typeFon == TypeFon.Black)
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
                Main.main.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }
            else
            {
                hopeCheckBoxSelectTypePKMLKM.Checked = true;
                Main.main.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }

            Main.Save();
        }

        private void hopeCheckBoxTypePKMLKM_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxSelectTypePKMLKM.Checked)
            {
                hopeCheckBoxSelectTypeClamping.Checked = false;
                Main.main.selectArea.typeAreaSelection = TypeAreaSelection.PKM_LKM;
            }
            else
            {
                hopeCheckBoxSelectTypeClamping.Checked = true;
                Main.main.selectArea.typeAreaSelection = TypeAreaSelection.Clamping;
            }

            Main.Save();
        }

        #endregion

        #region Fon Settings

        private void hopeCheckBoxFonTypeBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeBlack.Checked)
            {
                hopeCheckBoxFonTypeNone.Checked = false;
                Main.main.selectArea.typeFon = TypeFon.Black;
            }
            else
            {
                hopeCheckBoxFonTypeNone.Checked = true;
                Main.main.selectArea.typeFon = TypeFon.None;
            }

            Main.Save();
        }

        private void hopeCheckBoxFonTypeNone_CheckedChanged(object sender, EventArgs e)
        {
            if (hopeCheckBoxFonTypeNone.Checked)
            {
                hopeCheckBoxFonTypeBlack.Checked = false;
                Main.main.selectArea.typeFon = TypeFon.None;
            }
            else
            {
                hopeCheckBoxFonTypeBlack.Checked = true;
                Main.main.selectArea.typeFon = TypeFon.Black;
            }

            Main.Save();
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
            if (_bindClose)
            {
                hopeButtonBindClose.Enabled = true;

                if (Main.main.selectArea.enterArea == keys || Main.main.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Main.main.selectArea.closeSelectArea = keys;
                Main.Save();

                FormUpdate();
            }
            else if (_bindEnter)
            {
                hopeButtonBindEnter.Enabled = true;

                if (Main.main.selectArea.closeSelectArea == keys || Main.main.bind == keys)
                {
                    MessageBox.Show("Нельзя ставить одинаковые бинды на разные функции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Main.main.selectArea.enterArea = keys;
                Main.Save();

                FormUpdate();
            }
        }

        private void FormUpdate()
        {
            hopeButtonBindClose.Text = "Отмена bind: " + Main.main.selectArea.closeSelectArea;
            hopeButtonBindEnter.Text = "Подтвердить bind: " + Main.main.selectArea.enterArea;
        }
    }
}
