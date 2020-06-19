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
        private Modulo modulo;

        public FormLogin()
        {
            InitializeComponent();
            CarregarUsuarios();
            this.modulo = Modulo.CarregarModulo(1);
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
            foreach (Usuario user in TodosUsuarios)
            {
                if (user.Login == login && user.Senha == senha)
                {
                    FormAgenda form = new FormAgenda();
                    form.Usuario = user;
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            labSenhaInvalida.Show();
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
