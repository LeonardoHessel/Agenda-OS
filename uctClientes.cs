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
    public partial class uctClientes : UserControl
    {
        private static uctClientes _instancia;

        public static uctClientes instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new uctClientes();
                }
                return _instancia;
            }
        }

        public uctClientes()
        {
            InitializeComponent();
        }
    }
}
