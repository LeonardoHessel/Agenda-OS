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

        public List<Empresa> ListaEmpresas { get; set; }

        public UctClientes()
        {
            InitializeComponent();
            CarregarEmpresas();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormEmpresa emp = new FormEmpresa();
            emp.Acao = "Novo";
            emp.ShowDialog();
        }
        private void CarregarEmpresas()
        {
            string busca = txtBuscaEmpresa.Text;
            bool status = cbInativos.Checked;
            this.ListaEmpresas = Empresa.BuscaEmpresa(busca, status);
            dgvClientes.DataSource = this.ListaEmpresas;
        }
    }
}
