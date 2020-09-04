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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private String action;
        private Produto produto;
        public String Action
        {
            get { return this.action; }
            set
            {
                this.action = value;
                //DefinirFormulario();
            }
        }
        public Produto Produto
        {
            get { return this.produto; }
            set
            {
                this.produto = value;
                ExibirInfoProduto();
            }
        }

        private void DefinirFormulario()
        {
            if (this.Action == "Novo")
            {
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnInativarAtivar.Enabled = false;
                // Renomeação de botoês
                btnEditar.Text = "Editar";
                // Alteração da visualização dos campos
                txtNome.Enabled = true;
            }
            else if (this.Action == "Editar")
            {
                btnSalvar.Enabled = true;
                btnEditar.Enabled = true;
                btnInativarAtivar.Enabled = false;
                // Renomeação de botoês
                btnEditar.Text = "Cancelar";
                // Alteração da visualização dos campos
                txtNome.Enabled = false;
            }
            else if (this.Action == "Visualizar")
            {
                btnSalvar.Enabled = false;
                btnInativarAtivar.Enabled = true;
                // Renomeação de botoês
                btnEditar.Text = "Editar";
                // Alteração da visualização dos campos
                txtNome.Enabled = false;
                if (this.Produto.Ativo)
                {
                    btnEditar.Enabled = true;
                    btnInativarAtivar.Text = "Inativar";
                }
                else
                {
                    btnEditar.Enabled = false;
                    btnInativarAtivar.Text = "Ativar";
                }
            }
        }

        private void ExibirInfoProduto()
        {
            txtID.Text = this.Produto.ID.ToString();
            txtNome.Text = this.Produto.Nome;
        }

        private void RecuperarInfoProduto()
        {
            this.Produto.Nome = txtNome.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            RecuperarInfoProduto();
            if (this.Action == "Novo")
            {
                this.produto = new Produto();
                if (this.Produto.Inserir())
                {
                    this.Action = "Visualizar";
                }
                else
                {
                    MessageBox.Show(Conexao.msg);
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                if (this.Produto.Atualizar())
                {
                    this.Action = "Visualizar";
                }
                else
                {
                    MessageBox.Show(Conexao.msg);
                    btnSalvar.Enabled = true;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInativarAtivar_Click(object sender, EventArgs e)
        {
            // Configurar permisão de acesso
            if (true)
            {
                if (this.Produto.AlterarStatus())
                {
                    this.Action = "Visualizar";
                }
            }
        }
    }
}
