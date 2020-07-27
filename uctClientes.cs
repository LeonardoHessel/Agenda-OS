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

        private List<Empresa> listarempresa { get; set; }

        private void RemoverCampos()
        {
            dgvClientes.Columns.Remove("id");
            dgvClientes.Columns.Remove("razao");
            dgvClientes.Columns.Remove("cnpj");
            dgvClientes.Columns.Remove("nome");
            dgvClientes.Columns.Remove("endereco");
            dgvClientes.Columns.Remove("celular");
            dgvClientes.Columns.Remove("telefone");
            dgvClientes.Columns.Remove("cep");
        }
        private void CarregarEmpresa()
        {
            this.listarempresa = Empresa.ListaEmpresa();
            dgvClientes.DataSource = this.listarempresa;
        }

        public UctClientes()
        {
            InitializeComponent();
            CarregarEmpresa();
            RemoverCampos();
        }

        //adicionar empresa
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            FormClientes frmclientes = new FormClientes(empresa, "New");
            frmclientes.ShowDialog();
        }





















        //editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvClientes.CurrentRow.Index;
            long id = Convert.ToInt64(dgvClientes.CurrentRow.Cells["ID"].Value);

            Empresa empresa = this.listarempresa.Find(cliente => cliente.ID == id);
            FormClientes frm = new FormClientes(empresa, "Edit");
            frm.ShowDialog();
            CarregarEmpresa();
            dgvClientes.ClearSelection();
            dgvClientes.CurrentCell = dgvClientes[0, linha];
            dgvClientes.Rows[linha].Selected = true;
        }
        //puxa a tela com os registros se der duplo click na linha selecionada
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvClientes.CurrentRow.Index;
            long id = Convert.ToInt64(dgvClientes.CurrentRow.Cells["ID"].Value);

            Empresa empresa = this.listarempresa.Find(cliente => cliente.ID == id);
            FormClientes frm = new FormClientes(empresa, "Edit");
            frm.ShowDialog();
            CarregarEmpresa();
            dgvClientes.ClearSelection();
            dgvClientes.CurrentCell = dgvClientes[0, linha];
            dgvClientes.Rows[linha].Selected = true;
        }

       
    }
}
