using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }
        private void frmAgendaOs_Load(object sender, EventArgs e)
        {

        }

        private void frmAgendaOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                btnClientes.PerformClick();
            }
            else if (e.KeyChar == '2')
            {
                btnAgendaOS.PerformClick();
            }
            else if (e.KeyChar == '3')
            {
                btnTecnicos.PerformClick();
            }
            else if (e.KeyChar == '4')
            {
                btnServicos.PerformClick();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(uctClientes.instancia))
            {
                pnlUC.Controls.Add(uctClientes.instancia);
                uctClientes.instancia.Dock = DockStyle.Fill;
            }
            uctClientes.instancia.BringToFront();
        }

        private void btnAgendaOS_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(uctAgendaOS.instancia))
            {
                pnlUC.Controls.Add(uctAgendaOS.instancia);
                uctAgendaOS.instancia.Dock = DockStyle.Fill;
            }
            uctAgendaOS.instancia.BringToFront();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(uctTecnicos.instancia))
            {
                pnlUC.Controls.Add(uctTecnicos.instancia);
                uctTecnicos.instancia.Dock = DockStyle.Fill;
            }
            uctTecnicos.instancia.BringToFront();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(uctServicos.instancia))
            {
                pnlUC.Controls.Add(uctServicos.instancia);
                uctServicos.instancia.Dock = DockStyle.Fill;
            }
            uctServicos.instancia.BringToFront();
        }

        private void frmAgendaOs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmAgendaOs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente fechar o sistema?", "Sair", MessageBoxButtons.YesNo);
            if (resp == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
