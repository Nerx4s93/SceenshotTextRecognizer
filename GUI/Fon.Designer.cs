namespace SceenshotTextRecognizer.GUI
{
    partial class Fon
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
            this.SuspendLayout();
            // 
            // Fon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fon";
            this.ShowInTaskbar = false;
            this.Text = "Fon";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Fon_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fon_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fon_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}