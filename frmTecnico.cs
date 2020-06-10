using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class frmTecnico : Form
    {
        private Tecnico tecnico;

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
        
        public frmTecnico(Tecnico tecnico, string action)
        {
            InitializeComponent();
            this.tecnico = tecnico;
            this.Action = action;
        }

        private void SetForm()
        {
            if (this.Action == "New")
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Cadastrar";
            }
            else if (this.Action == "Show")
            {
                ShowUsuario();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnSalvar.Text = "Salvar";
            }
            else if (this.Action == "Edit")
            {
                ShowUsuario();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Salvar";
            }
        }

        private void SetUsuario()
        {
            this.tecnico.nome = txtNome.Text;
            this.tecnico.nasc = dtpNasc.Value;
            this.tecnico.sexo = cmbSexo.Text;
            this.tecnico.rg = rtnNoMask(mtbRG);
            this.tecnico.cpf = rtnNoMask(mtbCPF);
            this.tecnico.cnh = rtnNoMask(mtbCNH);
        }

        private void ShowUsuario()
        {
            labCOD.Text = this.tecnico.codigo.ToString();
            txtNome.Text = this.tecnico.nome;
            cmbSexo.Text = this.tecnico.sexo;
            dtpNasc.Value = this.tecnico.nasc;
            mtbRG.Text = this.tecnico.rg;
            mtbCPF.Text = this.tecnico.cpf;
            mtbCNH.Text = this.tecnico.cnh;
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
            SetUsuario();
            if (this.tecnico.SalvarTec(this.Action))
            {
                this.Action = "Show";
            }
            else
            {
                MessageBox.Show(Conexao.msg);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Action = "Edit";
        }
    }
}
