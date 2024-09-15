namespace SceenshotTextRecognizer.GUI.Settings
{
    partial class ScanResultF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.imageButtonFormMin = new SceenshotTextRecognizer.UI.ImageButton();
            this.imageButtonClose = new SceenshotTextRecognizer.UI.ImageButton();
            this.hopeCheckBoxRemoveExtraSpaces = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeCheckBoxDeleteEmptyLines = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeCheckBoxDeleteLinesWithoutLetters = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBox = false;
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Controls.Add(this.imageButtonFormMin);
            this.hopeForm1.Controls.Add(this.imageButtonClose);
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = null;
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(385, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Настройки результата сканирования";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonFormMin
            // 
            this.imageButtonFormMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonFormMin.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.min;
            this.imageButtonFormMin.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.min2;
            this.imageButtonFormMin.Location = new System.Drawing.Point(325, 8);
            this.imageButtonFormMin.Name = "imageButtonFormMin";
            this.imageButtonFormMin.Size = new System.Drawing.Size(24, 24);
            this.imageButtonFormMin.TabIndex = 8;
            this.imageButtonFormMin.Text = "imageButton1";
            this.imageButtonFormMin.UseVisualStyleBackColor = true;
            this.imageButtonFormMin.Click += new System.EventHandler(this.imageButtonFormMin_Click);
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.imageButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.imageButtonClose.Location = new System.Drawing.Point(349, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 7;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            this.imageButtonClose.Click += new System.EventHandler(this.imageButtonClose_Click);
            // 
            // hopeCheckBoxRemoveExtraSpaces
            // 
            this.hopeCheckBoxRemoveExtraSpaces.AutoSize = true;
            this.hopeCheckBoxRemoveExtraSpaces.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxRemoveExtraSpaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxRemoveExtraSpaces.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxRemoveExtraSpaces.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxRemoveExtraSpaces.Enable = true;
            this.hopeCheckBoxRemoveExtraSpaces.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxRemoveExtraSpaces.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxRemoveExtraSpaces.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxRemoveExtraSpaces.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hopeCheckBoxRemoveExtraSpaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxRemoveExtraSpaces.Location = new System.Drawing.Point(12, 46);
            this.hopeCheckBoxRemoveExtraSpaces.Name = "hopeCheckBoxRemoveExtraSpaces";
            this.hopeCheckBoxRemoveExtraSpaces.Size = new System.Drawing.Size(261, 20);
            this.hopeCheckBoxRemoveExtraSpaces.TabIndex = 1;
            this.hopeCheckBoxRemoveExtraSpaces.Text = "Удалять лишние пробелы";
            this.hopeCheckBoxRemoveExtraSpaces.UseVisualStyleBackColor = true;
            this.hopeCheckBoxRemoveExtraSpaces.CheckedChanged += new System.EventHandler(this.hopeCheckBoxRemoveExtraSpaces_CheckedChanged);
            // 
            // hopeCheckBoxDeleteEmptyLines
            // 
            this.hopeCheckBoxDeleteEmptyLines.AutoSize = true;
            this.hopeCheckBoxDeleteEmptyLines.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxDeleteEmptyLines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxDeleteEmptyLines.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxDeleteEmptyLines.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxDeleteEmptyLines.Enable = true;
            this.hopeCheckBoxDeleteEmptyLines.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxDeleteEmptyLines.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxDeleteEmptyLines.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxDeleteEmptyLines.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hopeCheckBoxDeleteEmptyLines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxDeleteEmptyLines.Location = new System.Drawing.Point(12, 72);
            this.hopeCheckBoxDeleteEmptyLines.Name = "hopeCheckBoxDeleteEmptyLines";
            this.hopeCheckBoxDeleteEmptyLines.Size = new System.Drawing.Size(235, 20);
            this.hopeCheckBoxDeleteEmptyLines.TabIndex = 2;
            this.hopeCheckBoxDeleteEmptyLines.Text = "Удалять пустые строки";
            this.hopeCheckBoxDeleteEmptyLines.UseVisualStyleBackColor = true;
            this.hopeCheckBoxDeleteEmptyLines.CheckedChanged += new System.EventHandler(this.hopeCheckBoxDeleteEmptyLines_CheckedChanged);
            // 
            // hopeCheckBoxDeleteLinesWithoutLetters
            // 
            this.hopeCheckBoxDeleteLinesWithoutLetters.AutoSize = true;
            this.hopeCheckBoxDeleteLinesWithoutLetters.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxDeleteLinesWithoutLetters.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.Enable = true;
            this.hopeCheckBoxDeleteLinesWithoutLetters.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hopeCheckBoxDeleteLinesWithoutLetters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxDeleteLinesWithoutLetters.Location = new System.Drawing.Point(12, 98);
            this.hopeCheckBoxDeleteLinesWithoutLetters.Name = "hopeCheckBoxDeleteLinesWithoutLetters";
            this.hopeCheckBoxDeleteLinesWithoutLetters.Size = new System.Drawing.Size(253, 20);
            this.hopeCheckBoxDeleteLinesWithoutLetters.TabIndex = 3;
            this.hopeCheckBoxDeleteLinesWithoutLetters.Text = "Удалять строки без букв ";
            this.hopeCheckBoxDeleteLinesWithoutLetters.UseVisualStyleBackColor = true;
            this.hopeCheckBoxDeleteLinesWithoutLetters.CheckedChanged += new System.EventHandler(this.hopeCheckBoxDeleteLinesWithoutLetters_CheckedChanged);
            // 
            // ScanResultF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 127);
            this.ControlBox = false;
            this.Controls.Add(this.hopeCheckBoxDeleteLinesWithoutLetters);
            this.Controls.Add(this.hopeCheckBoxDeleteEmptyLines);
            this.Controls.Add(this.hopeCheckBoxRemoveExtraSpaces);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "ScanResultF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки результата сканирования";
            this.hopeForm1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private UI.ImageButton imageButtonFormMin;
        private UI.ImageButton imageButtonClose;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxRemoveExtraSpaces;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxDeleteEmptyLines;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxDeleteLinesWithoutLetters;
    }
}