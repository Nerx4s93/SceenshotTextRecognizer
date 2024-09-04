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

            hopeCheckBoxRemoveExtraSpaces.Checked = Config.config.scanResult.removeExtraSpaces;
            hopeCheckBoxDeleteEmptyLines.Checked = Config.config.scanResult.deleteEmptyLines;
            hopeCheckBoxDeleteLinesWithoutLetters.Checked = Config.config.scanResult.deleteLinesWithoutLetters;
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
            Config.config.scanResult.removeExtraSpaces = hopeCheckBoxRemoveExtraSpaces.Checked;
            Config.Save();
        }

        private void hopeCheckBoxDeleteEmptyLines_CheckedChanged(object sender, EventArgs e)
        {
            Config.config.scanResult.deleteEmptyLines = hopeCheckBoxDeleteEmptyLines.Checked;
            Config.Save();
        }

        private void hopeCheckBoxDeleteLinesWithoutLetters_CheckedChanged(object sender, EventArgs e)
        {
            Config.config.scanResult.deleteLinesWithoutLetters = hopeCheckBoxDeleteLinesWithoutLetters.Checked;
            Config.Save();
        }
    }
}
