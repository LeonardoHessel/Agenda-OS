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
        public long ID_Modulo { get; set; }
        public String Action { get; set; }
        private List<Usuario> TodosUsuarios { get; set; }
        public Usuario Usuario { get; set; }
        public Boolean Permissao { get; set; }

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
            this.Permissao = false;
            string login = cbLogin.Text;
            string senha = txtSenha.Text;
            foreach (Usuario user in TodosUsuarios)
            {
                if (user.Login == login && user.Senha == senha)
                {
                    this.Usuario = user;
                    user.LoadPermissoesUsuario();
                    bool perm = user.VerifPermissao(ID_Modulo);
                    if (perm)
                    {
                        this.Permissao = true;
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
            }
        }

        private void CarregarUsuarios()
        {
            TodosUsuarios = Usuario.TodosUsuarios("Ativos");
            cbLogin.DataSource = this.TodosUsuarios;
        }
    }
}
