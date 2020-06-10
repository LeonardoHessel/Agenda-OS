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

        public uctTecnicos()
        {
            InitializeComponent();
            CarregarTecnicos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Tecnico tec = new Tecnico();
            frmTecnico frm = new frmTecnico(tec,"New");
            frm.ShowDialog();
            CarregarTecnicos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tecnico tec = new Tecnico();
            tec.codigo = 1;
            tec.nome = "Leonardo Dias de Lemos Hessel";
            tec.nasc = new DateTime();
            tec.sexo = "Masculino";
            tec.rg = "446668889";
            tec.cpf = "11122233344";
            tec.cnh = "11122233344";
            frmTecnico frm = new frmTecnico(tec,"Edit");
            frm.ShowDialog();
        }

        private void CarregarTecnicos()
        {
            dgvTecnico.DataSource = Tecnico.TabelaTodosTecnico();
        }
    }
}
