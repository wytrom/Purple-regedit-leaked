using Loader;
using Loader.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        WebClient client = new WebClient();
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void siticoneControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings frm1 = new Settings();
            frm1.Show();
            this.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/259a6kWKyh");
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void otimizaçãoPCFAST_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC FAST Ativado!");
            string path = @"C:\Windows\Cursors\pcfast.exe";
            string link = "https://cdn.discordapp.com/attachments/903312223278084116/917593940386004992/fpsbosstuser.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                client.DownloadFile(link, path);
                Process.Start(path);
            }
        }

        private void OtimizaçãoTirarDelay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delay Removido!");
            string path = @"C:\Windows\Cursors\tirar_delai.exe";
            string link = "https://cdn.discordapp.com/attachments/903312223278084116/917593940180475914/tirar_delai.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                client.DownloadFile(link, path);
                Process.Start(path);
            }
        }

        private void AimlockXInject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrindo..");
            string path = @"C:\Windows\Cursors\asd878545443xzcawe8q8988sd7a854.exe";
            if (File.Exists(path))
            {
                Process.Start(path);
                Application.Exit();
            }
            else
            {
                client.DownloadFile("https://cdn.discordapp.com/attachments/903312223278084116/914274731694379068/asd878545443xzcawe8q8988sd7a854.EXE", path);
                Process.Start(path);
            }
        }

        private void AimAssistRapido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aim Assist Rapido Ativado!");
            string path = @"C:\Windows\Cursors\rapido.exe";
            string link = "https://cdn.discordapp.com/attachments/903312223278084116/917594230325669928/AIM_RAPIDO.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                client.DownloadFile(link, path);
                Process.Start(path);
            }

        }

        private void AimAssistMedio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aim Assist Medio Ativado!");
            string path = @"C:\Windows\Cursors\medio.exe";
            string link = "https://cdn.discordapp.com/attachments/903312223278084116/917594229964963860/AIM_MEDIO.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                client.DownloadFile(link, path);
                Process.Start(path);
            }
        }

        private void AimAssistLento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aim Assist Lento Ativado!");
            string path = @"C:\Windows\Cursors\lento.exe";
            string link = "https://cdn.discordapp.com/attachments/903312223278084116/917594229704900638/AIM_LENTO.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                client.DownloadFile(link, path);
                Process.Start(path);
            }
        }

        private void RegeditVip_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\Cursors\vip.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllBytes(path, Resources.VIP);

            Process reg = Process.Start("regedit.exe", "/s \"" + path + "\"");
            reg.WaitForExit();
            File.Delete(path);

            MessageBox.Show("VIP Ativada!");
        }

        private void RegeditUltimate_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\Cursors\ultimate.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllBytes(path, Resources.BLAZE);
            Process reg = Process.Start("regedit.exe", "/s \"" + path + "\"");
            reg.WaitForExit();
            File.Delete(path);
            MessageBox.Show("ULTIMATE Ativada!");
        }

        private void RegeditAjustavel_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\Cursors\ajustavel.exe";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllBytes(path, Resources.AJUSTAVEL);
            Process reg = Process.Start("regedit.exe", "/s \"" + path + "\"");
            reg.WaitForExit();
            File.Delete(path);
            MessageBox.Show("AJUSTAVEL Ativada!");
        }

        private void AimlockXBypass_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\Temp\bypass.exe";
            string link = "https://cdn.discordapp.com/attachments/870501990680105000/923098694247678022/bypass.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            client.DownloadFile(link, path);
            Process.Start(path);
        }
    }
}

