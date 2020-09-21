using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Ink;

namespace Agenda_OS
{
    public partial class SplashScreen : Form
    {
        DialogResult Acao { get; set; }
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            tMinus.Enabled = true;
        }

        private void tMinus_Tick(object sender, EventArgs e)
        {
            TesteDeConexao();
            if (Acao == DialogResult.OK)
            {
                this.DialogResult = Acao;
                this.Close();
            }
            else if (Acao == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void TesteDeConexao()
        {
            tMinus.Stop();
            if (Conexao.TestarConexao())
            {
                this.Acao = DialogResult.OK;
            }
            else
            {
                string text = "Falha ao se conectar com o servidor\n" + Conexao.msg;
                string title = "Servidor?";
                this.Acao = MessageBox.Show(text, title, MessageBoxButtons.RetryCancel);
            }
            tMinus.Start();
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                tMinus.Stop();
                FormConfiguracao frm = new FormConfiguracao();
                frm.ShowDialog();
                tMinus.Start();
            }
            else if (e.KeyCode == Keys.F5)
            {
                TesteDeConexao();
                if (Acao == DialogResult.OK)
                {
                    this.DialogResult = Acao;
                    this.Close();
                }
                else if (Acao == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
    }
}
