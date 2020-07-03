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
    public partial class UctUsuario : UserControl
    {
        private static UctUsuario _instancia;
        public static UctUsuario instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctUsuario();
                }
                return _instancia;
            }
        }
        
        private List<Usuario> ListaTecnico { get; set; }

        public UctUsuario()
        {
            InitializeComponent();
            CarregarUsuarios();
            labNT.Text = Usuario.TodosUsuarios(null, true).Count.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int rcBefore = dgvTecnico.Rows.Count;
            Usuario tec = new Usuario();
            FormUsuario frm = new FormUsuario(tec,"New");
            frm.ShowDialog();
            CarregarUsuarios();
            int rcAfter = dgvTecnico.Rows.Count;
            if (rcAfter > rcBefore)
            {
                int lasInserted = rcAfter - 1;
                dgvTecnico.ClearSelection();
                dgvTecnico.CurrentCell = dgvTecnico[0, lasInserted];
                dgvTecnico.Rows[lasInserted].Selected = true;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvTecnico.CurrentRow.Index;
            long id = Convert.ToInt64(dgvTecnico.CurrentRow.Cells["ID"].Value);
            Usuario tecnico = this.ListaTecnico.Find(usuario => usuario.ID == id);
            FormUsuario frm = new FormUsuario(tecnico, "Edit");
            frm.ShowDialog();
            CarregarUsuarios();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }

        private void CarregarUsuarios()
        {
            string busca = txtBusca.Text;
            bool checkDeletados = chbDeletados.Checked;
            this.ListaTecnico = Usuario.TodosUsuarios(busca, checkDeletados);
            labNS.Text = this.ListaTecnico.Count.ToString();
            dgvTecnico.DataSource = this.ListaTecnico;
        }

        private void dgvTecnico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int linha = dgvTecnico.CurrentRow.Index;
            long id = Convert.ToInt64(dgvTecnico.CurrentRow.Cells["ID"].Value);
            Usuario tecnico = this.ListaTecnico.Find(usuario => usuario.ID == id);
            FormUsuario frm = new FormUsuario(tecnico, "Show");
            frm.ShowDialog();
            CarregarUsuarios();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void chbDeletados_CheckedChanged(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
    }
}
