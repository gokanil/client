namespace tictoc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.pnlResim = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 245);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(389, 245);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://ceksin.ddns.net/news.html", System.UriKind.Absolute);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBaglanti);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(5, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 61);
            this.panel2.TabIndex = 1;
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Location = new System.Drawing.Point(6, 39);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(37, 17);
            this.lblBaglanti.TabIndex = 1;
            this.lblBaglanti.Text = "NAN";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 33);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKullanici.Location = new System.Drawing.Point(400, 191);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(201, 126);
            this.pnlKullanici.TabIndex = 3;
            // 
            // pnlResim
            // 
            this.pnlResim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlResim.BackgroundImage")));
            this.pnlResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlResim.Location = new System.Drawing.Point(400, 5);
            this.pnlResim.Name = "pnlResim";
            this.pnlResim.Size = new System.Drawing.Size(201, 180);
            this.pnlResim.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 323);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.pnlResim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TicToc @ByAplly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlResim;
        private System.Windows.Forms.Panel pnlKullanici;
        public System.Windows.Forms.Label lblBaglanti;
    }
}

