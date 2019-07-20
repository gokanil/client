namespace tictoc
{
    partial class FormOdalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdalar));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKatil = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKullanici = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdaKur = new System.Windows.Forms.Button();
            this.lblMaxOyuncu = new System.Windows.Forms.Label();
            this.lblOyuncuSayisi = new System.Windows.Forms.Label();
            this.txtOdaSifre = new System.Windows.Forms.TextBox();
            this.lblOdaSifre = new System.Windows.Forms.Label();
            this.txtOdaIsmi = new System.Windows.Forms.TextBox();
            this.lblOdaIsmi = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 221);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda No";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda İsmi";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oyuncular";
            this.columnHeader3.Width = 72;
            // 
            // btnKatil
            // 
            this.btnKatil.Location = new System.Drawing.Point(443, 157);
            this.btnKatil.Name = "btnKatil";
            this.btnKatil.Size = new System.Drawing.Size(100, 50);
            this.btnKatil.TabIndex = 2;
            this.btnKatil.Text = "Katıl";
            this.btnKatil.UseVisualStyleBackColor = true;
            this.btnKatil.Click += new System.EventHandler(this.btnKatil_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(434, 11);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(37, 17);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "NAN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOdaKur);
            this.panel1.Controls.Add(this.lblMaxOyuncu);
            this.panel1.Controls.Add(this.lblOyuncuSayisi);
            this.panel1.Controls.Add(this.txtOdaSifre);
            this.panel1.Controls.Add(this.lblOdaSifre);
            this.panel1.Controls.Add(this.txtOdaIsmi);
            this.panel1.Controls.Add(this.lblOdaIsmi);
            this.panel1.Location = new System.Drawing.Point(341, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 126);
            this.panel1.TabIndex = 4;
            // 
            // btnOdaKur
            // 
            this.btnOdaKur.Location = new System.Drawing.Point(121, 83);
            this.btnOdaKur.Name = "btnOdaKur";
            this.btnOdaKur.Size = new System.Drawing.Size(75, 35);
            this.btnOdaKur.TabIndex = 13;
            this.btnOdaKur.Text = "Oda Kur";
            this.btnOdaKur.UseVisualStyleBackColor = true;
            this.btnOdaKur.Click += new System.EventHandler(this.btnOdaKur_Click);
            // 
            // lblMaxOyuncu
            // 
            this.lblMaxOyuncu.AutoSize = true;
            this.lblMaxOyuncu.Location = new System.Drawing.Point(111, 67);
            this.lblMaxOyuncu.Name = "lblMaxOyuncu";
            this.lblMaxOyuncu.Size = new System.Drawing.Size(51, 17);
            this.lblMaxOyuncu.TabIndex = 12;
            this.lblMaxOyuncu.Text = "2(Max)";
            // 
            // lblOyuncuSayisi
            // 
            this.lblOyuncuSayisi.AutoSize = true;
            this.lblOyuncuSayisi.Location = new System.Drawing.Point(3, 67);
            this.lblOyuncuSayisi.Name = "lblOyuncuSayisi";
            this.lblOyuncuSayisi.Size = new System.Drawing.Size(102, 17);
            this.lblOyuncuSayisi.TabIndex = 11;
            this.lblOyuncuSayisi.Text = "Oyuncu Sayısı:";
            // 
            // txtOdaSifre
            // 
            this.txtOdaSifre.Enabled = false;
            this.txtOdaSifre.Location = new System.Drawing.Point(96, 34);
            this.txtOdaSifre.Name = "txtOdaSifre";
            this.txtOdaSifre.Size = new System.Drawing.Size(100, 22);
            this.txtOdaSifre.TabIndex = 10;
            // 
            // lblOdaSifre
            // 
            this.lblOdaSifre.AutoSize = true;
            this.lblOdaSifre.Location = new System.Drawing.Point(3, 37);
            this.lblOdaSifre.Name = "lblOdaSifre";
            this.lblOdaSifre.Size = new System.Drawing.Size(82, 17);
            this.lblOdaSifre.TabIndex = 9;
            this.lblOdaSifre.Text = "Oda Şifresi:";
            // 
            // txtOdaIsmi
            // 
            this.txtOdaIsmi.Enabled = false;
            this.txtOdaIsmi.Location = new System.Drawing.Point(96, 2);
            this.txtOdaIsmi.Name = "txtOdaIsmi";
            this.txtOdaIsmi.Size = new System.Drawing.Size(100, 22);
            this.txtOdaIsmi.TabIndex = 8;
            // 
            // lblOdaIsmi
            // 
            this.lblOdaIsmi.AutoSize = true;
            this.lblOdaIsmi.Location = new System.Drawing.Point(3, 5);
            this.lblOdaIsmi.Name = "lblOdaIsmi";
            this.lblOdaIsmi.Size = new System.Drawing.Size(67, 17);
            this.lblOdaIsmi.TabIndex = 7;
            this.lblOdaIsmi.Text = "Oda İsmi:";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(341, 157);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(100, 50);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // FormOdalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 237);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnKatil);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOdalar";
            this.Text = "TicToc @ByAplly";
            this.Load += new System.EventHandler(this.FormOdalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKatil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdaKur;
        private System.Windows.Forms.Label lblMaxOyuncu;
        private System.Windows.Forms.Label lblOyuncuSayisi;
        private System.Windows.Forms.TextBox txtOdaSifre;
        private System.Windows.Forms.Label lblOdaSifre;
        private System.Windows.Forms.TextBox txtOdaIsmi;
        private System.Windows.Forms.Label lblOdaIsmi;
        private System.Windows.Forms.Button btnYenile;
    }
}