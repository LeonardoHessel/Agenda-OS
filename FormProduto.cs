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

        private Produto produto;
        public Produto Produto
        {
            get { return this.produto; }
            set
            {
                this.produto = value;
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
            RecuperarInfoProduto();
            this.Produto.Inserir();
        }
    }
}
