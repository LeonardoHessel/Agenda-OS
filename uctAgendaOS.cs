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
    public partial class uctAgendaOS : UserControl
    {
        private static uctAgendaOS _instancia;

        public static uctAgendaOS instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new uctAgendaOS();
                }
                return _instancia;
            }
        }

        public uctAgendaOS()
        {
            InitializeComponent();
        }
    }
}
