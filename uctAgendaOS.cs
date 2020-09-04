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
            cbUsuario.DataSource = Usuario.TodosUsuarios("Todos", "", true);
            CarregarOS();
        }

        private List<OrdemServico> ListaOS { get; set; }

        private Usuario buscaUsuario;
        private string buscaStatus;
        private string BuscaStatus
        {
            get { return this.buscaStatus; }
            set
            {
                this.buscaStatus = value;
                CarregarOS();
            }
        }
        
        private Usuario BuscaUsuario
        {
            get { return this.buscaUsuario; }
            set
            {
                this.buscaUsuario = value;
                CarregarOS();
            }
        }

        private void CarregarOS()
        {
            this.ListaOS = OrdemServico.TodasOrdenServico(txtBusca.Text, this.BuscaStatus, this.BuscaUsuario.ID);
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

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuscaUsuario = (Usuario)cbUsuario.SelectedItem;
        }
    }
}
