namespace SceenshotTextRecognizer.GUI
{
    partial class BaseForm
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
            this.Title = new ReaLTaiizor.Forms.HopeForm();
            this.imageButtonFormMin = new SceenshotTextRecognizer.UI.ImageButton();
            this.imageButtonClose = new SceenshotTextRecognizer.UI.ImageButton();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.ControlBox = false;
            this.Title.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.Title.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Title.ControlBoxColorN = System.Drawing.Color.White;
            this.Title.Controls.Add(this.imageButtonFormMin);
            this.Title.Controls.Add(this.imageButtonClose);
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Title.Image = null;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(630, 40);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            this.Title.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // imageButtonFormMin
            // 
            this.imageButtonFormMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonFormMin.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.min;
            this.imageButtonFormMin.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.min2;
            this.imageButtonFormMin.Location = new System.Drawing.Point(573, 8);
            this.imageButtonFormMin.Name = "imageButtonFormMin";
            this.imageButtonFormMin.Size = new System.Drawing.Size(24, 24);
            this.imageButtonFormMin.TabIndex = 6;
            this.imageButtonFormMin.Text = "imageButton1";
            this.imageButtonFormMin.UseVisualStyleBackColor = true;
            // 
            // imageButtonClose
            // 
            this.imageButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.imageButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.imageButtonClose.Location = new System.Drawing.Point(597, 8);
            this.imageButtonClose.Name = "imageButtonClose";
            this.imageButtonClose.Size = new System.Drawing.Size(24, 24);
            this.imageButtonClose.TabIndex = 5;
            this.imageButtonClose.Text = "imageButton1";
            this.imageButtonClose.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.ControlBox = false;
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm Title;
        private UI.ImageButton imageButtonFormMin;
        private UI.ImageButton imageButtonClose;
    }
}