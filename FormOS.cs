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
        public FormOS()
        {
            InitializeComponent();
            SetupFormulário();
        }

        private string action;
        private Empresa cliente;
        //private Usuario usuario;

        public string Action
        {
            get { return this.action; }
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

        private List<Produto> listaProdutos
        {
            set
            {
                cbProduto.DisplayMember = "Nome";
                cbProduto.ValueMember = "ID";
                cbProduto.Items.AddRange(value.ToArray());
            }
        }

        private List<Usuario> listaUsuarios
        {
            set
            {
                cbUsuario.DisplayMember = "Nome";
                cbUsuario.ValueMember = "ID";
                cbUsuario.Items.AddRange(value.ToArray());
            }
        }

        public OrdemServico OrdemServico { get; set; }

        private Produto Produto { get; set; }

        public Usuario Usuario { get; set; }

        private void GetInfoOS()
        {
            this.OrdemServico.ID_Cliente = this.Cliente.ID;
            this.OrdemServico.Solicitante = txtQuem.Text;
            this.OrdemServico.ID_Usuario = this.Usuario.ID;
            this.OrdemServico.Assunto = txtAssunto.Text;
            this.OrdemServico.Descricao = txtDescricao.Text;
            this.OrdemServico.Solucao = txtSolucao.Text;
            this.OrdemServico.ID_Produto = this.Produto.ID;
            this.OrdemServico.Atendimento = this.cbAtendimento.Text;
            this.OrdemServico.Abertura = dtpAbertura.Value;
            this.OrdemServico.Fechamento = dtpFinalizado.Value;
            this.OrdemServico.Situacao = cbSituacao.Text;
        }

        private void SetupFormulário()
        {
            if (this.Action == "Novo")
            {
                this.listaUsuarios = Usuario.TodosUsuarios("", false);
                cbUsuario.Text = FormAgenda.usuario.Nome;
                this.listaProdutos = Produto.TodosProdutos("");
                cbSituacao.Text = "Pendente";
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetInfoOS();
            if (this.Action == "Novo")
            {
                if (this.OrdemServico.Inserir())
                {
                    MessageBox.Show("Ordem de Serviço Inserida com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro: " + this.OrdemServico.Erro);
                }
            }
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Produto = (Produto)cbProduto.SelectedItem;
        }
    }
}
