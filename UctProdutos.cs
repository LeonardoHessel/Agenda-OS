using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Linq

namespace Agenda_OS
{
    public partial class UctProdutos : UserControl
    {
        public UctProdutos()
        {
            InitializeComponent();
            this.BuscaStatus = "Ativos";
        }

        private static UctProdutos instancia;
        private string buscaStatus;
        private string buscaString;
        //private List<Produto> listaProdutos;
        
        public static UctProdutos Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new UctProdutos();
                return instancia;
            }
        }

        public string BuscaStatus
        {
            get { return buscaStatus; }
            set
            {
                buscaStatus = value;
                CarregarProdutos();
            }
        }

        public string BuscaString
        {
            get { return buscaString; }
            set
            {
                buscaString = value;
                CarregarProdutos();
            }
        }

        public List<Produto> ListaProdutos { get; set; }

        public void CarregarProdutos()
        {
            this.ListaProdutos = Produto.TodosProdutos(this.BuscaStatus, this.BuscaString);
            //dgvProdutos.DataSource = this.ListaProdutos;
            
            var bindingList = new BindingList<Produto>(this.ListaProdutos);
            var source = new BindingSource(bindingList, null);
            dgvProdutos.DataSource = source;
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.gbFiltroStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked && rb.Text != this.BuscaStatus)
                    {
                        this.BuscaStatus = rb.Text;
                    }
                }
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            this.BuscaString = txtBusca.Text;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //int linha = dgvProdutos.CurrentRow.Index;
            FormProduto formProd = new FormProduto();
            formProd.Action = "Novo";
            formProd.ShowDialog();
            CarregarProdutos();
        }

        private void dgvProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int linha = dgvProdutos.CurrentRow.Index;
            FormProduto formProd = new FormProduto();
            formProd.Produto = dgvProdutos.CurrentRow.DataBoundItem as Produto;
            formProd.Action = "Visualizar";
            formProd.ShowDialog();
            CarregarProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormProduto formProd = new FormProduto();
            formProd.Produto = dgvProdutos.CurrentRow.DataBoundItem as Produto;
            formProd.Action = "Editar";
            formProd.ShowDialog();
            CarregarProdutos();
        }
    }
}
