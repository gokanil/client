//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictoc
{
    public partial class FormGiris : Form
    {
        public IPAddress ipi;
        

        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            ipi = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Panel pnlKullanici = (Panel)frm1.Controls["pnlKullanici"];
            Label lblBaglanti = (Label)frm1.Controls["lblBaglanti"];
            Panel pnlResim = (Panel)frm1.Controls["pnlResim"];
            Form1 frm11 = new Form1();
            lblDurum.Text = "";
            pnlResim.Size = new Size(pnlResim.Width, frm1.Height - this.Height - 65);
            pnlKullanici.Location = new Point(pnlKullanici.Location.X, pnlResim.Height + 7);
            pnlKullanici.Size = new Size(pnlKullanici.Width, this.Height);
        }

        private void lblKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormKayit frmKayit = new FormKayit();
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Panel pnlKullanici = (Panel)frm1.Controls["pnlKullanici"];
            pnlKullanici.Controls.Clear();
            this.Close();
            frmKayit.TopLevel = false;
            frmKayit.AutoScroll = true;
            pnlKullanici.Controls.Add(frmKayit);
            frmKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            btnGiris.Enabled = false;
                if (sql(@"SELECT COUNT(*) FROM users where kadi='" + txtKadi.Text + "'") == "1" && sql(@"SELECT sifre FROM Users where kadi='" + txtKadi.Text + "'") == txtSifre.Text)
                {
                if (mesaj("<kullanicivarmi>" + txtKadi.Text) == "yok")
                {
                    FormOdalar frmodalar = new FormOdalar();
                    Form1 frm1 = new Form1();
                    frmodalar.kadi = txtKadi.Text;
                    frmodalar.id = sql(@"SELECT id FROM users where kadi='" + txtKadi.Text + "'");
                    FormOdalar frmOdalar = new FormOdalar();
                    frm1.Opacity = 0;
                    frmodalar.Show();
                }
                else
                {
                    lblDurum.Text = "Kullanıcı zaten çevrimiçi.";
                    this.Enabled = true;
                    btnGiris.Enabled = true;
                }
                }
                else
                {
                    lblDurum.Text = "Kullanıcı adı veya şifre yanlış.";
                    this.Enabled = true;
                btnGiris.Enabled = true;
            }
            

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
                return "";
            }
        }
        private string sql(string giden)
        {

            byte[] bytes = new byte[1024];

            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                // IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPAddress ipAddress = ipi;
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 120);

                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(remoteEP);


                byte[] msg = Encoding.ASCII.GetBytes("<sql>"+giden + "<TC>");
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



    }
}
