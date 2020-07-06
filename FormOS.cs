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
    public partial class FormOS : Form
    {
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        public Empresa Empresa { get; set; }

        public Usuario Usuario { get; set; }

        public FormOS()
        {
            InitializeComponent();
        }

        private void FormOS_Load(object sender, EventArgs e)
        {

        }

        private void FormOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
