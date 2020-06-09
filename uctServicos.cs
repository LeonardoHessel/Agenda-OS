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
    public partial class uctServicos : UserControl
    {
        private static uctServicos _instancia;

        public static uctServicos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new uctServicos();
                }
                return _instancia;
            }
        }

        public uctServicos()
        {
            InitializeComponent();
        }
    }
}
