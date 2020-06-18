using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class FormLogin : Form
    {
        private List<Usuario> TodosUsuarios { get; set; }
        private Usuario Usuario { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            } 
            else if (e.KeyCode == Keys.Enter)
            {
                btnAcessar.PerformClick();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            labSenhaInvalida.Hide();
            string login = cbLogin.Text;
            string senha = txtSenha.Text;
            bool acesso = false;
            foreach (Usuario user in TodosUsuarios)
            {
                if (user.Login == login && user.Senha == senha)
                {
                    acesso = true;
                    Usuario = user;
                }
            }
            if (acesso)
            {
                MessageBox.Show("Sucesso");
            }
            else
            {
                labSenhaInvalida.Show();
            }
        }

        private void CarregarUsuarios()
        {
            labSenhaInvalida.Hide();
            TodosUsuarios = Usuario.TodosUsuarios(null, false);
            foreach (Usuario user in TodosUsuarios)
            {
                cbLogin.Items.Add(user.Login);
            }
        }
    }
}
