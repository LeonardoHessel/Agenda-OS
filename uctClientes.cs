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

        private void RemoverCampos() {
            dgvClientes.Columns.Remove("id");
            dgvClientes.Columns.Remove("razao");
            dgvClientes.Columns.Remove("cnpj");
            dgvClientes.Columns.Remove("nome");
            dgvClientes.Columns.Remove("endereco");
            dgvClientes.Columns.Remove("celular");
            dgvClientes.Columns.Remove("telefone");
            dgvClientes.Columns.Remove("cep");
        }
        private void CarregarEmpresa()
        {
            this.listarempresa = Empresa.ListaEmpresa();
            dgvClientes.DataSource = this.listarempresa;
        }

        public UctClientes()
        {
            InitializeComponent();
            CarregarEmpresa();
            RemoverCampos();



        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormClientes frmclientes = new FormClientes();
            frmclientes.ShowDialog();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvClientes.CurrentRow.Index;
            long id = Convert.ToInt64(dgvClientes.CurrentRow.Cells["ID"].Value);
            FormClientes frm = new FormClientes(Empresa, "Show");
            frm.ShowDialog();
            CarregarEmpresa();
            dgvClientes.ClearSelection();
            dgvClientes.CurrentCell = dgvClientes[0, linha];
            dgvClientes.Rows[linha].Selected = true;

        }

        
    }
}
