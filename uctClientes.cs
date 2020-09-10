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
    public partial class UctClientes : UserControl
    {
        private static UctClientes _instancia;

        public static UctClientes instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctClientes();
                }
                return _instancia;
            }
        }

        private string buscaStatus;

        public string BuscaStatus
        {
            get { return buscaStatus; }
            set 
            {
                buscaStatus = value;
                CarregarClientes();
            }
        }


        public List<Empresa> ListaEmpresas { get; set; }

        public UctClientes()
        {
            InitializeComponent();
            this.BuscaStatus = "Todos";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCliente emp = new FormCliente(null,"Novo");
            emp.ShowDialog();
        }


        private void CarregarClientes()
        {
            string busca = txtBuscaEmpresa.Text;
            //bool status = cbInativos.Checked;
            this.ListaEmpresas = Empresa.BuscaEmpresa(this.BuscaStatus,busca);
            dgvClientes.DataSource = this.ListaEmpresas;
        }

        private void dgvClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int linha = dgvClientes.CurrentRow.Index;
            long id = Convert.ToInt64(dgvClientes.CurrentRow.Cells["colID"].Value);
            Empresa emp = this.ListaEmpresas.Find(empresa => empresa.ID == id);
            FormCliente frmEmp = new FormCliente(emp, "Visualizar");
            frmEmp.ShowDialog();
            CarregarClientes();
            dgvClientes.ClearSelection();
        }

        private void txtBuscaEmpresa_TextChanged(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.gbFiltroStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        this.BuscaStatus = rb.Text;
                    }
                }
            }
        }
    }
}
