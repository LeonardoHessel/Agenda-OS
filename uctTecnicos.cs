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
    public partial class uctTecnicos : UserControl
    {
        private static uctTecnicos _instancia;
        public static uctTecnicos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new uctTecnicos();
                }
                return _instancia;
            }
        }
        
        private List<Tecnico> ListaTecnico { get; set; }

        public uctTecnicos()
        {
            InitializeComponent();
            CarregarTecnicos();
            labNT.Text = this.ListaTecnico.Count.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int rcBefore = dgvTecnico.Rows.Count;
            Tecnico tec = new Tecnico();
            frmTecnico frm = new frmTecnico(tec,"New");
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
            Tecnico tecnico = this.ListaTecnico.Find(x => x.codigo == id);
            frmTecnico frm = new frmTecnico(tecnico, "Edit");
            frm.ShowDialog();
            CarregarTecnicos();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }

        private void CarregarTecnicos()
        {
            this.ListaTecnico = Tecnico.TabelaTodosTecnico();
            dgvTecnico.DataSource = Tecnico.TabelaTodosTecnico();
            labNS.Text = this.ListaTecnico.Count.ToString();
        }

        private void dgvTecnico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int linha = dgvTecnico.CurrentRow.Index;
            long id = Convert.ToInt64(dgvTecnico.CurrentRow.Cells["ID"].Value);
            Tecnico tecnico = this.ListaTecnico.Find(x=>x.codigo == id);
            frmTecnico frm = new frmTecnico(tecnico, "Show");
            frm.ShowDialog();
            CarregarTecnicos();
            dgvTecnico.ClearSelection();
            dgvTecnico.CurrentCell = dgvTecnico[0, linha];
            dgvTecnico.Rows[linha].Selected = true;
        }
    }
}
