using SceenshotTextRecognizer.Data;
using SceenshotTextRecognizer.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    public partial class ImageTextResult : Form
    {
        public ImageTextResult(string text)
        {
            InitializeComponent();
            CustomForm.RoundOffTheEdges(this);

            SetText(text);

            imageButtonFormMin.ImageNoHovered = Resources.min;
            imageButtonFormMin.ImageOnHovered = Resources.min2;

            imageButtonClose.ImageNoHovered = Resources.close;
            imageButtonClose.ImageOnHovered = Resources.close2;
        }

        private void SetText(string text)
        {
            List<string> strings = text.Split('\n').ToList();

            for(int i = 0, remove = 0; i != strings.Count; i++)
            {
                if (Main.main.scanResult.deleteEmptyLines)
                {
                    if (strings[i - remove].Any(c => char.IsWhiteSpace(c) || c == '\n') == false)
                    {
                        strings.RemoveAt(i - remove);
                        remove++;
                    }
                }

                if (Main.main.scanResult.deleteLinesWithoutLetters)
                {
                    if (strings[i - remove].Any(c => char.IsLetterOrDigit(c)) == false)
                    {
                        strings.RemoveAt(i - remove);
                        remove++;
                    }
                }

                if (Main.main.scanResult.removeExtraSpaces)
                {
                    string trimmed = strings[i - remove].Trim();

                    string pattern = "\\s+";
                    string replacement = " ";
                    Regex regex = new Regex(pattern);

                    strings[i - remove] = regex.Replace(trimmed, replacement);
                }
            }

            dungeonRichTextBoxText.Text = string.Join("\n",  strings);
        }

        private void imageButtonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void imageButtonFormMin_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
