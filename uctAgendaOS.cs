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
    public partial class UctAgendaOS : UserControl
    {
        private static UctAgendaOS _instancia;

        public static UctAgendaOS instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctAgendaOS();
                }
                return _instancia;
            }
        }

        public UctAgendaOS()
        {
            InitializeComponent();
            CarregarOS();
        }

        private List<OrdemServico> ListaOS { get; set; }

        private void CarregarOS()
        {
            this.ListaOS = OrdemServico.TodasOrdenServico(txtBusca.Text);
            dgvOS.DataSource = this.ListaOS;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOS frmOS = new FormOS();
            frmOS.OrdemServico = new OrdemServico();
            frmOS.Usuario = FormAgenda.usuario;
            frmOS.Action = "Novo";
            frmOS.ShowDialog();
            CarregarOS();
        }

        private void dgvOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdemServico osSelecionado = (OrdemServico)dgvOS.CurrentRow.DataBoundItem;
            FormOS formOS = new FormOS();
            formOS.OrdemServico = osSelecionado;
            formOS.Action = "Visualizar";
            formOS.ShowDialog();
            CarregarOS();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregarOS();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OrdemServico osSelecionado = (OrdemServico)dgvOS.CurrentRow.DataBoundItem;
            FormOS formOS = new FormOS();
            formOS.OrdemServico = osSelecionado;
            formOS.Action = "Editar";
            formOS.ShowDialog();
            CarregarOS();
        }
    }
}
