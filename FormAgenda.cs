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
            this.WindowState = FormWindowState.Maximized;
        }


        public static Usuario usuario;
        public static List<Permissao> Permissoes { get; set; }
        public Usuario Usuario
        {
            get { return FormAgenda.usuario; }
            set
            {
                FormAgenda.usuario = value;
            }
        }

        private void frmAgendaOs_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (!pForm.Controls.Contains(UctClientes.Instancia))
            {
                pForm.Controls.Add(UctClientes.Instancia);
                UctClientes.Instancia.Dock = DockStyle.Fill;
            }
            UctClientes.Instancia.BringToFront();
            UctClientes.Instancia.Visible = true;
        }

        private void btnAgendaOS_Click(object sender, EventArgs e)
        {
            if (!pForm.Controls.Contains(UctAgendaOS.Instancia))
            {
                pForm.Controls.Add(UctAgendaOS.Instancia);
                UctAgendaOS.Instancia.Dock = DockStyle.Fill;
            }
            UctAgendaOS.Instancia.BringToFront();
            UctAgendaOS.Instancia.Visible = true;
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
            if (!pForm.Controls.Contains(UctUsuario.Instancia))
            {
                pForm.Controls.Add(UctUsuario.Instancia);
                UctUsuario.Instancia.Dock = DockStyle.Fill;
            }
            UctUsuario.Instancia.BringToFront();
            UctUsuario.Instancia.Visible = true;
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (!pForm.Controls.Contains(UctProdutos.Instancia))
            {
                pForm.Controls.Add(UctProdutos.Instancia);
                UctProdutos.Instancia.Dock = DockStyle.Fill;
            }
            UctProdutos.Instancia.BringToFront();
            UctProdutos.Instancia.Visible = true;
        }

        private void frmAgendaOs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            }
        }

        private void tHoraSistema_Tick(object sender, EventArgs e)
        {
            labHora.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente fechar o sistema?", "Sair", MessageBoxButtons.YesNo);
            if (resp != DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void btnOS_KeyDown(object sender, KeyEventArgs e)
        {
            //for ctrl + s
            if (e.KeyData == Keys.ControlKey && e.Modifiers == Keys.S)
            {
                btnProdutos.PerformClick();
            }
        }
    }
}
