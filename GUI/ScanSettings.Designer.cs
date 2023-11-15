namespace SceenshotTextRecognizer.GUI
{
    partial class ScanSettings
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
            this.imageButtonClose = new SceenshotTextRecognizer.UI.ImageButton();
            this.hopeTextBoxFind = new ReaLTaiizor.Controls.HopeTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hopeTextBoxSelected = new ReaLTaiizor.Controls.HopeTextBox();
            this.crownListViewSelectModels = new ReaLTaiizor.Controls.CrownListView();
            this.hopeButtonScan = new ReaLTaiizor.Controls.HopeButton();
            this.hopeForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBox = false;
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Controls.Add(this.imageButtonClose);
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = null;
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(380, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.ImageNoHovered = null;
            this.imageButtonClose.ImageOnHovered = null;
            this.imageButtonClose.Location = new System.Drawing.Point(346, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 6;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            this.imageButtonClose.Click += new System.EventHandler(this.imageButtonClose_Click);
            // 
            // hopeTextBoxFind
            // 
            this.hopeTextBoxFind.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxFind.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxFind.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxFind.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxFind.Hint = "";
            this.hopeTextBoxFind.Location = new System.Drawing.Point(14, 84);
            this.hopeTextBoxFind.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.hopeTextBoxFind.MaxLength = 32767;
            this.hopeTextBoxFind.Multiline = false;
            this.hopeTextBoxFind.Name = "hopeTextBoxFind";
            this.hopeTextBoxFind.PasswordChar = '\0';
            this.hopeTextBoxFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxFind.SelectedText = "";
            this.hopeTextBoxFind.SelectionLength = 0;
            this.hopeTextBoxFind.SelectionStart = 0;
            this.hopeTextBoxFind.Size = new System.Drawing.Size(175, 38);
            this.hopeTextBoxFind.TabIndex = 1;
            this.hopeTextBoxFind.TabStop = false;
            this.hopeTextBoxFind.UseSystemPasswordChar = false;
            this.hopeTextBoxFind.TextChanged += new System.EventHandler(this.hopeTextBoxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбрано";
            // 
            // hopeTextBoxSelected
            // 
            this.hopeTextBoxSelected.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxSelected.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxSelected.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxSelected.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxSelected.Enabled = false;
            this.hopeTextBoxSelected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxSelected.Hint = "";
            this.hopeTextBoxSelected.Location = new System.Drawing.Point(199, 84);
            this.hopeTextBoxSelected.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.hopeTextBoxSelected.MaxLength = 32767;
            this.hopeTextBoxSelected.Multiline = false;
            this.hopeTextBoxSelected.Name = "hopeTextBoxSelected";
            this.hopeTextBoxSelected.PasswordChar = '\0';
            this.hopeTextBoxSelected.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxSelected.SelectedText = "";
            this.hopeTextBoxSelected.SelectionLength = 0;
            this.hopeTextBoxSelected.SelectionStart = 0;
            this.hopeTextBoxSelected.Size = new System.Drawing.Size(175, 38);
            this.hopeTextBoxSelected.TabIndex = 4;
            this.hopeTextBoxSelected.TabStop = false;
            this.hopeTextBoxSelected.UseSystemPasswordChar = false;
            // 
            // crownListViewSelectModels
            // 
            this.crownListViewSelectModels.Location = new System.Drawing.Point(14, 132);
            this.crownListViewSelectModels.Name = "crownListViewSelectModels";
            this.crownListViewSelectModels.Size = new System.Drawing.Size(360, 280);
            this.crownListViewSelectModels.TabIndex = 5;
            this.crownListViewSelectModels.Text = "crownListView1";
            this.crownListViewSelectModels.DoubleClick += new System.EventHandler(this.crownListViewSelectModels_DoubleClick);
            // 
            // hopeButtonScan
            // 
            this.hopeButtonScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonScan.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonScan.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonScan.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonScan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonScan.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonScan.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonScan.Location = new System.Drawing.Point(254, 418);
            this.hopeButtonScan.Name = "hopeButtonScan";
            this.hopeButtonScan.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonScan.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonScan.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonScan.TabIndex = 6;
            this.hopeButtonScan.Text = "Сканировать";
            this.hopeButtonScan.TextColor = System.Drawing.Color.White;
            this.hopeButtonScan.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonScan.Click += new System.EventHandler(this.hopeButtonScan_Click);
            // 
            // ScanSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 460);
            this.ControlBox = false;
            this.Controls.Add(this.hopeButtonScan);
            this.Controls.Add(this.crownListViewSelectModels);
            this.Controls.Add(this.hopeTextBoxSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hopeTextBoxFind);
            this.Controls.Add(this.hopeForm1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximumSize = new System.Drawing.Size(3840, 2400);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "ScanSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanSettings_FormClosing);
            this.hopeForm1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxSelected;
        private ReaLTaiizor.Controls.CrownListView crownListViewSelectModels;
        private ReaLTaiizor.Controls.HopeButton hopeButtonScan;
        private UI.ImageButton imageButtonClose;
    }
}