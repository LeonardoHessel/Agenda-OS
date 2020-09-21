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
        public UctClientes()
        {
            InitializeComponent();
            this.BuscaStatus = "Todos";
        }

        private static UctClientes instancia;

        public static UctClientes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new UctClientes();
                }
                return instancia;
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


        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Empresa = new Empresa();
            frm.Acao = "Novo";
            frm.ShowDialog();
            CarregarClientes();
        }


        private void CarregarClientes()
        {
            string status = "Todos";
            if (rbAtivos.Checked)
                status = "Ativos";
            else if (rbInativos.Checked)
                status = "Inativos";
            
            string busca = txtBuscaEmpresa.Text;
            
            dgvClientes.DataSource = Empresa.BuscaEmpresa(status, busca);
        }

        private void dgvClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Empresa = dgvClientes.CurrentRow.DataBoundItem as Empresa;
            frm.Acao = "Visualizar";
            frm.ShowDialog();
            CarregarClientes();
        }

        private void option_Changed(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Empresa = dgvClientes.CurrentRow.DataBoundItem as Empresa;
            frm.Acao = "Editar";
            frm.ShowDialog();
            CarregarClientes();
        }
    }
}
