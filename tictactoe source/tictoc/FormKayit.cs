//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictoc
{
    public partial class FormKayit : Form
    {
        public IPAddress ipi;
        
        static Form1 frm1 = new Form1();
        static FormGiris frmGiris = new FormGiris();
        public FormKayit()
        {
            InitializeComponent();
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            ipi = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
            lblDurum.Text = "";
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Panel pnlKullanici = (Panel)frm1.Controls["pnlKullanici"];
            Panel pnlResim = (Panel)frm1.Controls["pnlResim"];
            pnlResim.Size = new Size(pnlResim.Width, frm1.Height - this.Height - 65);
            pnlKullanici.Location = new Point(pnlKullanici.Location.X, pnlResim.Height + 7);
            pnlKullanici.Size = new Size(pnlKullanici.Width, this.Height);
        }

        private void lblGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            geridon();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {


            
            if (txtKadi.Text != "" && txtSifre.Text != ""&&txtSifreOnay.Text!="")
            {
                if (txtKadi.Text.IndexOf(" ", 0, txtKadi.Text.Length) == -1 && txtSifre.Text.IndexOf(" ", 0, txtSifre.Text.Length) == -1)
                {
                    if (txtKadi.Text.Length >= 8&& txtSifre.Text.Length >= 8) { 
                    if (txtSifre.Text == txtSifreOnay.Text)
                    {
                        if (sql(@"SELECT COUNT(*) FROM users where kadi = '" + txtKadi.Text + "'") == "0")
                        {
                                sqlexecute(@"INSERT INTO users(kadi,sifre,email) VALUES ('" + txtKadi.Text + "','" + txtSifre.Text + "','" + txtEmail.Text + "')");
                            lblDurum.Text = "";
                            MessageBox.Show("Kayıt İşleminiz Başarıyla Tamamlandı.\nŞimdi giriş yapabilirsiniz... :)");
                            geridon();
                        }
                        else lblDurum.Text = "Aynı kullanıcı adı mevcut.";
                    }
                    else lblDurum.Text = "Şifreler aynı değil.";
                }else lblDurum.Text = "en az 8 hane.";
            }
                else lblDurum.Text = "Boşluk var.";
            }
            else lblDurum.Text = "Gerekli alanları doldurunuz.";

        }
        private string sql(string giden)
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


                byte[] msg = Encoding.ASCII.GetBytes("<sql>" + giden + "<TC>");
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
                return "";
            }
        }
        private string sqlexecute(string giden)
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


                byte[] msg = Encoding.ASCII.GetBytes("<sqlexecute>" + giden + "<TC>");
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
                return "";
            }
        }

        void geridon()
        {
            FormGiris frmGiris = new FormGiris();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Panel pnlKullanici = (Panel)frm1.Controls["pnlKullanici"];
            pnlKullanici.Controls.Clear();
            frmGiris.TopLevel = false;
            frmGiris.AutoScroll = true;
            pnlKullanici.Controls.Add(frmGiris);
            this.Close();
            frmGiris.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
