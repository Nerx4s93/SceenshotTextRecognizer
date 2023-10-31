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
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSelectModels = new System.Windows.Forms.ListView();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textBoxSelected = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Location = new System.Drawing.Point(16, 32);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(153, 26);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // listViewSelectModels
            // 
            this.listViewSelectModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSelectModels.HideSelection = false;
            this.listViewSelectModels.Location = new System.Drawing.Point(17, 64);
            this.listViewSelectModels.Name = "listViewSelectModels";
            this.listViewSelectModels.Size = new System.Drawing.Size(311, 295);
            this.listViewSelectModels.TabIndex = 2;
            this.listViewSelectModels.UseCompatibleStateImageBehavior = false;
            this.listViewSelectModels.View = System.Windows.Forms.View.SmallIcon;
            this.listViewSelectModels.DoubleClick += new System.EventHandler(this.listViewSelectModels_DoubleClick);
            // 
            // buttonScan
            // 
            this.buttonScan.AutoSize = true;
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScan.Location = new System.Drawing.Point(211, 365);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(119, 30);
            this.buttonScan.TabIndex = 3;
            this.buttonScan.Text = "Сканировать";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textBoxSelected
            // 
            this.textBoxSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelected.Location = new System.Drawing.Point(175, 32);
            this.textBoxSelected.Name = "textBoxSelected";
            this.textBoxSelected.ReadOnly = true;
            this.textBoxSelected.Size = new System.Drawing.Size(153, 26);
            this.textBoxSelected.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбрано";
            // 
            // ScanSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSelected);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.listViewSelectModels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScanSettings";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSelectModels;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.TextBox textBoxSelected;
        private System.Windows.Forms.Label label2;
    }
}