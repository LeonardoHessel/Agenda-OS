using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class UctProdutos : UserControl
    {
        private static UctProdutos _instancia;

        private List<Produto> listaProdutos;

        public static UctProdutos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctProdutos();
                }
                return _instancia;
            }
        }

        public UctProdutos()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        public void CarregarProdutos()
        {
            this.listaProdutos = Produto.TodosProdutos(txtBusca.Text);
            dgvProdutos.DataSource = this.listaProdutos;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormProduto form = new FormProduto();
            form.ShowDialog();
            CarregarProdutos();
        }
    }
}
