using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            this.ListaUsuarios = Usuario.TodosUsuarios("", false);
            this.ListaProdutos = Produto.TodosProdutos("");
            SetupFormulário();
        }

        private string action;
        public string Action
        {
            get { return this.action; }
            set
            {
                action = value;
                SetupFormulário();
            }
        }

        private Empresa cliente;
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

        private List<Produto> listaProdutos;
        private List<Produto> ListaProdutos
        {
            get { return listaProdutos; }
            set
            {
                listaProdutos = value;
                cbProduto.DisplayMember = "Nome";
                cbProduto.ValueMember = "ID";
                cbProduto.Items.AddRange(value.ToArray());
            }
        }

        private List<Usuario> listaUsuarios;
        private List<Usuario> ListaUsuarios
        {
            get { return listaUsuarios; }
            set
            {
                listaUsuarios = value;
                cbUsuario.DisplayMember = "Nome";
                cbUsuario.ValueMember = "ID";
                cbUsuario.Items.AddRange(this.listaUsuarios.ToArray());
            }
        }

        public OrdemServico OrdemServico { get; set; }

        private Produto Produto { get; set; }

        public Usuario Usuario { get; set; }

        private void ShowInfoOS()
        {
            this.Cliente = Empresa.BuscaEmpresaByID(this.OrdemServico.ID_Cliente);
            txtQuem.Text = this.OrdemServico.Solicitante;
            cbUsuario.SelectedItem = ListaUsuarios.Find(x => x.ID == this.OrdemServico.ID_Usuario);
            txtAssunto.Text = this.OrdemServico.Assunto;
            txtDescricao.Text = this.OrdemServico.Descricao;
            txtSolucao.Text = this.OrdemServico.Solucao;
            cbProduto.SelectedItem = ListaProdutos.Find(x => x.ID == this.OrdemServico.ID_Produto);
            cbAtendimento.Text = this.OrdemServico.Atendimento;
            dtpAbertura.Value = this.OrdemServico.Abertura;
            dtpFinalizado.Value = this.OrdemServico.Fechamento;
            cbSituacao.Text = this.OrdemServico.Situacao;
        }

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
                cbUsuario.Text = FormAgenda.usuario.Nome;
                cbSituacao.Text = "Pendente";
                btnDeletar.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else if (this.Action == "Visualizar")
            {
                ShowInfoOS();
                btnDeletar.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else if (this.Action == "Editar")
            {
                ShowInfoOS();
                btnDeletar.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
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
                    this.Action = "Visualizar";
                }
                else
                {
                    MessageBox.Show("Erro: " + this.OrdemServico.MSG);
                }
            }
            else if (this.Action == "Editar")
            {
                if (this.OrdemServico.Atualizar())
                {
                    MessageBox.Show("Ordem de Serviço Alterada com sucesso");
                    this.Action = "Visualizar";
                }
                else
                {
                    MessageBox.Show("Erro: " + this.OrdemServico.MSG);
                }
            }
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Produto = (Produto)cbProduto.SelectedItem;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Action = "Editar";
        }
    }
}
