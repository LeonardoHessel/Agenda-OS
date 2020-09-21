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
    public partial class FormBuscaCliente : Form
    {
        public Empresa Cliente { get; set; }

        List<Empresa> Clientes { get; set; }

        public FormBuscaCliente( string busca)
        {
            InitializeComponent();
            BuscarClientes();
            txtBusca.Text = busca;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 1)
            {
                this.Cliente = (Empresa)dgvClientes.Rows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else if (this.Cliente != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Ignore;
            }            
        }

        private void FormBuscaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Ignore;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.PerformClick();
            }
        }

        private void BuscarClientes()
        {
            this.Clientes = Empresa.BuscaEmpresa("Ativos",txtBusca.Text);
            dgvClientes.DataSource = this.Clientes;
        }

        private void dgvClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Cliente = dgvClientes.CurrentRow.DataBoundItem as Empresa;
            btnSelecionar.PerformClick();
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cliente = (Empresa)dgvClientes.CurrentRow.DataBoundItem;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
