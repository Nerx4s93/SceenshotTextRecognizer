namespace SceenshotTextRecognizer.GUI
{
    partial class FormMain
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
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hopeButtonSettingsScanResult = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonSettingsSelectArea = new ReaLTaiizor.Controls.HopeButton();
            this.label3 = new System.Windows.Forms.Label();
            this.hopeCheckBoxAddToAutorun = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeCheckBoxWorkInFon = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeCheckBoxShowOnOtherWindows = new ReaLTaiizor.Controls.HopeCheckBox();
            this.hopeButtonBind = new ReaLTaiizor.Controls.HopeButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.hopeTextBoxSearchLanguageModel = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeButtonDownloadLanguageModels = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonDeleteLanguageModel = new ReaLTaiizor.Controls.HopeButton();
            this.crownListViewLanguagePacks = new ReaLTaiizor.Controls.CrownListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.hopeTextBoxSearchCombinationOfLanguagePacks = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeButtonDeleteCombination = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonNewCombination = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonEditCombination = new ReaLTaiizor.Controls.HopeButton();
            this.crownListViewCombinationOfLanguagePacks = new ReaLTaiizor.Controls.CrownListView();
            this.hopeForm1.SuspendLayout();
            this.hopeTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.hopeForm1.Size = new System.Drawing.Size(631, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "SceenshotTextRecognizer";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonFormMin
            // 
            this.imageButtonFormMin.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.min;
            this.imageButtonFormMin.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.min2;
            this.imageButtonFormMin.Location = new System.Drawing.Point(573, 8);
            this.imageButtonFormMin.Name = "imageButtonFormMin";
            this.imageButtonFormMin.Size = new System.Drawing.Size(24, 24);
            this.imageButtonFormMin.TabIndex = 6;
            this.imageButtonFormMin.Text = "imageButton1";
            this.imageButtonFormMin.UseVisualStyleBackColor = true;
            this.imageButtonFormMin.Click += new System.EventHandler(this.imageButtonFormMin_Click);
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.imageButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.imageButtonClose.Location = new System.Drawing.Point(597, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 5;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            this.imageButtonClose.Click += new System.EventHandler(this.imageButtonClose_Click);
            // 
            // hopeTabPage1
            // 
            this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTabPage1.Controls.Add(this.tabPage1);
            this.hopeTabPage1.Controls.Add(this.tabPage2);
            this.hopeTabPage1.Controls.Add(this.tabPage3);
            this.hopeTabPage1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTabPage1.ForeColorA = System.Drawing.Color.Silver;
            this.hopeTabPage1.ForeColorB = System.Drawing.Color.Gray;
            this.hopeTabPage1.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ItemSize = new System.Drawing.Size(200, 40);
            this.hopeTabPage1.Location = new System.Drawing.Point(0, 40);
            this.hopeTabPage1.Name = "hopeTabPage1";
            this.hopeTabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(631, 313);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopeTabPage1.TabIndex = 1;
            this.hopeTabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.hopeButtonSettingsScanResult);
            this.tabPage1.Controls.Add(this.hopeButtonSettingsSelectArea);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.hopeCheckBoxAddToAutorun);
            this.tabPage1.Controls.Add(this.hopeCheckBoxWorkInFon);
            this.tabPage1.Controls.Add(this.hopeCheckBoxShowOnOtherWindows);
            this.tabPage1.Controls.Add(this.hopeButtonBind);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройки";
            // 
            // hopeButtonSettingsScanResult
            // 
            this.hopeButtonSettingsScanResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonSettingsScanResult.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonSettingsScanResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonSettingsScanResult.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonSettingsScanResult.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonSettingsScanResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hopeButtonSettingsScanResult.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonSettingsScanResult.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonSettingsScanResult.Location = new System.Drawing.Point(316, 52);
            this.hopeButtonSettingsScanResult.Name = "hopeButtonSettingsScanResult";
            this.hopeButtonSettingsScanResult.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonSettingsScanResult.Size = new System.Drawing.Size(303, 39);
            this.hopeButtonSettingsScanResult.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonSettingsScanResult.TabIndex = 6;
            this.hopeButtonSettingsScanResult.Text = "Результат сканирования";
            this.hopeButtonSettingsScanResult.TextColor = System.Drawing.Color.White;
            this.hopeButtonSettingsScanResult.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonSettingsScanResult.Click += new System.EventHandler(this.hopeButtonSettingsScanResult_Click);
            // 
            // hopeButtonSettingsSelectArea
            // 
            this.hopeButtonSettingsSelectArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonSettingsSelectArea.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonSettingsSelectArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonSettingsSelectArea.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonSettingsSelectArea.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonSettingsSelectArea.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hopeButtonSettingsSelectArea.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonSettingsSelectArea.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonSettingsSelectArea.Location = new System.Drawing.Point(6, 52);
            this.hopeButtonSettingsSelectArea.Name = "hopeButtonSettingsSelectArea";
            this.hopeButtonSettingsSelectArea.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonSettingsSelectArea.Size = new System.Drawing.Size(304, 39);
            this.hopeButtonSettingsSelectArea.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonSettingsSelectArea.TabIndex = 5;
            this.hopeButtonSettingsSelectArea.Text = "Выделение области";
            this.hopeButtonSettingsSelectArea.TextColor = System.Drawing.Color.White;
            this.hopeButtonSettingsSelectArea.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonSettingsSelectArea.Click += new System.EventHandler(this.hopeButtonSettingsSelectArea_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(530, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Версия 1.0.0";
            // 
            // hopeCheckBoxAddToAutorun
            // 
            this.hopeCheckBoxAddToAutorun.AutoSize = true;
            this.hopeCheckBoxAddToAutorun.BackColor = System.Drawing.SystemColors.Control;
            this.hopeCheckBoxAddToAutorun.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxAddToAutorun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxAddToAutorun.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxAddToAutorun.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxAddToAutorun.Enable = true;
            this.hopeCheckBoxAddToAutorun.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxAddToAutorun.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxAddToAutorun.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxAddToAutorun.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hopeCheckBoxAddToAutorun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxAddToAutorun.Location = new System.Drawing.Point(6, 149);
            this.hopeCheckBoxAddToAutorun.Name = "hopeCheckBoxAddToAutorun";
            this.hopeCheckBoxAddToAutorun.Size = new System.Drawing.Size(171, 20);
            this.hopeCheckBoxAddToAutorun.TabIndex = 3;
            this.hopeCheckBoxAddToAutorun.Text = "Автозагрузка";
            this.hopeCheckBoxAddToAutorun.UseVisualStyleBackColor = false;
            this.hopeCheckBoxAddToAutorun.CheckedChanged += new System.EventHandler(this.hopeCheckBoxAddToAutorun_CheckedChanged);
            // 
            // hopeCheckBoxWorkInFon
            // 
            this.hopeCheckBoxWorkInFon.AutoSize = true;
            this.hopeCheckBoxWorkInFon.BackColor = System.Drawing.SystemColors.Control;
            this.hopeCheckBoxWorkInFon.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxWorkInFon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxWorkInFon.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxWorkInFon.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxWorkInFon.Enable = true;
            this.hopeCheckBoxWorkInFon.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxWorkInFon.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxWorkInFon.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxWorkInFon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hopeCheckBoxWorkInFon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxWorkInFon.Location = new System.Drawing.Point(6, 123);
            this.hopeCheckBoxWorkInFon.Name = "hopeCheckBoxWorkInFon";
            this.hopeCheckBoxWorkInFon.Size = new System.Drawing.Size(312, 20);
            this.hopeCheckBoxWorkInFon.TabIndex = 2;
            this.hopeCheckBoxWorkInFon.Text = "Работа в фоновом режиме";
            this.hopeCheckBoxWorkInFon.UseVisualStyleBackColor = false;
            this.hopeCheckBoxWorkInFon.CheckedChanged += new System.EventHandler(this.hopeCheckBoxWorkInFon_CheckedChanged);
            // 
            // hopeCheckBoxShowOnOtherWindows
            // 
            this.hopeCheckBoxShowOnOtherWindows.AutoSize = true;
            this.hopeCheckBoxShowOnOtherWindows.BackColor = System.Drawing.SystemColors.Control;
            this.hopeCheckBoxShowOnOtherWindows.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxShowOnOtherWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBoxShowOnOtherWindows.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBoxShowOnOtherWindows.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBoxShowOnOtherWindows.Enable = true;
            this.hopeCheckBoxShowOnOtherWindows.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBoxShowOnOtherWindows.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBoxShowOnOtherWindows.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBoxShowOnOtherWindows.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hopeCheckBoxShowOnOtherWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBoxShowOnOtherWindows.Location = new System.Drawing.Point(6, 97);
            this.hopeCheckBoxShowOnOtherWindows.Name = "hopeCheckBoxShowOnOtherWindows";
            this.hopeCheckBoxShowOnOtherWindows.Size = new System.Drawing.Size(366, 20);
            this.hopeCheckBoxShowOnOtherWindows.TabIndex = 1;
            this.hopeCheckBoxShowOnOtherWindows.Text = "Показывать поверх других окон";
            this.hopeCheckBoxShowOnOtherWindows.UseVisualStyleBackColor = false;
            this.hopeCheckBoxShowOnOtherWindows.CheckedChanged += new System.EventHandler(this.hopeCheckBoxShowOnOtherForms_CheckedChanged);
            // 
            // hopeButtonBind
            // 
            this.hopeButtonBind.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonBind.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonBind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonBind.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonBind.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonBind.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hopeButtonBind.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonBind.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonBind.Location = new System.Drawing.Point(6, 6);
            this.hopeButtonBind.Name = "hopeButtonBind";
            this.hopeButtonBind.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonBind.Size = new System.Drawing.Size(613, 40);
            this.hopeButtonBind.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonBind.TabIndex = 0;
            this.hopeButtonBind.Text = "Bind:";
            this.hopeButtonBind.TextColor = System.Drawing.Color.White;
            this.hopeButtonBind.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonBind.Click += new System.EventHandler(this.hopeButtonBind_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.hopeTextBoxSearchLanguageModel);
            this.tabPage2.Controls.Add(this.hopeButtonDownloadLanguageModels);
            this.tabPage2.Controls.Add(this.hopeButtonDeleteLanguageModel);
            this.tabPage2.Controls.Add(this.crownListViewLanguagePacks);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Языки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.Location = new System.Drawing.Point(500, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
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
            this.hopeTextBoxSearchLanguageModel.Location = new System.Drawing.Point(505, 39);
            this.hopeTextBoxSearchLanguageModel.MaxLength = 32767;
            this.hopeTextBoxSearchLanguageModel.Multiline = false;
            this.hopeTextBoxSearchLanguageModel.Name = "hopeTextBoxSearchLanguageModel";
            this.hopeTextBoxSearchLanguageModel.PasswordChar = '\0';
            this.hopeTextBoxSearchLanguageModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxSearchLanguageModel.SelectedText = "";
            this.hopeTextBoxSearchLanguageModel.SelectionLength = 0;
            this.hopeTextBoxSearchLanguageModel.SelectionStart = 0;
            this.hopeTextBoxSearchLanguageModel.Size = new System.Drawing.Size(114, 38);
            this.hopeTextBoxSearchLanguageModel.TabIndex = 3;
            this.hopeTextBoxSearchLanguageModel.TabStop = false;
            this.hopeTextBoxSearchLanguageModel.UseSystemPasswordChar = false;
            this.hopeTextBoxSearchLanguageModel.TextChanged += new System.EventHandler(this.hopeTextBoxSearchLanguageModel_TextChanged);
            // 
            // hopeButtonDownloadLanguageModels
            // 
            this.hopeButtonDownloadLanguageModels.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonDownloadLanguageModels.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonDownloadLanguageModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonDownloadLanguageModels.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonDownloadLanguageModels.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonDownloadLanguageModels.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonDownloadLanguageModels.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonDownloadLanguageModels.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonDownloadLanguageModels.Location = new System.Drawing.Point(505, 226);
            this.hopeButtonDownloadLanguageModels.Name = "hopeButtonDownloadLanguageModels";
            this.hopeButtonDownloadLanguageModels.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonDownloadLanguageModels.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonDownloadLanguageModels.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonDownloadLanguageModels.TabIndex = 2;
            this.hopeButtonDownloadLanguageModels.Text = "Скачать";
            this.hopeButtonDownloadLanguageModels.TextColor = System.Drawing.Color.White;
            this.hopeButtonDownloadLanguageModels.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonDownloadLanguageModels.Click += new System.EventHandler(this.hopeButtonDownloadLanguageModels_Click);
            // 
            // hopeButtonDeleteLanguageModel
            // 
            this.hopeButtonDeleteLanguageModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonDeleteLanguageModel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonDeleteLanguageModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonDeleteLanguageModel.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonDeleteLanguageModel.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonDeleteLanguageModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonDeleteLanguageModel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonDeleteLanguageModel.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonDeleteLanguageModel.Location = new System.Drawing.Point(505, 180);
            this.hopeButtonDeleteLanguageModel.Name = "hopeButtonDeleteLanguageModel";
            this.hopeButtonDeleteLanguageModel.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonDeleteLanguageModel.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonDeleteLanguageModel.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonDeleteLanguageModel.TabIndex = 1;
            this.hopeButtonDeleteLanguageModel.Text = "Удалить";
            this.hopeButtonDeleteLanguageModel.TextColor = System.Drawing.Color.White;
            this.hopeButtonDeleteLanguageModel.Visible = false;
            this.hopeButtonDeleteLanguageModel.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonDeleteLanguageModel.Click += new System.EventHandler(this.hopeButtonDeleteLanguageModel_Click);
            // 
            // crownListViewLanguagePacks
            // 
            this.crownListViewLanguagePacks.Location = new System.Drawing.Point(6, 6);
            this.crownListViewLanguagePacks.MultiSelect = true;
            this.crownListViewLanguagePacks.Name = "crownListViewLanguagePacks";
            this.crownListViewLanguagePacks.Size = new System.Drawing.Size(493, 260);
            this.crownListViewLanguagePacks.TabIndex = 0;
            this.crownListViewLanguagePacks.Text = "crownListView1";
            this.crownListViewLanguagePacks.SelectedIndicesChanged += new System.EventHandler(this.crownListViewLanguagePacks_SelectedIndicesChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.hopeTextBoxSearchCombinationOfLanguagePacks);
            this.tabPage3.Controls.Add(this.hopeButtonDeleteCombination);
            this.tabPage3.Controls.Add(this.hopeButtonNewCombination);
            this.tabPage3.Controls.Add(this.hopeButtonEditCombination);
            this.tabPage3.Controls.Add(this.crownListViewCombinationOfLanguagePacks);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(631, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Языковые комбинации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(500, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск";
            // 
            // hopeTextBoxSearchCombinationOfLanguagePacks
            // 
            this.hopeTextBoxSearchCombinationOfLanguagePacks.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.BaseColor = System.Drawing.Color.White;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxSearchCombinationOfLanguagePacks.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxSearchCombinationOfLanguagePacks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Hint = "";
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Location = new System.Drawing.Point(505, 39);
            this.hopeTextBoxSearchCombinationOfLanguagePacks.MaxLength = 32767;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Multiline = false;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Name = "hopeTextBoxSearchCombinationOfLanguagePacks";
            this.hopeTextBoxSearchCombinationOfLanguagePacks.PasswordChar = '\0';
            this.hopeTextBoxSearchCombinationOfLanguagePacks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.SelectedText = "";
            this.hopeTextBoxSearchCombinationOfLanguagePacks.SelectionLength = 0;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.SelectionStart = 0;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.Size = new System.Drawing.Size(114, 38);
            this.hopeTextBoxSearchCombinationOfLanguagePacks.TabIndex = 5;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.TabStop = false;
            this.hopeTextBoxSearchCombinationOfLanguagePacks.UseSystemPasswordChar = false;
            // 
            // hopeButtonDeleteCombination
            // 
            this.hopeButtonDeleteCombination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonDeleteCombination.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonDeleteCombination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonDeleteCombination.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonDeleteCombination.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonDeleteCombination.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonDeleteCombination.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonDeleteCombination.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonDeleteCombination.Location = new System.Drawing.Point(505, 134);
            this.hopeButtonDeleteCombination.Name = "hopeButtonDeleteCombination";
            this.hopeButtonDeleteCombination.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonDeleteCombination.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonDeleteCombination.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonDeleteCombination.TabIndex = 4;
            this.hopeButtonDeleteCombination.Text = "Удалить";
            this.hopeButtonDeleteCombination.TextColor = System.Drawing.Color.White;
            this.hopeButtonDeleteCombination.Visible = false;
            this.hopeButtonDeleteCombination.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonDeleteCombination.Click += new System.EventHandler(this.hopeButtonDeleteCombination_Click);
            // 
            // hopeButtonNewCombination
            // 
            this.hopeButtonNewCombination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonNewCombination.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonNewCombination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonNewCombination.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonNewCombination.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonNewCombination.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonNewCombination.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonNewCombination.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonNewCombination.Location = new System.Drawing.Point(505, 226);
            this.hopeButtonNewCombination.Name = "hopeButtonNewCombination";
            this.hopeButtonNewCombination.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonNewCombination.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonNewCombination.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonNewCombination.TabIndex = 3;
            this.hopeButtonNewCombination.Text = "Новая комбинация";
            this.hopeButtonNewCombination.TextColor = System.Drawing.Color.White;
            this.hopeButtonNewCombination.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonNewCombination.Click += new System.EventHandler(this.hopeButtonNewCombination_Click);
            // 
            // hopeButtonEditCombination
            // 
            this.hopeButtonEditCombination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonEditCombination.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonEditCombination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonEditCombination.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonEditCombination.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonEditCombination.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonEditCombination.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonEditCombination.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonEditCombination.Location = new System.Drawing.Point(505, 180);
            this.hopeButtonEditCombination.Name = "hopeButtonEditCombination";
            this.hopeButtonEditCombination.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonEditCombination.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonEditCombination.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonEditCombination.TabIndex = 2;
            this.hopeButtonEditCombination.Text = "Редактировать";
            this.hopeButtonEditCombination.TextColor = System.Drawing.Color.White;
            this.hopeButtonEditCombination.Visible = false;
            this.hopeButtonEditCombination.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonEditCombination.Click += new System.EventHandler(this.hopeButtonEditCombination_Click);
            // 
            // crownListViewCombinationOfLanguagePacks
            // 
            this.crownListViewCombinationOfLanguagePacks.Location = new System.Drawing.Point(6, 6);
            this.crownListViewCombinationOfLanguagePacks.Name = "crownListViewCombinationOfLanguagePacks";
            this.crownListViewCombinationOfLanguagePacks.Size = new System.Drawing.Size(493, 260);
            this.crownListViewCombinationOfLanguagePacks.TabIndex = 1;
            this.crownListViewCombinationOfLanguagePacks.Text = "crownListView2";
            this.crownListViewCombinationOfLanguagePacks.SelectedIndicesChanged += new System.EventHandler(this.crownListViewCombinationOfLanguagePacks_SelectedIndicesChanged);
            this.crownListViewCombinationOfLanguagePacks.DoubleClick += new System.EventHandler(this.crownListViewCombinationOfLanguagePacks_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 350);
            this.ControlBox = false;
            this.Controls.Add(this.hopeTabPage1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenshotTextRecognizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.hopeForm1.ResumeLayout(false);
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ReaLTaiizor.Controls.HopeButton hopeButtonBind;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxShowOnOtherWindows;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxWorkInFon;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBoxAddToAutorun;
        private ReaLTaiizor.Controls.CrownListView crownListViewLanguagePacks;
        private ReaLTaiizor.Controls.HopeButton hopeButtonDeleteLanguageModel;
        private ReaLTaiizor.Controls.HopeButton hopeButtonDownloadLanguageModels;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxSearchLanguageModel;
        private ReaLTaiizor.Controls.CrownListView crownListViewCombinationOfLanguagePacks;
        private ReaLTaiizor.Controls.HopeButton hopeButtonNewCombination;
        private ReaLTaiizor.Controls.HopeButton hopeButtonEditCombination;
        private ReaLTaiizor.Controls.HopeButton hopeButtonDeleteCombination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxSearchCombinationOfLanguagePacks;
        private System.Windows.Forms.Label label3;
        private UI.ImageButton imageButtonClose;
        private UI.ImageButton imageButtonFormMin;
        private ReaLTaiizor.Controls.HopeButton hopeButtonSettingsScanResult;
        private ReaLTaiizor.Controls.HopeButton hopeButtonSettingsSelectArea;
    }
}