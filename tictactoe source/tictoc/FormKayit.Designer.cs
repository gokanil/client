namespace tictoc
{
    partial class FormKayit
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
            this.components = new System.ComponentModel.Container();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.lblKadi = new System.Windows.Forms.Label();
            this.txtSifreOnay = new System.Windows.Forms.TextBox();
            this.lblSifreOnay = new System.Windows.Forms.Label();
            this.btnkayit = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGeriDon = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(98, 30);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 13;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(7, 33);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 17);
            this.lblSifre.TabIndex = 12;
            this.lblSifre.Text = "Şifre:*";
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(98, 2);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 22);
            this.txtKadi.TabIndex = 11;
            // 
            // lblKadi
            // 
            this.lblKadi.AutoSize = true;
            this.lblKadi.Location = new System.Drawing.Point(4, 5);
            this.lblKadi.Name = "lblKadi";
            this.lblKadi.Size = new System.Drawing.Size(93, 17);
            this.lblKadi.TabIndex = 10;
            this.lblKadi.Text = "Kullanıcı Adı:*";
            // 
            // txtSifreOnay
            // 
            this.txtSifreOnay.Location = new System.Drawing.Point(98, 58);
            this.txtSifreOnay.Name = "txtSifreOnay";
            this.txtSifreOnay.Size = new System.Drawing.Size(100, 22);
            this.txtSifreOnay.TabIndex = 15;
            // 
            // lblSifreOnay
            // 
            this.lblSifreOnay.AutoSize = true;
            this.lblSifreOnay.Location = new System.Drawing.Point(7, 61);
            this.lblSifreOnay.Name = "lblSifreOnay";
            this.lblSifreOnay.Size = new System.Drawing.Size(84, 17);
            this.lblSifreOnay.TabIndex = 14;
            this.lblSifreOnay.Text = "Şifre Onay:*";
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(98, 128);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(100, 40);
            this.btnkayit.TabIndex = 17;
            this.btnkayit.Text = "Kayıt Ol";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(7, 110);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(37, 17);
            this.lblDurum.TabIndex = 16;
            this.lblDurum.Text = "NAN";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblGeriDon
            // 
            this.lblGeriDon.AutoSize = true;
            this.lblGeriDon.Location = new System.Drawing.Point(7, 140);
            this.lblGeriDon.Name = "lblGeriDon";
            this.lblGeriDon.Size = new System.Drawing.Size(65, 17);
            this.lblGeriDon.TabIndex = 20;
            this.lblGeriDon.TabStop = true;
            this.lblGeriDon.Text = "Geri Dön";
            this.lblGeriDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGeriDon_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(203, 173);
            this.Controls.Add(this.lblGeriDon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.txtSifreOnay);
            this.Controls.Add(this.lblSifreOnay);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.lblKadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKayit";
            this.Text = "FormKayit";
            this.Load += new System.EventHandler(this.FormKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label lblKadi;
        private System.Windows.Forms.TextBox txtSifreOnay;
        private System.Windows.Forms.Label lblSifreOnay;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.LinkLabel lblGeriDon;
        private System.Windows.Forms.Timer timer1;
    }
}