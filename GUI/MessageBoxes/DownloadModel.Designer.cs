namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    partial class DownloadModel
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
            this.hopeForm = new ReaLTaiizor.Forms.HopeForm();
            this.imageButtonClose = new SceenshotTextRecognizer.UI.ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneDownload = new System.Windows.Forms.Panel();
            this.hopeButtonClose = new ReaLTaiizor.Controls.HopeButton();
            this.lostProgressBarDownloadModel = new ReaLTaiizor.Controls.LostProgressBar();
            this.labelStatusModel = new System.Windows.Forms.Label();
            this.lostProgressBarDownloadedModels = new ReaLTaiizor.Controls.LostProgressBar();
            this.labelStatusDownloadedModels = new System.Windows.Forms.Label();
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.panelSelectDownload = new System.Windows.Forms.Panel();
            this.hopeButtonSelectAll = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonCanselAll = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonStartDownload = new ReaLTaiizor.Controls.HopeButton();
            this.hopeTextBoxSearchLanguageModel = new ReaLTaiizor.Controls.HopeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxLanguages = new System.Windows.Forms.CheckedListBox();
            this.hopeForm.SuspendLayout();
            this.paneDownload.SuspendLayout();
            this.panelSelectDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm
            // 
            this.hopeForm.ControlBox = false;
            this.hopeForm.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm.Controls.Add(this.imageButtonClose);
            this.hopeForm.Controls.Add(this.panel1);
            this.hopeForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm.Image = null;
            this.hopeForm.Location = new System.Drawing.Point(0, 0);
            this.hopeForm.Name = "hopeForm";
            this.hopeForm.Size = new System.Drawing.Size(534, 40);
            this.hopeForm.TabIndex = 0;
            this.hopeForm.Text = "Загрузка языков";
            this.hopeForm.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.imageButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.imageButtonClose.Location = new System.Drawing.Point(499, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 2;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            this.imageButtonClose.Click += new System.EventHandler(this.imageButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 314);
            this.panel1.TabIndex = 1;
            // 
            // paneDownload
            // 
            this.paneDownload.BackColor = System.Drawing.SystemColors.Control;
            this.paneDownload.Controls.Add(this.hopeButtonClose);
            this.paneDownload.Controls.Add(this.lostProgressBarDownloadModel);
            this.paneDownload.Controls.Add(this.labelStatusModel);
            this.paneDownload.Controls.Add(this.lostProgressBarDownloadedModels);
            this.paneDownload.Controls.Add(this.labelStatusDownloadedModels);
            this.paneDownload.Location = new System.Drawing.Point(541, 40);
            this.paneDownload.Name = "paneDownload";
            this.paneDownload.Size = new System.Drawing.Size(535, 235);
            this.paneDownload.TabIndex = 1;
            // 
            // hopeButtonClose
            // 
            this.hopeButtonClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonClose.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonClose.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonClose.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonClose.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonClose.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonClose.Location = new System.Drawing.Point(273, 187);
            this.hopeButtonClose.Name = "hopeButtonClose";
            this.hopeButtonClose.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonClose.Size = new System.Drawing.Size(259, 40);
            this.hopeButtonClose.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonClose.TabIndex = 6;
            this.hopeButtonClose.Text = "Остановить загрузку";
            this.hopeButtonClose.TextColor = System.Drawing.Color.White;
            this.hopeButtonClose.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonClose.Click += new System.EventHandler(this.hopeButtonClose_Click);
            // 
            // lostProgressBarDownloadModel
            // 
            this.lostProgressBarDownloadModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostProgressBarDownloadModel.Color = System.Drawing.Color.DodgerBlue;
            this.lostProgressBarDownloadModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostProgressBarDownloadModel.Hover = false;
            this.lostProgressBarDownloadModel.Location = new System.Drawing.Point(3, 104);
            this.lostProgressBarDownloadModel.Name = "lostProgressBarDownloadModel";
            this.lostProgressBarDownloadModel.Progress = 0;
            this.lostProgressBarDownloadModel.Size = new System.Drawing.Size(529, 35);
            this.lostProgressBarDownloadModel.TabIndex = 6;
            this.lostProgressBarDownloadModel.Text = "lostProgressBar2";
            // 
            // labelStatusModel
            // 
            this.labelStatusModel.AutoSize = true;
            this.labelStatusModel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelStatusModel.Location = new System.Drawing.Point(3, 71);
            this.labelStatusModel.Name = "labelStatusModel";
            this.labelStatusModel.Size = new System.Drawing.Size(183, 30);
            this.labelStatusModel.TabIndex = 5;
            this.labelStatusModel.Text = "Загрузка модели";
            // 
            // lostProgressBarDownloadedModels
            // 
            this.lostProgressBarDownloadedModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostProgressBarDownloadedModels.Color = System.Drawing.Color.DodgerBlue;
            this.lostProgressBarDownloadedModels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostProgressBarDownloadedModels.Hover = false;
            this.lostProgressBarDownloadedModels.Location = new System.Drawing.Point(3, 33);
            this.lostProgressBarDownloadedModels.Name = "lostProgressBarDownloadedModels";
            this.lostProgressBarDownloadedModels.Progress = 0;
            this.lostProgressBarDownloadedModels.Size = new System.Drawing.Size(529, 35);
            this.lostProgressBarDownloadedModels.TabIndex = 4;
            this.lostProgressBarDownloadedModels.Text = "lostProgressBar1";
            // 
            // labelStatusDownloadedModels
            // 
            this.labelStatusDownloadedModels.AutoSize = true;
            this.labelStatusDownloadedModels.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelStatusDownloadedModels.Location = new System.Drawing.Point(3, 3);
            this.labelStatusDownloadedModels.Name = "labelStatusDownloadedModels";
            this.labelStatusDownloadedModels.Size = new System.Drawing.Size(217, 30);
            this.labelStatusDownloadedModels.TabIndex = 3;
            this.labelStatusDownloadedModels.Text = "Загружено моделей";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.ReadOnly = false;
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "materialCheckBox1";
            this.materialCheckBox1.UseAccentColor = false;
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.ReadOnly = false;
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "Русский";
            this.materialCheckBox2.UseAccentColor = false;
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.ReadOnly = false;
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckBox3.TabIndex = 0;
            this.materialCheckBox3.Text = "Английский";
            this.materialCheckBox3.UseAccentColor = false;
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // panelSelectDownload
            // 
            this.panelSelectDownload.BackColor = System.Drawing.SystemColors.Control;
            this.panelSelectDownload.Controls.Add(this.hopeButtonSelectAll);
            this.panelSelectDownload.Controls.Add(this.hopeButtonCanselAll);
            this.panelSelectDownload.Controls.Add(this.hopeButtonStartDownload);
            this.panelSelectDownload.Controls.Add(this.hopeTextBoxSearchLanguageModel);
            this.panelSelectDownload.Controls.Add(this.label2);
            this.panelSelectDownload.Controls.Add(this.checkedListBoxLanguages);
            this.panelSelectDownload.Location = new System.Drawing.Point(0, 40);
            this.panelSelectDownload.Name = "panelSelectDownload";
            this.panelSelectDownload.Size = new System.Drawing.Size(535, 235);
            this.panelSelectDownload.TabIndex = 6;
            // 
            // hopeButtonSelectAll
            // 
            this.hopeButtonSelectAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonSelectAll.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonSelectAll.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonSelectAll.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonSelectAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonSelectAll.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonSelectAll.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonSelectAll.Location = new System.Drawing.Point(268, 102);
            this.hopeButtonSelectAll.Name = "hopeButtonSelectAll";
            this.hopeButtonSelectAll.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonSelectAll.Size = new System.Drawing.Size(259, 40);
            this.hopeButtonSelectAll.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonSelectAll.TabIndex = 5;
            this.hopeButtonSelectAll.Text = "Выбрать всё";
            this.hopeButtonSelectAll.TextColor = System.Drawing.Color.White;
            this.hopeButtonSelectAll.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonSelectAll.Click += new System.EventHandler(this.hopeButtonSelectAll_Click);
            // 
            // hopeButtonCanselAll
            // 
            this.hopeButtonCanselAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonCanselAll.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonCanselAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonCanselAll.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonCanselAll.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonCanselAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonCanselAll.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonCanselAll.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonCanselAll.Location = new System.Drawing.Point(268, 145);
            this.hopeButtonCanselAll.Name = "hopeButtonCanselAll";
            this.hopeButtonCanselAll.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonCanselAll.Size = new System.Drawing.Size(259, 40);
            this.hopeButtonCanselAll.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonCanselAll.TabIndex = 4;
            this.hopeButtonCanselAll.Text = "Отменить всё";
            this.hopeButtonCanselAll.TextColor = System.Drawing.Color.White;
            this.hopeButtonCanselAll.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonCanselAll.Click += new System.EventHandler(this.hopeButtonCanselAll_Click);
            // 
            // hopeButtonStartDownload
            // 
            this.hopeButtonStartDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonStartDownload.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonStartDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonStartDownload.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonStartDownload.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonStartDownload.Enabled = false;
            this.hopeButtonStartDownload.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonStartDownload.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonStartDownload.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonStartDownload.Location = new System.Drawing.Point(268, 187);
            this.hopeButtonStartDownload.Name = "hopeButtonStartDownload";
            this.hopeButtonStartDownload.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonStartDownload.Size = new System.Drawing.Size(259, 40);
            this.hopeButtonStartDownload.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonStartDownload.TabIndex = 3;
            this.hopeButtonStartDownload.Text = "Начать загрузку";
            this.hopeButtonStartDownload.TextColor = System.Drawing.Color.White;
            this.hopeButtonStartDownload.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonStartDownload.Click += new System.EventHandler(this.hopeButtonStartDownload_Click);
            // 
            // hopeTextBoxSearchLanguageModel
            // 
            this.hopeTextBoxSearchLanguageModel.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxSearchLanguageModel.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxSearchLanguageModel.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxSearchLanguageModel.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxSearchLanguageModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxSearchLanguageModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxSearchLanguageModel.Hint = "";
            this.hopeTextBoxSearchLanguageModel.Location = new System.Drawing.Point(268, 33);
            this.hopeTextBoxSearchLanguageModel.MaxLength = 32767;
            this.hopeTextBoxSearchLanguageModel.Multiline = false;
            this.hopeTextBoxSearchLanguageModel.Name = "hopeTextBoxSearchLanguageModel";
            this.hopeTextBoxSearchLanguageModel.PasswordChar = '\0';
            this.hopeTextBoxSearchLanguageModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxSearchLanguageModel.SelectedText = "";
            this.hopeTextBoxSearchLanguageModel.SelectionLength = 0;
            this.hopeTextBoxSearchLanguageModel.SelectionStart = 0;
            this.hopeTextBoxSearchLanguageModel.Size = new System.Drawing.Size(254, 38);
            this.hopeTextBoxSearchLanguageModel.TabIndex = 2;
            this.hopeTextBoxSearchLanguageModel.TabStop = false;
            this.hopeTextBoxSearchLanguageModel.UseSystemPasswordChar = false;
            this.hopeTextBoxSearchLanguageModel.TextChanged += new System.EventHandler(this.hopeTextBoxSearchLanguageModel_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(268, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск";
            // 
            // checkedListBoxLanguages
            // 
            this.checkedListBoxLanguages.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.checkedListBoxLanguages.FormattingEnabled = true;
            this.checkedListBoxLanguages.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Испанский",
            "Китайский",
            "Японский",
            "Французкий"});
            this.checkedListBoxLanguages.Location = new System.Drawing.Point(12, 6);
            this.checkedListBoxLanguages.Name = "checkedListBoxLanguages";
            this.checkedListBoxLanguages.Size = new System.Drawing.Size(250, 221);
            this.checkedListBoxLanguages.TabIndex = 0;
            this.checkedListBoxLanguages.SelectedValueChanged += new System.EventHandler(this.checkedListBoxLanguages_SelectedValueChanged);
            // 
            // DownloadModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 276);
            this.ControlBox = false;
            this.Controls.Add(this.panelSelectDownload);
            this.Controls.Add(this.paneDownload);
            this.Controls.Add(this.hopeForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "DownloadModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownloadMode";
            this.hopeForm.ResumeLayout(false);
            this.paneDownload.ResumeLayout(false);
            this.paneDownload.PerformLayout();
            this.panelSelectDownload.ResumeLayout(false);
            this.panelSelectDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneDownload;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.HopeButton hopeButtonSelectAll;
        private ReaLTaiizor.Controls.HopeButton hopeButtonCanselAll;
        private ReaLTaiizor.Controls.HopeButton hopeButtonStartDownload;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxSearchLanguageModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
        private ReaLTaiizor.Controls.HopeButton hopeButtonClose;
        private ReaLTaiizor.Controls.LostProgressBar lostProgressBarDownloadModel;
        private System.Windows.Forms.Label labelStatusModel;
        private ReaLTaiizor.Controls.LostProgressBar lostProgressBarDownloadedModels;
        private System.Windows.Forms.Label labelStatusDownloadedModels;
        private UI.ImageButton imageButtonClose;
        private System.Windows.Forms.Panel panelSelectDownload;
    }
}