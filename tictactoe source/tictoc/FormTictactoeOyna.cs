using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictoc
{
    public partial class FormTictactoeOyna : Form
    {
        static Thread kasmasorunu;
        bool kasmasorunu_while=true;
        public IPAddress ipi;
        public bool host = false;
        public string kadi = "";
        public string id = "";
        public string katilanadi = "";
        public string hostadi = "";
        int oyuncuSirasi = 1;
        Button[,] btn2 = new Button[3, 3];
        int btn_x = 0;
        int btn_y = 10;
        int btn_w = 100;
        int btn_h = 90;
        bool katilanHazirmi = false;
        //-----eskiolabilir-----//
        int puan1 = 0;
        int puan2 = 0;
        int esayac = 0;
        public string isaret;
        //-----eskiolabilir-----//
        public FormTictactoeOyna()
        {
            InitializeComponent();
        }

        private void FormTictactoeOyna_Load(object sender, EventArgs e)
        {
            ipi = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

            lblKullaniciAdi.Text = kadi;
            //timer1.Start();
            if (host) btnHazir.Text = "Başlat";
            btnHazir.Enabled = false;
            lblKullaniciAdi.Text = kadi;
            lblOyuncuSirasi.Text = "Oyuncu Sırası: " + hostadi;
            Control.CheckForIllegalCrossThreadCalls = false;
            kasmasorunu = new Thread(vd_kasmasorunu);
            kasmasorunu.Start();
            #region btn oluşturma
            int a = 1;
            int btn_x_ivme = btn_w + 10;
            int btn_y_ivme = btn_h + 10;
            for (int i = 0; i < 3; i++)
            {
                btn_x = 30;
                for (int k = 0; k < 3; k++)
                {
                    btn2[i, k] = new Button();
                    btn2[i, k].Size = new Size(btn_w, btn_h);
                    btn2[i, k].Location = new Point(btn_x, btn_y);
                    btn2[i, k].Click += new EventHandler(btnsclick);
                    btn2[i, k].Name = a.ToString();
                    a++;
                    panel1.Controls.Add(btn2[i, k]);
                    btn_x += btn_x_ivme;
                }
                btn_y += btn_y_ivme;
            }
            #endregion
        }
        void vd_kasmasorunu()
        {
            while(kasmasorunu_while)
            {
                string geldi, data1, gelen;
            if (host)
            {
                geldi = mesaj("<hostamesajvarmi>" + id + " " + kadi);
                if (geldi != "")
                {
                    data1 = deger(geldi);//<TC> den ayırır
                    gelen = index(geldi);//<  > ayırır
                    string[] parcalar = data1.Split(' ');
                    if (gelen == "<sira>")
                    {
                        //MessageBox.Show(geldi+"\n"+data1+"\n"+gelen+"\n"+parcalar[0]+" ");
                        #region x yazma
                        if (Convert.ToInt32(data1) > 0 && Convert.ToInt32(data1) < 10)
                        {
                            //MessageBox.Show("a" + data1 + "b");
                            for (int i = 0; i < 3; i++)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    if (btn2[i, k].Name == data1)
                                    {
                                        btn2[i, k].Text = "O";
                                        control();
                                    }
                                }
                            }
                        }
                        #endregion
                        oyuncuSirasi = 1;
                        lblOyuncuSirasi.Text = "Oyuncu Sırası: " + hostadi;
                    }
                    if (gelen == "<hazirim>")
                    {
                        oyuncuSirasi = 1;

                        panel1.Enabled = true;
                        btnHazir.Enabled = true;
                        katilanHazirmi = true;
                    }
                    if (gelen == "<mesaj>")
                    {
                        //MessageBox.Show(geldi + "\n" + data1 + "\n" + gelen + "\n" + parcalar[0] + " ");
                        richTextBox1.Text += katilanadi + ": " + data1 + "\n";
                        if (richTextBox1.Lines.Length > 7)
                        {
                            richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                            richTextBox1.SelectedText = "";
                        }
                    }
                }
            }
            if (!host)
            {
                
                    geldi = mesaj("<katilanamesajvarmi>" + id + " " + kadi);
                    if (geldi != "")
                    {
                        data1 = deger(geldi);//<TC> den ayırır
                        gelen = index(geldi);//<  > ayırır
                        string[] parcalar = data1.Split(' ');

                        //if(data1!="")MessageBox.Show(geldi + "\n" + data1 + "\n" + gelen + "\n" + parcalar[0] + " ");
                        if (gelen == "<sira>")
                        {
                            //MessageBox.Show(geldi+"\n"+data1+"\n"+gelen+"\n"+parcalar[0]+" ");
                            #region x yazma
                            if (Convert.ToInt32(data1) > 0 && Convert.ToInt32(data1) < 10)
                            {
                                //MessageBox.Show("a"+data1+"b");
                                for (int i = 0; i < 3; i++)
                                {
                                    for (int k = 0; k < 3; k++)
                                    {
                                        if (btn2[i, k].Name == data1)
                                        {
                                            btn2[i, k].Text = "X";
                                            control();
                                        }
                                    }
                                }
                            }
                            #endregion
                            oyuncuSirasi = 2;
                            lblOyuncuSirasi.Text = "Oyuncu Sırası: " + kadi;

                        }
                        if (gelen == "<basla>")
                        {
                            oyuncuSirasi = 1;
                            panel1.Enabled = true;
                            btnHazir.Enabled = false;

                        }
                        if (gelen == "<mesaj>")
                        {
                            // MessageBox.Show(geldi + "\n" + data1 + "\n" + gelen + "\n" + parcalar[0] + " ");
                            richTextBox1.Text += hostadi + ": " + data1 + "\n";
                            if (richTextBox1.Lines.Length > 7)
                            {
                                richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                                richTextBox1.SelectedText = "";
                            }
                        }
                    }
                }
                Thread.Sleep(500);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }//mesaj varmı diye servere atar
        void btnsclick(object sender, EventArgs e)
        {
            this.ActiveControl = txtMessage;
            Button btcl = (Button)sender;
            if (oyuncuSirasi == 1 && btcl.Text == "" && host)
            {
                mesaj("<katilanamesaj>" + id + " " + kadi+" "+katilanadi+" "+"<sira>"+" "+btcl.Name);
                btcl.Text = "X";
                oyuncuSirasi = 2;
                lblOyuncuSirasi.Text = "Oyuncu Sırası: " + katilanadi;
                control();
            }
            if (oyuncuSirasi == 2 && btcl.Text == "" && !host)
            {
                mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<sira>" + " " + btcl.Name);
                btcl.Text = "O";
                oyuncuSirasi = 1;
                lblOyuncuSirasi.Text = "Oyuncu Sırası: " + hostadi;
                control();
            }
        }//butonlara tıkladığında çalışacak event
         //-------------ESKİ------------------//
        void o1k()
        {
            puan1++;
            if (puan1 == 3)
            {
                // mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<sira>" + " " + btcl.Name);
                if(host)
                btnHazir.Enabled = false;
                else
                    btnHazir.Enabled = true;
                panel1.Enabled = false;
                MessageBox.Show(hostadi + " OYUNU " + puan1 + " - " + puan2 + " SKOR İLE " + "KAZANDI\nTEBRİKLER...");
                puan1 = 0;
                puan2 = 0;
                lblSkor.Text = "Skor: " + puan1.ToString() + " - " + puan2.ToString();

            }
            else
            {
                lblSkor.Text = "Skor: " + puan1.ToString() + " - " + puan2.ToString();
                MessageBox.Show("oyuncu " + hostadi + " kazandı");
            }
            temizle();

        }
        //oyuncu 2 kazandığında çalışacak function
        void o2k()
        {

            puan2++;
            if (puan2 == 3)
            {
                // mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<sira>" + " " + btcl.Name);
                btnHazir.Enabled = true;
                panel1.Enabled = false;
                if(host)
                    MessageBox.Show(katilanadi + " OYUNU " + puan1 + " - " + puan2 + " SKOR İLE " + "KAZANDI\nTEBRİKLER...");
                else
                MessageBox.Show(kadi + " OYUNU " +puan1+" - "+puan2+" SKOR İLE " + "KAZANDI\nTEBRİKLER...");
                puan1 = 0;
                puan2 = 0;
                lblSkor.Text = "Skor: " + puan1.ToString() + " - " + puan2.ToString();

            }
            else
            {
                lblSkor.Text = "Skor: "+puan1.ToString()+" - " + puan2.ToString();
                if(host)
                MessageBox.Show("oyuncu " + katilanadi + " kazandı");
                else
                    MessageBox.Show("oyuncu " + kadi + " kazandı");
            }
            temizle();

        }
        void control()
        {
            for (int j = 0; j < 2; j++)
            {
                int sayac = 0;
                int sayacyan = 0;
                esayac = 0;
                if (j == 0) isaret = "X";
                if (j == 1) isaret = "O";
                for (int i = 0; i < 3; i++)
                {

                    sayac = 0;
                    sayacyan = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        if (btn2[i, k].Text == isaret)
                        {
                            esayac++;
                            sayac++;
                        }
                        if (btn2[k, i].Text == isaret)
                        {
                            esayac++;
                            sayacyan++;
                        }
                    }
                    if (sayac == 3 || sayacyan == 3)
                    {
                        if (j == 0)
                            o1k();
                        if (j == 1)
                            o2k();
                        break;

                    }
                    if (btn2[0, 0].Text == isaret && btn2[1, 1].Text == isaret && btn2[2, 2].Text == isaret || btn2[0, 2].Text == isaret && btn2[1, 1].Text == isaret && btn2[2, 0].Text == isaret)
                    {

                        if (j == 0)
                            o1k();
                        if (j == 1)
                            o2k();
                        break;
                    }
                }

                //MessageBox.Show(esayac.ToString());
                if (esayac == 10)
                {
                    MessageBox.Show("Kazanan olmadı...");
                    temizle();
                }

            }
        }
        void temizle()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    btn2[i, k].Text = "";
                }
            }
            esayac = 0;
        }
        //-------------ESKİ------------------//
        public string index(string metin)
        {
            string basla = "<";
            string bitir = ">";
            string sonuc;
            try
            {
                int IcerikBaslangicIndex = metin.IndexOf(basla) + basla.Length;
                int IcerikBitisIndex = metin.Substring(IcerikBaslangicIndex).IndexOf(bitir);
                sonuc = metin.Substring(IcerikBaslangicIndex - 1, IcerikBitisIndex + 2);
            }
            catch (Exception)
            {
                sonuc = null;
            }
            return sonuc;
        }//gelen mesajı < ten > ye kadar ayırır
        public string deger(string metin)
        {
            string basla = ">";
            string bitir = " <TC>";
            string sonuc;
            try
            {
                int IcerikBaslangicIndex = metin.IndexOf(basla) + basla.Length;
                int IcerikBitisIndex = metin.Substring(IcerikBaslangicIndex).IndexOf(bitir);
                sonuc = metin.Substring(IcerikBaslangicIndex, IcerikBitisIndex);
            }
            catch (Exception)
            {
                sonuc = null;
            }

            return sonuc;
        }//gelen mesajı > ten <TC> ye kadar ayırır
        private string mesaj(string giden)
        {

            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                // IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPAddress ipAddress =ipi;
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 120);

                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(remoteEP);

                Console.WriteLine("socket {0}",
                    sender.RemoteEndPoint.ToString());

                byte[] msg = Encoding.ASCII.GetBytes(giden + "<TC>");
                int bytesSent = sender.Send(msg);

                int bytesRec = sender.Receive(bytes);
                Console.WriteLine("test = {0}",
                Encoding.ASCII.GetString(bytes, 0, bytesRec));

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            catch
            {
                lblOyuncuSirasi.Text = "Server Hatası Oluştu...";
                return "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            id = "1";
            lblKullaniciAdi.Text = "test katilan";
            kadi = "test";
            katilanadi = "test";
            hostadi = "asd";
            timer1.Start();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            id = "2";
            host = true;
            lblKullaniciAdi.Text = "asd host";
            kadi = "asd";
            katilanadi = "test";
            hostadi = "asd";
            timer1.Start();
            */
            if (host&&katilanHazirmi)
            {
                mesaj("<katilanamesaj>" + id + " " + kadi + " " +katilanadi +" "+ "<basla>");
                katilanHazirmi = false;
                btnHazir.Enabled = false;
            }
            if (!host)
            {
                btnHazir.Enabled = false;
                mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<hazirim>");
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text!="") {
                if (host)
                {
                    mesaj("<katilanamesaj>" + id + " " + kadi + " " +katilanadi +" "+ "<mesaj>" +" " +txtMessage.Text);
                    richTextBox1.Text +=kadi+": "+ txtMessage.Text + "\n";
                    txtMessage.Text = "";
                    if (richTextBox1.Lines.Length > 7)
                    {
                        richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                        richTextBox1.SelectedText = "";
                    }
                }
                if (!host)
                {
                    mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<mesaj>" +" "+ txtMessage.Text);
                    richTextBox1.Text += kadi + ": " + txtMessage.Text + "\n";
                    txtMessage.Text = "";
                    if (richTextBox1.Lines.Length > 7)
                    {
                        richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                        richTextBox1.SelectedText = "";
                    }
                }
            }
            this.ActiveControl = txtMessage;

        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMessage.Text != "")
                {
                    if (host)
                    {
                        mesaj("<katilanamesaj>" + id + " " + kadi + " " + katilanadi + " " + "<mesaj>" + " " + txtMessage.Text);
                        richTextBox1.Text += kadi + ": " + txtMessage.Text + "\n";
                        txtMessage.Text = "";
                        if (richTextBox1.Lines.Length > 7)
                        {
                            richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                            richTextBox1.SelectedText = "";
                        }
                    }
                    if (!host)
                    {
                        mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<mesaj>" + " " + txtMessage.Text);
                        richTextBox1.Text += kadi + ": " + txtMessage.Text + "\n";
                        txtMessage.Text = "";
                        if (richTextBox1.Lines.Length > 7)
                        {
                            richTextBox1.Select(0, richTextBox1.GetFirstCharIndexFromLine(richTextBox1.Lines.Length - 7));
                            richTextBox1.SelectedText = "";
                        }
                    }
                }
                this.ActiveControl = txtMessage;
            }
        }

        private void FormTictactoeOyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            kasmasorunu_while = false;
            kasmasorunu.Abort();
        }
    }
}
