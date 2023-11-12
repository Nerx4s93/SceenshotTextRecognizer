namespace SceenshotTextRecognizer.GUI.MessageBoxes
{
    partial class EditCombinationLanguagePack
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
            this.label1 = new System.Windows.Forms.Label();
            this.hopeTextBoxName = new ReaLTaiizor.Controls.HopeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.crownListViewUseModels = new ReaLTaiizor.Controls.CrownListView();
            this.label3 = new System.Windows.Forms.Label();
            this.crownListViewDontUseModels = new ReaLTaiizor.Controls.CrownListView();
            this.hopeButtonSave = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonAdd = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButtonRemove = new ReaLTaiizor.Controls.HopeButton();
            this.SuspendLayout();
            // 
            // hopeForm
            // 
            this.hopeForm.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm.Image = null;
            this.hopeForm.Location = new System.Drawing.Point(0, 0);
            this.hopeForm.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.hopeForm.Name = "hopeForm";
            this.hopeForm.Size = new System.Drawing.Size(535, 40);
            this.hopeForm.TabIndex = 0;
            this.hopeForm.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // hopeTextBoxName
            // 
            this.hopeTextBoxName.BackColor = System.Drawing.Color.White;
            this.hopeTextBoxName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBoxName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBoxName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBoxName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBoxName.Hint = "";
            this.hopeTextBoxName.Location = new System.Drawing.Point(75, 47);
            this.hopeTextBoxName.MaxLength = 32767;
            this.hopeTextBoxName.Multiline = false;
            this.hopeTextBoxName.Name = "hopeTextBoxName";
            this.hopeTextBoxName.PasswordChar = '\0';
            this.hopeTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBoxName.SelectedText = "";
            this.hopeTextBoxName.SelectionLength = 0;
            this.hopeTextBoxName.SelectionStart = 0;
            this.hopeTextBoxName.Size = new System.Drawing.Size(455, 38);
            this.hopeTextBoxName.TabIndex = 2;
            this.hopeTextBoxName.TabStop = false;
            this.hopeTextBoxName.UseSystemPasswordChar = false;
            this.hopeTextBoxName.TextChanged += new System.EventHandler(this.hopeTextBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбранные:";
            // 
            // crownListViewUseModels
            // 
            this.crownListViewUseModels.Location = new System.Drawing.Point(19, 121);
            this.crownListViewUseModels.Name = "crownListViewUseModels";
            this.crownListViewUseModels.Size = new System.Drawing.Size(249, 155);
            this.crownListViewUseModels.TabIndex = 4;
            this.crownListViewUseModels.Text = "crownListView1";
            this.crownListViewUseModels.SelectedIndicesChanged += new System.EventHandler(this.crownListViewUseModels_SelectedIndicesChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выбрать:";
            // 
            // crownListViewDontUseModels
            // 
            this.crownListViewDontUseModels.Location = new System.Drawing.Point(281, 121);
            this.crownListViewDontUseModels.Name = "crownListViewDontUseModels";
            this.crownListViewDontUseModels.Size = new System.Drawing.Size(249, 155);
            this.crownListViewDontUseModels.TabIndex = 6;
            this.crownListViewDontUseModels.Text = "crownListView2";
            this.crownListViewDontUseModels.SelectedIndicesChanged += new System.EventHandler(this.crownListViewDontUseModels_SelectedIndicesChanged);
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
            this.hopeButtonSave.Location = new System.Drawing.Point(410, 282);
            this.hopeButtonSave.Name = "hopeButtonSave";
            this.hopeButtonSave.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonSave.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonSave.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonSave.TabIndex = 7;
            this.hopeButtonSave.Text = "Сохранить";
            this.hopeButtonSave.TextColor = System.Drawing.Color.White;
            this.hopeButtonSave.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonSave.Click += new System.EventHandler(this.hopeButtonSave_Click);
            // 
            // hopeButtonAdd
            // 
            this.hopeButtonAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonAdd.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonAdd.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonAdd.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonAdd.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonAdd.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonAdd.Location = new System.Drawing.Point(281, 282);
            this.hopeButtonAdd.Name = "hopeButtonAdd";
            this.hopeButtonAdd.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonAdd.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonAdd.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonAdd.TabIndex = 8;
            this.hopeButtonAdd.Text = "Добавить";
            this.hopeButtonAdd.TextColor = System.Drawing.Color.White;
            this.hopeButtonAdd.Visible = false;
            this.hopeButtonAdd.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonAdd.Click += new System.EventHandler(this.hopeButtonAdd_Click);
            // 
            // hopeButtonRemove
            // 
            this.hopeButtonRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButtonRemove.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButtonRemove.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButtonRemove.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButtonRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeButtonRemove.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButtonRemove.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButtonRemove.Location = new System.Drawing.Point(19, 282);
            this.hopeButtonRemove.Name = "hopeButtonRemove";
            this.hopeButtonRemove.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeButtonRemove.Size = new System.Drawing.Size(120, 40);
            this.hopeButtonRemove.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButtonRemove.TabIndex = 9;
            this.hopeButtonRemove.Text = "Убрать";
            this.hopeButtonRemove.TextColor = System.Drawing.Color.White;
            this.hopeButtonRemove.Visible = false;
            this.hopeButtonRemove.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButtonRemove.Click += new System.EventHandler(this.hopeButtonRemove_Click);
            // 
            // EditCombinationLanguagePack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 325);
            this.Controls.Add(this.hopeButtonRemove);
            this.Controls.Add(this.hopeButtonAdd);
            this.Controls.Add(this.hopeButtonSave);
            this.Controls.Add(this.crownListViewDontUseModels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crownListViewUseModels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hopeTextBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hopeForm);
            this.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximumSize = new System.Drawing.Size(3840, 2400);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "EditCombinationLanguagePack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCombinationLanguagePack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxName;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.CrownListView crownListViewUseModels;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.CrownListView crownListViewDontUseModels;
        private ReaLTaiizor.Controls.HopeButton hopeButtonSave;
        private ReaLTaiizor.Controls.HopeButton hopeButtonAdd;
        private ReaLTaiizor.Controls.HopeButton hopeButtonRemove;
    }
}