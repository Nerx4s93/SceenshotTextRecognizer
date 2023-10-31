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
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.button_Cansel = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(12, 12);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(454, 47);
            this.progressBarStatus.TabIndex = 0;
            // 
            // button_Cansel
            // 
            this.button_Cansel.AutoSize = true;
            this.button_Cansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Cansel.Location = new System.Drawing.Point(388, 66);
            this.button_Cansel.Name = "button_Cansel";
            this.button_Cansel.Size = new System.Drawing.Size(78, 30);
            this.button_Cansel.TabIndex = 1;
            this.button_Cansel.Text = "Отмена";
            this.button_Cansel.UseVisualStyleBackColor = true;
            this.button_Cansel.Click += new System.EventHandler(this.button_Cansel_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(12, 71);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(89, 25);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Loading";
            // 
            // DownloadModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 101);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.button_Cansel);
            this.Controls.Add(this.progressBarStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DownloadModel";
            this.Text = "Загрузка языковой модели \"модель\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadModel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Button button_Cansel;
        private System.Windows.Forms.Label labelStatus;
    }
}