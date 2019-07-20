namespace tictoc
{
    partial class FormTictactoeOyna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTictactoeOyna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHazir = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblOyuncuSirasi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 423);
            this.panel1.TabIndex = 0;
            // 
            // btnHazir
            // 
            this.btnHazir.Location = new System.Drawing.Point(647, 70);
            this.btnHazir.Name = "btnHazir";
            this.btnHazir.Size = new System.Drawing.Size(113, 47);
            this.btnHazir.TabIndex = 1;
            this.btnHazir.Text = "Hazır";
            this.btnHazir.UseVisualStyleBackColor = true;
            this.btnHazir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(522, 70);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(113, 47);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(519, 31);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(74, 17);
            this.lblSkor.TabIndex = 3;
            this.lblSkor.Text = "Skor: 0 - 0";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(519, 9);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(37, 17);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "NAN";
            // 
            // lblOyuncuSirasi
            // 
            this.lblOyuncuSirasi.AutoSize = true;
            this.lblOyuncuSirasi.Location = new System.Drawing.Point(124, 8);
            this.lblOyuncuSirasi.Name = "lblOyuncuSirasi";
            this.lblOyuncuSirasi.Size = new System.Drawing.Size(133, 17);
            this.lblOyuncuSirasi.TabIndex = 5;
            this.lblOyuncuSirasi.Text = "Oyuncu Sırası: NAN";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(522, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 303);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(519, 432);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(168, 22);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(693, 432);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(78, 22);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FormTictactoeOyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblOyuncuSirasi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnHazir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTictactoeOyna";
            this.Text = "TicTacToe @ByApply";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTictactoeOyna_FormClosing);
            this.Load += new System.EventHandler(this.FormTictactoeOyna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHazir;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblOyuncuSirasi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnGonder;
    }
}