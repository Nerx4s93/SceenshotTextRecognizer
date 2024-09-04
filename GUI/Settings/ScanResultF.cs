using System;
using System.Windows.Forms;

using SceenshotTextRecognizer.Properties;

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

            hopeCheckBoxRemoveExtraSpaces.Checked = Program.settings.scanResult.removeExtraSpaces;
            hopeCheckBoxDeleteEmptyLines.Checked = Program.settings.scanResult.deleteEmptyLines;
            hopeCheckBoxDeleteLinesWithoutLetters.Checked = Program.settings.scanResult.deleteLinesWithoutLetters;
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
            Program.settings.scanResult.removeExtraSpaces = hopeCheckBoxRemoveExtraSpaces.Checked;
            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxDeleteEmptyLines_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.scanResult.deleteEmptyLines = hopeCheckBoxDeleteEmptyLines.Checked;
            Data.Settings.Save(Program.settings);
        }

        private void hopeCheckBoxDeleteLinesWithoutLetters_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.scanResult.deleteLinesWithoutLetters = hopeCheckBoxDeleteLinesWithoutLetters.Checked;
            Data.Settings.Save(Program.settings);
        }
    }
}
