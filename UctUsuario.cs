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
            CarregarTecnicos();
            labNT.Text = this.ListaTecnico.Count.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int rcBefore = dgvTecnico.Rows.Count;
            Usuario tec = new Usuario();
            FormTecnico frm = new FormTecnico(tec,"New");
            frm.ShowDialog();
            CarregarTecnicos();
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
            Usuario tecnico = this.ListaTecnico.Find(x => x.id == id);
            FormTecnico frm = new FormTecnico(tecnico, "Edit");
            frm.ShowDialog();
            CarregarTecnicos();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }

        private void CarregarTecnicos()
        {
            this.ListaTecnico = Usuario.TabelaTodosTecnico();
            dgvTecnico.DataSource = Usuario.TabelaTodosTecnico();
            labNS.Text = this.ListaTecnico.Count.ToString();
        }

        private void dgvTecnico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int linha = dgvTecnico.CurrentRow.Index;
            long id = Convert.ToInt64(dgvTecnico.CurrentRow.Cells["ID"].Value);
            Usuario tecnico = this.ListaTecnico.Find(x=>x.id == id);
            FormTecnico frm = new FormTecnico(tecnico, "Show");
            frm.ShowDialog();
            CarregarTecnicos();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }
    }
}
