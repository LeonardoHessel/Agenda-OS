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
    public partial class UctClientes : UserControl
    {
        private static UctClientes _instancia;

        public static UctClientes instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctClientes();
                }
                return _instancia;
            }
        }

        public UctClientes()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormEmpresa emp = new FormEmpresa();
            emp.Acao = "Novo";
            emp.ShowDialog();
        }
    }
}
