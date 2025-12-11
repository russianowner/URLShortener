namespace URLShortener
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLongUrl;
        private System.Windows.Forms.Button btnShorten;
        private System.Windows.Forms.TextBox txtShortUrl;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListBox lstHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLongUrl = new System.Windows.Forms.TextBox();
            this.btnShorten = new System.Windows.Forms.Button();
            this.txtShortUrl = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // Label
            this.label1.Text = "Введите URL:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;
            // txtLongUrl
            this.txtLongUrl.Location = new System.Drawing.Point(20, 45);
            this.txtLongUrl.Width = 400;
            // btnShorten
            this.btnShorten.Text = "Сократить";
            this.btnShorten.Location = new System.Drawing.Point(430, 43);
            this.btnShorten.Click += new System.EventHandler(this.btnShorten_Click);
            // txtShortUrl
            this.txtShortUrl.Location = new System.Drawing.Point(20, 80);
            this.txtShortUrl.Width = 400;
            this.txtShortUrl.ReadOnly = true;
            // btnCopy
            this.btnCopy.Text = "Копировать";
            this.btnCopy.Location = new System.Drawing.Point(430, 78);
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // lstHistory
            this.lstHistory.Location = new System.Drawing.Point(20, 120);
            this.lstHistory.Width = 510;
            this.lstHistory.Height = 200;
            // Form
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLongUrl);
            this.Controls.Add(this.btnShorten);
            this.Controls.Add(this.txtShortUrl);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lstHistory);
            this.Text = "URL Shortener";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
