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
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctClientes.Instancia))
            {
                pnlUC.Controls.Add(UctClientes.Instancia);
                UctClientes.Instancia.Dock = DockStyle.Fill;
            }
            UctClientes.Instancia.BringToFront();
        }

        private void btnAgendaOS_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctAgendaOS.Instancia))
            {
                pnlUC.Controls.Add(UctAgendaOS.Instancia);
                UctAgendaOS.Instancia.Dock = DockStyle.Fill;
            }
            UctAgendaOS.Instancia.BringToFront();
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
            if (!pnlUC.Controls.Contains(UctUsuario.Instancia))
            {
                pnlUC.Controls.Add(UctUsuario.Instancia);
                UctUsuario.Instancia.Dock = DockStyle.Fill;
            }
            UctUsuario.Instancia.BringToFront();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (!pnlUC.Controls.Contains(UctProdutos.Instancia))
            {
                pnlUC.Controls.Add(UctProdutos.Instancia);
                UctProdutos.Instancia.Dock = DockStyle.Fill;
            }
            UctProdutos.Instancia.BringToFront();
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
