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
        private const long ID_Modulo = 1;
        private List<Usuario> TodosUsuarios { get; set; }
        private string Acao { get; set; }

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
            labNotificacao.Hide();
            string login = cbLogin.Text;
            string senha = txtSenha.Text;
            foreach (Usuario user in TodosUsuarios)
            {
                if (user.Login == login && user.Senha == senha)
                {
                    user.LoadPermissoesUsuario();
                    foreach (Permissao permissao in user.Permissoes)
                    {
                        if (permissao.ID_Modulo == ID_Modulo)
                        {
                            if (permissao.Acesso)
                            {
                                Program.Usuario = user;
                                this.Close();
                            }
                            labNotificacao.Text = "Acesso Negado";
                        }
                    }
                }
                else
                {
                    labNotificacao.Text = "Senha Inválida";
                }
            }
            labNotificacao.Show();
        }

        private void CarregarUsuarios()
        {
            labNotificacao.Hide();
            TodosUsuarios = Usuario.TodosUsuarios(null, false);
            foreach (Usuario user in TodosUsuarios)
            {
                cbLogin.Items.Add(user.Login);
            }
        }
    }
}
