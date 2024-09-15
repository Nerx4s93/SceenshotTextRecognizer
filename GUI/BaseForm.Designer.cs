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
            this.ButtonMinimized = new SceenshotTextRecognizer.UI.ImageButton();
            this.ButtonClose = new SceenshotTextRecognizer.UI.ImageButton();
            this.Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.ControlBox = false;
            this.Title.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.Title.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.Title.ControlBoxColorN = System.Drawing.Color.White;
            this.Title.Controls.Add(this.ButtonMinimized);
            this.Title.Controls.Add(this.ButtonClose);
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
            // ButtonMinimized
            // 
            this.ButtonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimized.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.min;
            this.ButtonMinimized.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.min2;
            this.ButtonMinimized.Location = new System.Drawing.Point(573, 8);
            this.ButtonMinimized.Name = "ButtonMinimized";
            this.ButtonMinimized.Size = new System.Drawing.Size(24, 24);
            this.ButtonMinimized.TabIndex = 6;
            this.ButtonMinimized.Text = "imageButton1";
            this.ButtonMinimized.UseVisualStyleBackColor = true;
            this.ButtonMinimized.Click += new System.EventHandler(this.ButtonMinimized_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.ImageDeffault = global::SceenshotTextRecognizer.Properties.Resources.close;
            this.ButtonClose.ImageOnMouseEnter = global::SceenshotTextRecognizer.Properties.Resources.close2;
            this.ButtonClose.Location = new System.Drawing.Point(597, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(24, 24);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "imageButton1";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
        private UI.ImageButton ButtonMinimized;
        private UI.ImageButton ButtonClose;
    }
}