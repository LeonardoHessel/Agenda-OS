﻿using System;
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

        private List<Empresa> listarempresa { get; set; }
  

        private void CarregarEmpresa()
        {
            this.listarempresa = Empresa.ListaEmpresa();
            dgvClientes.DataSource = this.listarempresa;
            
        }

        public UctClientes()
        {
            InitializeComponent();
            CarregarEmpresa();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormClientes frmclientes = new FormClientes();
            frmclientes.ShowDialog();
        }

    }
}
