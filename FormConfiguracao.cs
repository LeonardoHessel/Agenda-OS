using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class FormConfiguracao : Form
    {
        public FormConfiguracao()
        {
            InitializeComponent();
            ExibirConfiguracao();
        }

        private void ExibirConfiguracao()
        {
            string servidor = Properties.Settings.Default.server;
            string porta = Properties.Settings.Default.porta;
            string banco = Properties.Settings.Default.nomebd;
            string usuario = Properties.Settings.Default.usuariobd;
            string senha = Properties.Settings.Default.senhabd;

            txtServer.Text = servidor;
            txtPorta.Text = porta;
            txtBancoDados.Text = banco;
            txtUsuario.Text = usuario;
            txtSenha.Text = senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txtServer.Text;
            Properties.Settings.Default.porta = txtPorta.Text;
            Properties.Settings.Default.nomebd = txtBancoDados.Text;
            Properties.Settings.Default.usuariobd = txtUsuario.Text;
            Properties.Settings.Default.senhabd = txtSenha.Text;
            Properties.Settings.Default.Save();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
