//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class Form1 : Form
    {
        public IPAddress ipi;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ipi = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

            FormGiris frmGiris = new FormGiris();
            frmGiris.Enabled = false;
            progressBar1.Value = 0;
            frmGiris.TopLevel = false;
            frmGiris.AutoScroll = true;
            pnlKullanici.Controls.Add(frmGiris);
            frmGiris.Show();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (mesaj("<version>" + version) == "test")
            {
                lblBaglanti.Text = "servere bağlandı.";
                progressBar1.Value = 100;
                lblBaglanti.Text = "Oynamaya Hazır.";
                frmGiris.Enabled = true;
            }
            else
            {
                frmGiris.Enabled = false;
                lblBaglanti.Text = "Güncelleme Gerekli.";
            }

               
        }
        
        string  mesaj(string giden)
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
                
                byte[] msg = Encoding.ASCII.GetBytes(giden+"<TC>");
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
                lblBaglanti.Text = "Server Kapalı";
                return "";
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
