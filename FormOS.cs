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
    public partial class FormOS : Form
    {
        private string action;
        private Empresa cliente;
        //private Usuario usuario;
        private List<Usuario> listaUsuarios
        {
            set
            {
                cbUsuario.DisplayMember = "Nome";
                cbUsuario.ValueMember = "ID";
                cbUsuario.Items.AddRange(value.ToArray());
            }
        }

        public string Action
        {
            get { return action; }
            set 
            {
                action = value;
                SetupFormulário();
            }
        }

        public Empresa Cliente
        {
            get { return this.cliente; }
            set
            {
                this.cliente = value;
                txtCliente.Text = this.cliente.Nome;
                txtCNPJ.Text = this.cliente.CNPJ;
            }
        }

        public Usuario Usuario { get; set; }

        public FormOS()
        {
            InitializeComponent();
            SetupFormulário();
        }

        private void FormOS_Load(object sender, EventArgs e)
        {

        }

        private void FormOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtCliente.Focused)
                {
                    btnPesquisaCliente.PerformClick();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            string buscaCliente = txtCliente.Text;
            FormBuscaCliente busca = new FormBuscaCliente(buscaCliente);
            DialogResult result = busca.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Cliente = busca.Cliente;
            }
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)cbUsuario.SelectedItem;
            if (false || usuario.ID != FormAgenda.usuario.ID)
            {
                cbUsuario.Text = FormAgenda.usuario.Nome;
                MessageBox.Show("Você não tem permissão para\ncriar OS para outros Usuários");
            }
            else
            {
                this.Usuario = usuario;
            }
        }

        private void SetupFormulário()
        {
            if (this.Action == "Novo")
            {
                this.listaUsuarios = Usuario.TodosUsuarios("", false);
                cbUsuario.Text = FormAgenda.usuario.Nome;
                cbSituacao.Text = "Pendente";
            }
        }
    }
}
