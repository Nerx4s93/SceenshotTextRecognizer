namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    partial class SaveResult
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
            this.hopeButtonBrowseDirectory = new ReaLTaiizor.Controls.HopeButton();
            this.hopeTextBoxDirectoryPath = new ReaLTaiizor.Controls.HopeTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.hopeTextBoxFileName = new ReaLTaiizor.Controls.HopeTextBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.hopeComboBoxFileExtension = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeButtonSave = new ReaLTaiizor.Controls.HopeButton();
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
            this.hopeForm1.Size = new System.Drawing.Size(629, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Сохранить результат";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonFormMin
            // 
            this.imageButtonFormMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonFormMin.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.min;
            this.imageButtonFormMin.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.min2;
            this.imageButtonFormMin.Location = new System.Drawing.Point(569, 8);
            this.imageButtonFormMin.Name = "imageButtonFormMin";
            this.imageButtonFormMin.Size = new System.Drawing.Size(24, 24);
            this.imageButtonFormMin.TabIndex = 10;
            this.imageButtonFormMin.Text = "imageButton1";
            this.imageButtonFormMin.UseVisualStyleBackColor = true;
            this.imageButtonFormMin.Click += new System.EventHandler(this.imageButtonFormMin_Click);
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.imageButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.imageButtonClose.Location = new System.Drawing.Point(593, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 9;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            this.imageButtonClose.Click += new System.EventHandler(this.imageButtonClose_Click);
            // 
            // hopeButtonBrowseDirectory
            // 
            this.hopeButtonBrowseDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonBrowseDirectory.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonBrowseDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonBrowseDirectory.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonBrowseDirectory.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonBrowseDirectory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonBrowseDirectory.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonBrowseDirectory.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonBrowseDirectory.Location = new System.Drawing.Point(503, 78);
            this.hopeButtonBrowseDirectory.Name = "hopeButtonBrowseDirectory";
            this.hopeButtonBrowseDirectory.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonBrowseDirectory.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonBrowseDirectory.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonBrowseDirectory.TabIndex = 2;
            this.hopeButtonBrowseDirectory.Text = "Выбрать";
            this.hopeButtonBrowseDirectory.TextColor = System.Drawing.Color.White;
            this.hopeButtonBrowseDirectory.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonBrowseDirectory.Click += new System.EventHandler(this.hopeButtonBrowseDirectory_Click);
            // 
            // hopeTextBoxDirectoryPath
            // 
            this.hopeTextBoxDirectoryPath.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxDirectoryPath.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxDirectoryPath.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxDirectoryPath.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxDirectoryPath.Enabled = false;
            this.hopeTextBoxDirectoryPath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hopeTextBoxDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxDirectoryPath.Hint = "";
            this.hopeTextBoxDirectoryPath.Location = new System.Drawing.Point(17, 76);
            this.hopeTextBoxDirectoryPath.MaxLength = 32767;
            this.hopeTextBoxDirectoryPath.Multiline = false;
            this.hopeTextBoxDirectoryPath.Name = "hopeTextBoxDirectoryPath";
            this.hopeTextBoxDirectoryPath.PasswordChar = '\0';
            this.hopeTextBoxDirectoryPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxDirectoryPath.SelectedText = "";
            this.hopeTextBoxDirectoryPath.SelectionLength = 0;
            this.hopeTextBoxDirectoryPath.SelectionStart = 0;
            this.hopeTextBoxDirectoryPath.Size = new System.Drawing.Size(480, 42);
            this.hopeTextBoxDirectoryPath.TabIndex = 4;
            this.hopeTextBoxDirectoryPath.TabStop = false;
            this.hopeTextBoxDirectoryPath.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(12, 43);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(191, 30);
            this.bigLabel1.TabIndex = 5;
            this.bigLabel1.Text = "Папка сохранения";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(12, 126);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(120, 30);
            this.bigLabel2.TabIndex = 7;
            this.bigLabel2.Text = "Имя файла";
            // 
            // hopeTextBoxFileName
            // 
            this.hopeTextBoxFileName.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxFileName.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxFileName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxFileName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hopeTextBoxFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxFileName.Hint = "";
            this.hopeTextBoxFileName.Location = new System.Drawing.Point(17, 159);
            this.hopeTextBoxFileName.MaxLength = 32767;
            this.hopeTextBoxFileName.Multiline = false;
            this.hopeTextBoxFileName.Name = "hopeTextBoxFileName";
            this.hopeTextBoxFileName.PasswordChar = '\0';
            this.hopeTextBoxFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxFileName.SelectedText = "";
            this.hopeTextBoxFileName.SelectionLength = 0;
            this.hopeTextBoxFileName.SelectionStart = 0;
            this.hopeTextBoxFileName.Size = new System.Drawing.Size(403, 42);
            this.hopeTextBoxFileName.TabIndex = 6;
            this.hopeTextBoxFileName.TabStop = false;
            this.hopeTextBoxFileName.UseSystemPasswordChar = false;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(425, 126);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(198, 30);
            this.bigLabel3.TabIndex = 8;
            this.bigLabel3.Text = "Расширение файла";
            // 
            // hopeComboBoxFileExtension
            // 
            this.hopeComboBoxFileExtension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBoxFileExtension.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBoxFileExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hopeComboBoxFileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBoxFileExtension.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hopeComboBoxFileExtension.ItemHeight = 25;
            this.hopeComboBoxFileExtension.Items.AddRange(new object[] {
            ".txt",
            ".docx"});
            this.hopeComboBoxFileExtension.Location = new System.Drawing.Point(426, 168);
            this.hopeComboBoxFileExtension.Name = "hopeComboBoxFileExtension";
            this.hopeComboBoxFileExtension.Size = new System.Drawing.Size(191, 31);
            this.hopeComboBoxFileExtension.TabIndex = 9;
            // 
            // hopeButtonSave
            // 
            this.hopeButtonSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonSave.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonSave.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonSave.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonSave.Location = new System.Drawing.Point(495, 207);
            this.hopeButtonSave.Name = "hopeButtonSave";
            this.hopeButtonSave.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonSave.Size = new System.Drawing.Size(122, 45);
            this.hopeButtonSave.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonSave.TabIndex = 10;
            this.hopeButtonSave.Text = "Сохранить";
            this.hopeButtonSave.TextColor = System.Drawing.Color.White;
            this.hopeButtonSave.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonSave.Click += new System.EventHandler(this.hopeButtonSave_Click);
            // 
            // SaveResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 263);
            this.ControlBox = false;
            this.Controls.Add(this.hopeButtonSave);
            this.Controls.Add(this.hopeComboBoxFileExtension);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.hopeTextBoxFileName);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.hopeTextBoxDirectoryPath);
            this.Controls.Add(this.hopeButtonBrowseDirectory);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "SaveResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveResult";
            this.hopeForm1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private UI.ImageButton imageButtonFormMin;
        private UI.ImageButton imageButtonClose;
        private ReaLTaiizor.Controls.HopeButton hopeButtonBrowseDirectory;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxDirectoryPath;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxFileName;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxFileExtension;
        private ReaLTaiizor.Controls.HopeButton hopeButtonSave;
    }
}