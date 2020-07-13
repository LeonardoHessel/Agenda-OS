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
        private Empresa empresa;
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

        private void SetForm()
        {

            if (this.Action == "Edit")
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
            lbl_id.Text = this.empresa.ID.ToString();
            txt_razao.Text = this.empresa.Razao;
            txt_nome.Text = this.empresa.Nome;
            mtb_cnpj.Text = this.empresa.CNPJ;

            //DataBindings.Value = this.tecnico.Nasc;
            txt_endereco.Text = this.empresa.Endereco;
            mtb_cep.Text = this.empresa.CEP;
            mtb_telefone.Text = this.empresa.Telefone;
            mtb_celular.Text = this.empresa.Celular;
        }

        private void SetUsuario()
        {
            this.empresa.CNPJ = rtnNoMask(mtb_cnpj);
            this.empresa.Razao = txt_razao.Text;
            this.empresa.Nome = txt_nome.Text;
            this.empresa.Endereco = txt_endereco.Text;
            this.empresa.CEP = rtnNoMask(mtb_cep);
            this.empresa.Telefone = rtnNoMask(mtb_telefone);
            this.empresa.Celular = rtnNoMask(mtb_celular);
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
            btnSalvar.Enabled = false;
            SetUsuario();
            if (this.Action == "Edit")
            {
                if (this.empresa.SalvarEmpresa(this.Action))
                {
                    this.Action = "Show";
                }
                else
                {
                    MessageBox.Show(Conexao.msg);
                    btnSalvar.Enabled = true;
                }
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

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
