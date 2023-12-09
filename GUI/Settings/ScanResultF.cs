using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.Properties;
using System;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI.Settings
{
    public partial class ScanResultF : Form
    {
        public ScanResultF()
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;

            hopeCheckBoxRemoveExtraSpaces.Checked = Main.main.scanResult.removeExtraSpaces;
            hopeCheckBoxDeleteEmptyLines.Checked = Main.main.scanResult.deleteEmptyLines;
            hopeCheckBoxDeleteLinesWithoutLetters.Checked = Main.main.scanResult.deleteLinesWithoutLetters;
        }

        private void imageButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imageButtonFormMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void hopeCheckBoxRemoveExtraSpaces_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.scanResult.removeExtraSpaces = hopeCheckBoxRemoveExtraSpaces.Checked;
            Main.Save();
        }

        private void hopeCheckBoxDeleteEmptyLines_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.scanResult.deleteEmptyLines = hopeCheckBoxDeleteEmptyLines.Checked;
            Main.Save();
        }

        private void hopeCheckBoxDeleteLinesWithoutLetters_CheckedChanged(object sender, EventArgs e)
        {
            Main.main.scanResult.deleteLinesWithoutLetters = hopeCheckBoxDeleteLinesWithoutLetters.Checked;
            Main.Save();
        }
    }
}
