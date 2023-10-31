namespace SceenshotTextRecognizer.GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Bind = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxWorkInFon = new System.Windows.Forms.CheckBox();
            this.checkBoxShowOnOtherForms = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageLanguages = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Download = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Delete = new System.Windows.Forms.ListView();
            this.tabPageCombinate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditCombination = new System.Windows.Forms.Button();
            this.buttonDeleteCombination = new System.Windows.Forms.Button();
            this.buttonNewCombination = new System.Windows.Forms.Button();
            this.listViewCombinationLanguagePacks = new System.Windows.Forms.ListView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFormMin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageLanguages.SuspendLayout();
            this.tabPageCombinate.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Bind
            // 
            this.textBox_Bind.BackColor = System.Drawing.Color.White;
            this.textBox_Bind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Bind.Location = new System.Drawing.Point(6, 26);
            this.textBox_Bind.Name = "textBox_Bind";
            this.textBox_Bind.ReadOnly = true;
            this.textBox_Bind.Size = new System.Drawing.Size(446, 26);
            this.textBox_Bind.TabIndex = 0;
            this.textBox_Bind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Bind_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageLanguages);
            this.tabControl1.Controls.Add(this.tabPageCombinate);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 341);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Controls.Add(this.checkBoxWorkInFon);
            this.tabPageSettings.Controls.Add(this.checkBoxShowOnOtherForms);
            this.tabPageSettings.Controls.Add(this.label4);
            this.tabPageSettings.Controls.Add(this.textBox_Bind);
            this.tabPageSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageSettings.Location = new System.Drawing.Point(4, 24);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(462, 313);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Настройки";
            // 
            // checkBoxWorkInFon
            // 
            this.checkBoxWorkInFon.AutoSize = true;
            this.checkBoxWorkInFon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWorkInFon.Location = new System.Drawing.Point(8, 88);
            this.checkBoxWorkInFon.Name = "checkBoxWorkInFon";
            this.checkBoxWorkInFon.Size = new System.Drawing.Size(233, 24);
            this.checkBoxWorkInFon.TabIndex = 3;
            this.checkBoxWorkInFon.Text = "Работа в фоновом режиме";
            this.checkBoxWorkInFon.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowOnOtherForms
            // 
            this.checkBoxShowOnOtherForms.AutoSize = true;
            this.checkBoxShowOnOtherForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowOnOtherForms.Location = new System.Drawing.Point(8, 58);
            this.checkBoxShowOnOtherForms.Name = "checkBoxShowOnOtherForms";
            this.checkBoxShowOnOtherForms.Size = new System.Drawing.Size(270, 24);
            this.checkBoxShowOnOtherForms.TabIndex = 2;
            this.checkBoxShowOnOtherForms.Text = "Показывать поверхдругих  окон";
            this.checkBoxShowOnOtherForms.UseVisualStyleBackColor = true;
            this.checkBoxShowOnOtherForms.CheckedChanged += new System.EventHandler(this.checkBoxShowOnOtherForms_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Клавиша сканирования";
            // 
            // tabPageLanguages
            // 
            this.tabPageLanguages.BackColor = System.Drawing.Color.White;
            this.tabPageLanguages.Controls.Add(this.label3);
            this.tabPageLanguages.Controls.Add(this.listView_Download);
            this.tabPageLanguages.Controls.Add(this.label2);
            this.tabPageLanguages.Controls.Add(this.listView_Delete);
            this.tabPageLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageLanguages.Location = new System.Drawing.Point(4, 24);
            this.tabPageLanguages.Name = "tabPageLanguages";
            this.tabPageLanguages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLanguages.Size = new System.Drawing.Size(462, 313);
            this.tabPageLanguages.TabIndex = 1;
            this.tabPageLanguages.Text = "Языковые модели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Удалить";
            // 
            // listView_Download
            // 
            this.listView_Download.BackColor = System.Drawing.Color.White;
            this.listView_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Download.HideSelection = false;
            this.listView_Download.Location = new System.Drawing.Point(237, 31);
            this.listView_Download.Name = "listView_Download";
            this.listView_Download.Size = new System.Drawing.Size(220, 278);
            this.listView_Download.TabIndex = 4;
            this.listView_Download.UseCompatibleStateImageBehavior = false;
            this.listView_Download.View = System.Windows.Forms.View.List;
            this.listView_Download.DoubleClick += new System.EventHandler(this.listView_Download_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скачать";
            // 
            // listView_Delete
            // 
            this.listView_Delete.BackColor = System.Drawing.Color.White;
            this.listView_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Delete.HideSelection = false;
            this.listView_Delete.Location = new System.Drawing.Point(6, 31);
            this.listView_Delete.Name = "listView_Delete";
            this.listView_Delete.Size = new System.Drawing.Size(220, 278);
            this.listView_Delete.TabIndex = 2;
            this.listView_Delete.UseCompatibleStateImageBehavior = false;
            this.listView_Delete.View = System.Windows.Forms.View.List;
            this.listView_Delete.DoubleClick += new System.EventHandler(this.listView_Delete_DoubleClick);
            // 
            // tabPageCombinate
            // 
            this.tabPageCombinate.BackColor = System.Drawing.Color.White;
            this.tabPageCombinate.Controls.Add(this.label1);
            this.tabPageCombinate.Controls.Add(this.buttonEditCombination);
            this.tabPageCombinate.Controls.Add(this.buttonDeleteCombination);
            this.tabPageCombinate.Controls.Add(this.buttonNewCombination);
            this.tabPageCombinate.Controls.Add(this.listViewCombinationLanguagePacks);
            this.tabPageCombinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCombinate.Location = new System.Drawing.Point(4, 24);
            this.tabPageCombinate.Name = "tabPageCombinate";
            this.tabPageCombinate.Size = new System.Drawing.Size(462, 313);
            this.tabPageCombinate.TabIndex = 2;
            this.tabPageCombinate.Text = "Комбинация языковых моделей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Комбинация языковых моделей";
            // 
            // buttonEditCombination
            // 
            this.buttonEditCombination.AutoSize = true;
            this.buttonEditCombination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCombination.Location = new System.Drawing.Point(95, 278);
            this.buttonEditCombination.Name = "buttonEditCombination";
            this.buttonEditCombination.Size = new System.Drawing.Size(138, 30);
            this.buttonEditCombination.TabIndex = 3;
            this.buttonEditCombination.Text = "Редактировать";
            this.buttonEditCombination.UseVisualStyleBackColor = true;
            this.buttonEditCombination.Visible = false;
            this.buttonEditCombination.Click += new System.EventHandler(this.buttonEditCombination_Click);
            // 
            // buttonDeleteCombination
            // 
            this.buttonDeleteCombination.AutoSize = true;
            this.buttonDeleteCombination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCombination.Location = new System.Drawing.Point(3, 278);
            this.buttonDeleteCombination.Name = "buttonDeleteCombination";
            this.buttonDeleteCombination.Size = new System.Drawing.Size(86, 30);
            this.buttonDeleteCombination.TabIndex = 2;
            this.buttonDeleteCombination.Text = "Удалить";
            this.buttonDeleteCombination.UseVisualStyleBackColor = true;
            this.buttonDeleteCombination.Visible = false;
            this.buttonDeleteCombination.Click += new System.EventHandler(this.buttonDeleteCombination_Click);
            // 
            // buttonNewCombination
            // 
            this.buttonNewCombination.AutoSize = true;
            this.buttonNewCombination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewCombination.Location = new System.Drawing.Point(292, 278);
            this.buttonNewCombination.Name = "buttonNewCombination";
            this.buttonNewCombination.Size = new System.Drawing.Size(162, 30);
            this.buttonNewCombination.TabIndex = 1;
            this.buttonNewCombination.Text = "Новая комбинация";
            this.buttonNewCombination.UseVisualStyleBackColor = true;
            this.buttonNewCombination.Click += new System.EventHandler(this.buttonNewCombination_Click);
            // 
            // listViewCombinationLanguagePacks
            // 
            this.listViewCombinationLanguagePacks.BackColor = System.Drawing.Color.White;
            this.listViewCombinationLanguagePacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCombinationLanguagePacks.HideSelection = false;
            this.listViewCombinationLanguagePacks.Location = new System.Drawing.Point(3, 28);
            this.listViewCombinationLanguagePacks.Name = "listViewCombinationLanguagePacks";
            this.listViewCombinationLanguagePacks.Size = new System.Drawing.Size(457, 245);
            this.listViewCombinationLanguagePacks.TabIndex = 0;
            this.listViewCombinationLanguagePacks.UseCompatibleStateImageBehavior = false;
            this.listViewCombinationLanguagePacks.View = System.Windows.Forms.View.SmallIcon;
            this.listViewCombinationLanguagePacks.SelectedIndexChanged += new System.EventHandler(this.listViewCombinationLanguagePacks_SelectedIndexChanged);
            this.listViewCombinationLanguagePacks.DoubleClick += new System.EventHandler(this.listViewCombinationLanguagePacks_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(446, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(21, 21);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFormMin
            // 
            this.buttonFormMin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFormMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormMin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFormMin.Location = new System.Drawing.Point(420, 0);
            this.buttonFormMin.Name = "buttonFormMin";
            this.buttonFormMin.Size = new System.Drawing.Size(21, 21);
            this.buttonFormMin.TabIndex = 4;
            this.buttonFormMin.UseVisualStyleBackColor = false;
            this.buttonFormMin.Click += new System.EventHandler(this.buttonFormMin_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 339);
            this.Controls.Add(this.buttonFormMin);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "ScreenshotTextRecognizer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageLanguages.ResumeLayout(false);
            this.tabPageLanguages.PerformLayout();
            this.tabPageCombinate.ResumeLayout(false);
            this.tabPageCombinate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Bind;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_Download;
        private System.Windows.Forms.TabPage tabPageCombinate;
        private System.Windows.Forms.Button buttonNewCombination;
        private System.Windows.Forms.ListView listViewCombinationLanguagePacks;
        private System.Windows.Forms.Button buttonEditCombination;
        private System.Windows.Forms.Button buttonDeleteCombination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFormMin;
        private System.Windows.Forms.CheckBox checkBoxShowOnOtherForms;
        private System.Windows.Forms.CheckBox checkBoxWorkInFon;
    }
}

