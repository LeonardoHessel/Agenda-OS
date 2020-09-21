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
            this.ListaUsuarios = Usuario.TodosUsuarios();
            this.ListaProdutos = Produto.TodosProdutos("Todos");
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
                mtbDoc.Text = this.cliente.CNPJ;
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
                cbProduto.DataSource = this.listaProdutos;
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
                cbUsuario.DataSource = this.ListaUsuarios;
            }
        }

        public OrdemServico OrdemServico { get; set; }

        private Produto Produto { get; set; }

        public Usuario Usuario { get; set; }

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

        private void SetupFormulário()
        {
            if (this.Action == "Novo")
            {
                this.OrdemServico = new OrdemServico();
                //cbUsuario.SelectedItem = FormAgenda.usuario;

                btnAtivarInativar.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
                btnAtivarInativar.Text = "Inativar";
                cbUsuario.SelectedItem = FormAgenda.usuario;
                cbAtendimento.SelectedIndex = 0;
                cbSituacao.SelectedIndex = 0;
            }
            else if (this.Action == "Editar")
            {
                ShowInfoOS();
                Campos(true);
                btnAtivarInativar.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = true;
                btnEditar.Text = "Cancelar";
            }
            else if (this.Action == "Visualizar")
            {
                ShowInfoOS();
                Campos(false);
                btnAtivarInativar.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Text = "Editar";
                if (this.OrdemServico.Ativo)
                {
                    btnEditar.Enabled = true;
                    btnAtivarInativar.Text = "Inativar";
                }
                else
                {
                    btnEditar.Enabled = false;
                    btnAtivarInativar.Text = "Ativar";
                }
            }
        }

        private void Campos(bool vf)
        {
            txtCliente.Enabled = vf;
            txtSolicitante.Enabled = vf;
            cbUsuario.Enabled = vf;
            txtAssunto.Enabled = vf;
            cbProduto.Enabled = vf;
            txtDescricao.Enabled = vf;
            txtSolucao.Enabled = vf;
            cbAtendimento.Enabled = vf;
            cbSituacao.Enabled = vf;
            // Talvez altere os sistema de dadas
            dtpAbertura.Enabled = vf;
            dtpFinalizado.Enabled = vf;
        }

        private void ShowInfoOS()
        {
            txtID.Text = this.OrdemServico.ID.ToString();
            this.Cliente = Empresa.BuscaEmpresaByID(this.OrdemServico.ID_Cliente);
            txtSolicitante.Text = this.OrdemServico.Solicitante;
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
            this.OrdemServico.Solicitante = txtSolicitante.Text;
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GetInfoOS();
            if (this.Action == "Novo")
            {
                if (this.OrdemServico.Inserir())
                {
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
                    this.Action = "Visualizar";
                }
                else
                {
                    MessageBox.Show("Erro: " + this.OrdemServico.MSG);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.Action == "Editar")
            {
                this.Action = "Visualizar";
            }
            else
            {
                this.Action = "Editar";
            }
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
            //if (false || usuario.ID != FormAgenda.usuario.ID)
            //{
            //    cbUsuario.Text = FormAgenda.usuario.Nome;
            //    MessageBox.Show("Você não tem permissão para\ncriar OS para outros Usuários");
            //}
            //else
            //{
            //    this.Usuario = usuario;
            //}
            this.Usuario = usuario;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Produto = (Produto)cbProduto.SelectedItem;
        }

        private void btnAtivarInativar_Click(object sender, EventArgs e)
        {
            if (this.OrdemServico.AlterarAtivo())
            {

            }
            
            SetupFormulário();
        }
    }
}
