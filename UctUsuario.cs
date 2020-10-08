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
        public UctUsuario()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private static UctUsuario instancia;
        public static UctUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new UctUsuario();
                }
                return instancia;
            }
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.Usuario = new Usuario();
            frm.Action = "Novo";
            frm.ShowDialog();
            CarregarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.Usuario = dgvTecnico.CurrentRow.DataBoundItem as Usuario;
            frm.Action = "Editar";
            frm.ShowDialog();
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            string status = "Todos";
            
            if (rbInativos.Checked)
                status = "Inativos";
            else if (rbAtivos.Checked)
                status = "Ativos";

            string busca = txtBusca.Text;
            dgvTecnico.DataSource = Usuario.TodosUsuarios(status, busca);
        }

        private void dgvTecnico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormUsuario frm = new FormUsuario();
            frm.Usuario = dgvTecnico.CurrentRow.DataBoundItem as Usuario;
            frm.Action = "Visualizar";
            frm.ShowDialog();
            CarregarUsuarios();
        }

        private void option_Changed(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
    }
}
