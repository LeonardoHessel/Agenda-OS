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
    public partial class UctServicos : UserControl
    {
        private static UctServicos _instancia;

        public static UctServicos instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UctServicos();
                }
                return _instancia;
            }
        }

        public UctServicos()
        {
            InitializeComponent();
        }
    }
}
