using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using MySql.Data.MySqlClient;

namespace tictoc
{
    public partial class FormOdalar : Form
    {
        public IPAddress ipi;
        int bekeleme = 0;

       
        FormGiris frmGiris = new FormGiris();
        Form1 frm1 = new Form1();
        public string kadi="";
        public string id = "";
        bool host = false;
        string katilanadi = "";
        string hostadi = "";
        public FormOdalar()
        {
            InitializeComponent();
        }

        private void FormOdalar_Load(object sender, EventArgs e)
        {
            ipi = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

            timer1.Start();
            lblKullanici.Text = kadi;
            txtOdaIsmi.Text = lblKullanici.Text + "Odası";

            vdOdalariListele();

        }
       private string mesaj(string giden)
        {

            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                
                IPAddress ipAddress = ipi;
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
                lblKullanici.Text = "Server Hatası Oluştu...";
                return "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // try
            // {
            string geldi, data1, gelen;
                if (bekeleme==0) //odakur butonuna basılmadığında çalışır varsayılan false
                {
                    mesaj("<online>" + id + " " + kadi);
                    timer1.Interval = 2000;
                }
                //----------HOST-----------------//
                if (bekeleme == 1) //oda kur tuşuna basıldığında çalışır oyuncu bekler
                {
                     geldi = mesaj("<hostamesajvarmi>" + id + " " + kadi+" "+ listView1.Items.Count.ToString()+"/2");
                if (geldi != "")
                {
                     data1 = deger(geldi);//<TC> den ayırır
                     gelen = index(geldi);//<  > ayırır
                    string[] parcalar = data1.Split(' ');
                    
                    if (gelen == "<ekle>")//katıl tuşuna basan kişiyi ekler
                    {
                        ListViewItem item1 = listView1.FindItemWithText(kadi);
                        listView1.Items[listView1.Items.IndexOf(item1)].SubItems[1].Text = "2/2";

                        string[] row = { parcalar[0],"2/2","Hazir Değil"};
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                         katilanadi = parcalar[0];
                    }
                    //MessageBox.Show(gelen);
                    if (gelen == "<cikar>")//katıl tuşuna basan kişiyi ekler
                    {
                        listView1.Items.Clear();
                        string[] row = { kadi, "1/2", "Host" };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                        katilanadi = "";
                        btnKatil.Enabled = false;
                    }
                    if (gelen == "<hazirim>")//katıl tuşuna basan kişiyi ekler
                    {
                        //MessageBox.Show(geldi);
                        ListViewItem item1 = listView1.FindItemWithText(katilanadi);
                        listView1.Items[listView1.Items.IndexOf(item1)].SubItems[2].Text = "Hazir";
                        btnKatil.Enabled = true;
                    }

                }
                }
                //-------------------KATILAN---------------//
                if (bekeleme == 2)//katıl tuşuna bastığpında
                {
                geldi = mesaj("<katilanamesajvarmi>" + id + " " + kadi);
                    if (geldi != "")
                    {
                     data1 = deger(geldi);//<TC> den ayırır
                     gelen = index(geldi);//<  > ayırır
                    string[] parcalar = data1.Split(' ');
                    //MessageBox.Show(data1+"\n"+gelen + "\n"+parcalar[0]);
                    if (gelen == "<ekle>")
                    {
                        string[] row2 = { parcalar[0], "2/2", "Host" };
                        var listViewItem = new ListViewItem(row2);
                        listView1.Items.Add(listViewItem);
                        hostadi = parcalar[0];
                        string[] row = { kadi, "2/2", "Hazır Değil" };
                        listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                        btnKatil.Enabled = true;
                    }
                    if (gelen == "<hostol>")
                    {

                            listView1.Items.Clear();
                            string[] row = { kadi, "1/2", "Host" };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                        btnKatil.Enabled = false;
                        btnKatil.Text = "Başlat";
                            katilanadi = "";
                            hostadi = kadi;
                            host = true;
                            bekeleme = 1;
                    }
                    if (gelen == "<baslat>")
                    {
                        timer1.Stop();
                        FormTictactoeOyna frmtictactoeoyna = new FormTictactoeOyna();
                        frmtictactoeoyna.kadi = kadi;
                        frmtictactoeoyna.host = host;
                        frmtictactoeoyna.hostadi = hostadi;
                        frmtictactoeoyna.id = id;
                        frmtictactoeoyna.katilanadi = katilanadi;
                        this.Close();
                        frmtictactoeoyna.Show();
                    }
                }
                }
                /*
            }
            catch {
                timer1.Stop();
                this.Close(); }*/

        }

        private void btnOdaKur_Click(object sender, EventArgs e)
        {
           
            if (mesaj("<odakur>" + kadi + " " + id + " " + txtOdaIsmi.Text + " " + txtOdaSifre.Text + " " + "Host") == "kur")
            {
                if (bekeleme==0) bekeleme = 1;
                btnYenile.Text = "Geri Dön";
                btnKatil.Enabled = false;
                btnKatil.Text = "Başlat";
                panel1.Enabled = false;
                listView1.Items.Clear();
                listView1.Columns[0].Text = "Oyuncu İsimleri";
                listView1.Columns[1].Text = "Oyuncular";
                listView1.Columns[2].Text = "Durum";

                string[] row = { kadi, "1/2", "Host" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                hostadi = kadi;
                host = true;
                timer1.Interval = 1000;
            }
        }
        void vdOdalariListele()
        {
            
            string[] parcalar = mesaj("<odalar>").Split(' ');
            listView1.Items.Clear();
            for (int i=0;i<parcalar.Length-1;i=i+3) {
                string[] row = { parcalar[i], parcalar[i + 1], parcalar[i + 2] };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(bekeleme+" "+host.ToString());
            //0 odalisteleme yamni lobby
            //1 oda kurduğunda sürekli bekliyor atıyor
            //2 katıla bastığında katılmayıbekliyor atıro
            if(bekeleme == 0)
            vdOdalariListele();

            if (bekeleme != 0)
            {

                if (listView1.Items.Count <= 1)
                {
                    mesaj("<odasil>" + kadi + " " + id + " " + txtOdaIsmi.Text + " " + txtOdaSifre.Text + " " + "Host");
                    vdgeridon();
                }

                if (bekeleme == 1&&host==true)
                {
                    mesaj("<katilanamesaj>" + id + " " + kadi + " " + katilanadi + " "+"<hostol>");
                    vdgeridon();
                }
                if (bekeleme == 2 && host == false)
                {
                    //MessageBox.Show(hostadi);
                    mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<cikar>");
                    vdgeridon();
                }

            }


            }

        private void btnKatil_Click(object sender, EventArgs e)//odaya katıl ve hazır tuşu
        {
            if (bekeleme == 1)
            {
                timer1.Stop();
                mesaj("<katilanamesaj>" + id + " " + kadi + " " + katilanadi + " " + "<baslat>");
                FormTictactoeOyna frmtictactoeoyna = new FormTictactoeOyna();
                frmtictactoeoyna.kadi = kadi;
                frmtictactoeoyna.host = host;
                frmtictactoeoyna.hostadi = hostadi;
                frmtictactoeoyna.id = id;
                frmtictactoeoyna.katilanadi = katilanadi;
                this.Close();
                frmtictactoeoyna.Show();
            }
            if (bekeleme == 2)
            {
                //MessageBox.Show(hostadi);
                mesaj("<hostamesaj>" + id + " " + kadi + " " + hostadi + " " + "<hazirim>");
                    ListViewItem item1 = listView1.FindItemWithText(kadi);
                    listView1.Items[listView1.Items.IndexOf(item1)].SubItems[2].Text = "Hazır";
                btnKatil.Enabled = false;
                btnKatil.Text = "Hazır Değil";
            }
            if (bekeleme == 0)//ne oda kur nede katil olmassa yani lobby
            {
                btnKatil.Enabled = false;
                ListViewItem item = listView1.SelectedItems[0];
                //MessageBox.Show("<katil>" + id + " " + kadi + " " + item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);
                //string gln =mesaj("<katil>" + id + " " + kadi + " " + item.SubItems[0].Text + " " + item.SubItems[1].Text + " " + item.SubItems[2].Text);//odanın no, odanın ismi, oyuncu sayısı
                string gln = mesaj("<katil>" + id + " " + kadi + " " + item.SubItems[0].Text );//odanın no, odanın ismi, oyuncu sayısı
                if (gln == "katil")
                {
                    btnYenile.Text = "Geri Dön";
                   // btnKatil.Enabled = true;
                    btnKatil.Text = "Hazır";
                    panel1.Enabled = false;
                    listView1.Items.Clear();
                    listView1.Columns[0].Text = "Oyuncu İsimleri";
                    listView1.Columns[1].Text = "Oyuncular";
                    listView1.Columns[2].Text = "Durum";
                    bekeleme = 2;
                    timer1.Interval = 1000;
                }
            }

        }
        private void vdgeridon()
        {
            btnYenile.Text = "Yenile";
            btnKatil.Enabled = true;
            btnKatil.Text = "Katıl";
            panel1.Enabled = true;
            host = false;
            listView1.Columns[0].Text = "Oda No";
            listView1.Columns[1].Text = "Oda İsmi";
            listView1.Columns[2].Text = "Oyuncular";
            bekeleme = 0;//false olacak
            hostadi = "";
            katilanadi = "";
            vdOdalariListele();
        }
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
            string bitir = "<TC>";
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
    }
}
