using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Agenda_OS
{
    public partial class UctAgendaOS : UserControl
    {
        public UctAgendaOS()
        {
            InitializeComponent();
            cbUsuario.DataSource = Usuario.TodosUsuarios("Todos", "", true);
            CarregarOS();
        }

        private static UctAgendaOS instancia;

        public static UctAgendaOS Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new UctAgendaOS();
                }
                return instancia;
            }
        }

        private List<OrdemServico> ListaOS { get; set; }

        private void CarregarOS()
        {
            string status = "Todos";
            if (rbAtivos.Checked)
                status = "Ativos";
            else if (rbInativos.Checked)
                status = "Inativos";

            Usuario user = cbUsuario.SelectedItem as Usuario;
            string busca = txtBusca.Text;

            this.ListaOS = OrdemServico.TodasOrdenServico(busca, status, user.ID);
            dgvOS.DataSource = this.ListaOS;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormOS frmOS = new FormOS();
            frmOS.OrdemServico = new OrdemServico();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OrdemServico osSelecionado = (OrdemServico)dgvOS.CurrentRow.DataBoundItem;
            FormOS formOS = new FormOS();
            formOS.OrdemServico = osSelecionado;
            formOS.Action = "Editar";
            formOS.ShowDialog();
            CarregarOS();
        }

        private void option_Changed(object sender, EventArgs e)
        {
            CarregarOS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
