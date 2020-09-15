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
                DefinirFormulario();
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
                this.Produto = new Produto();
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
                txtNome.Enabled = true;
            }
            else if (this.Action == "Visualizar")
            {
                txtNome.Enabled = false;
                btnSalvar.Enabled = false;
                btnEditar.Text = "Editar";
                btnInativarAtivar.Enabled = true;
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
                ExibirInfoProduto();
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
            if (this.Action == "Editar")
            {
                DialogResult drMSG = MessageBox.Show("Deseja cancelar a edição?", "Cancelar", MessageBoxButtons.YesNo);
                if (drMSG == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
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

        private void FormProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            }
        }
    }
}
