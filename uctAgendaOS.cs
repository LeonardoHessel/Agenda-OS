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
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            FormOS os = new FormOS();
            os.ShowDialog();
        }
    }
}
