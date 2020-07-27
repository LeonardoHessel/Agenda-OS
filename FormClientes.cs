using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media.Imaging;


namespace Agenda_OS
{
    public partial class FormClientes : Form
    {
        private Empresa cliente;
        private string action;
        private string Action
        {
            get { return this.action; }
            set
            {
                this.action = value;
                SetForm();
            }
        }

        public FormClientes(Empresa cliente, string action)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.Action = action;
        }

        private void SetForm()
        {
            if (this.Action == "New")
            {
                btnSalvar.Text = "Cadastrar";
            }
            else if (this.Action == "Show")
            {
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Editar";
            }

            else if (this.Action == "Edit")
            {
                MostrarEmpresa();
                txt_razao.Enabled = false;
                txt_endereco.Enabled = false;
                txt_nome.Enabled = true;
                mtb_celular.Enabled = true;
                mtb_cep.Enabled = true;
                mtb_telefone.Enabled = true;
                mtb_cnpj.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Cancelar";
            }
        }
        //essa função vai mostrar no formulario com os dados da empresa
        private void MostrarEmpresa()
        {
            lbl_id.Text = this.cliente.ID.ToString();
            txt_razao.Text = this.cliente.Razao;
            txt_nome.Text = this.cliente.Nome;
            mtb_cnpj.Text = this.cliente.CNPJ;

            //DataBindings.Value = this.tecnico.Nasc;
            txt_endereco.Text = this.cliente.Endereco;
            mtb_cep.Text = this.cliente.CEP;
            mtb_telefone.Text = this.cliente.Telefone;
            mtb_celular.Text = this.cliente.Celular;
            MessageBox.Show("Cheguei");
        }

        private void SetEmpresa()
        {
            this.cliente.CNPJ = rtnNoMask(mtb_cnpj);
            this.cliente.Razao = txt_razao.Text;
            this.cliente.Nome = txt_nome.Text;
            this.cliente.Endereco = txt_endereco.Text;
            this.cliente.CEP = rtnNoMask(mtb_cep);
            this.cliente.Telefone = rtnNoMask(mtb_telefone);
            this.cliente.Celular = rtnNoMask(mtb_celular);
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetEmpresa();
            if (this.cliente.SalvarEmpresa(this.Action)) {
                this.action = "New";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.Action == "Edit")
            {
                this.Action = "Show";
            }
            else
            {
                this.Action = "Edit";
            }
        }


    }
}
