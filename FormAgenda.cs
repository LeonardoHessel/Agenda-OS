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
        public static Usuario usuario;
        public static List<Permissao> Permissoes { get; set; }
        public Usuario Usuario
        {
            get => FormAgenda.usuario;
            set
            {
                FormAgenda.usuario = value;
                labUsuarioMone.Text = value.Nome;
            }
        }


        public FormAgenda()
        {
            InitializeComponent();
        }

        private void frmAgendaOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                btnOS.PerformClick();
            }
            else if (e.KeyChar == '2')
            {
                btnClientes.PerformClick();
            }
            else if (e.KeyChar == '3')
            {
                btnUsuarios.PerformClick();
            }
            else if (e.KeyChar == '4')
            {
                btnServicos.PerformClick();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctClientes.instancia))
            {
                pnlUC.Controls.Add(UctClientes.instancia);
                UctClientes.instancia.Dock = DockStyle.Fill;
            }
            UctClientes.instancia.BringToFront();
        }

        private void btnAgendaOS_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctAgendaOS.instancia))
            {
                pnlUC.Controls.Add(UctAgendaOS.instancia);
                UctAgendaOS.instancia.Dock = DockStyle.Fill;
            }
            UctAgendaOS.instancia.BringToFront();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            if (Modulo.TemRestricao(2))
            {
                FormLogin login = new FormLogin();
                login.ID_Modulo = 1;
                login.Action = "Acesso";
                DialogResult respLog = login.ShowDialog();
                if (respLog == DialogResult.Yes)
                {
                    UctUsuarios();
                }
            }
            else
            {
                UctUsuarios();
            }
        }

        private void UctUsuarios()
        {
            if (!pnlUC.Controls.Contains(UctUsuario.instancia))
            {
                pnlUC.Controls.Add(UctUsuario.instancia);
                UctUsuario.instancia.Dock = DockStyle.Fill;
            }
            UctUsuario.instancia.BringToFront();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctServicos.instancia))
            {
                pnlUC.Controls.Add(UctServicos.instancia);
                UctServicos.instancia.Dock = DockStyle.Fill;
            }
            UctServicos.instancia.BringToFront();


        }

        private void frmAgendaOs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnLogout.PerformClick();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            pPerfilUsuario.Show();
        }

        private void pPerfilUsuario_MouseLeave(object sender, EventArgs e)
        {
            tPerfilHide.Start();
        }

        private void tPerfilHide_Tick(object sender, EventArgs e)
        {
            tPerfilHide.Stop();
            pPerfilUsuario.Hide();
        }

        private void pPerfilUsuario_MouseEnter(object sender, EventArgs e)
        {
            tPerfilHide.Stop();
        }
    }
}
