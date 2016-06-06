using brLauncher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace brLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtém os valores digitados para abrir a tela.
            string userid = this.txtUserId.Text,
                    user_pass = this.txtUser_Pass.Text;

            // Grava as configurações no arquivo de aplicação e inicializa o cliente
            //  do jogo com as configurações.
            Settings.Default.userid_remember = this.chkUserId.Checked;
            Settings.Default.userpass_remember = this.chkUserPass.Checked;
            Settings.Default.userid = Settings.Default.userid_remember ? this.txtUserId.Text : string.Empty;
            Settings.Default.user_pass = Settings.Default.userpass_remember ? this.txtUser_Pass.Text : string.Empty;
            Settings.Default.Save();

            this.Hide();

            // Inicializa o hexed do usuário com as informações de usuário e senha.
            Process prc = new Process();
            prc.EnableRaisingEvents = true;
            prc.Exited += prc_Exited;
            prc.StartInfo.FileName = Settings.Default.hexedFile;
            prc.StartInfo.Arguments = String.Format("-t:{0} {1} 1rag1", user_pass, userid);
            prc.Start();
        }

        /// <summary>
        /// Executa quando o processo do hexed é finalizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prc_Exited(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Show();
                this.BringToFront();
                this.Focus();
            });
        }

        #region Faz a janela se arrastar ao clicar
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

    }
}
