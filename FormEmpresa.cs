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
    public partial class FormEmpresa : Form
    {
        public Empresa Empresa { get; set; }
        public Usuario Usuario { get; set; }

        private string acao;

        public FormEmpresa()
        {
            InitializeComponent();
        }

        public string Acao
        {
            get { return acao; }
            set
            {
                acao = value;
                DefinirFormulario();
            }
        }

        private void DefinirFormulario()
        {
            if (this.Acao == "Novo")
            {
                
            }
            else if (this.Acao == "Editar")
            {
                MessageBox.Show("Editar Empresa");
            }
            else if (this.Acao == "Visualizar")
            {
                MessageBox.Show("Nova Empresa");
            }
        }

        private void FormEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar.PerformClick();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            this.Acao = "Visualizar";
            if (true) // Verificar Permisao
            {
                SetEmpresa();
                if (this.Empresa.SalvarEmpresa(this.Acao))
                {
                    
                }
                else
                {
                    MessageBox.Show(Conexao.msg);
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Login não disponivel.\n Escolha outro para continuar o cadastro.");
                btnSalvar.Enabled = true;
            }
        }

        private void SetEmpresa()
        {
            this.Empresa.CNPJ = rtnNoMask(txtCNPJ);
            this.Empresa.IE = rtnNoMask(txtIE);
            this.Empresa.Razao = txtRazao.Text;
            this.Empresa.Nome = txtNome.Text;
            this.Empresa.Regime = cbRegime.Text;
            this.Empresa.ID_Contador = 0;
            this.Empresa.Telefone = txtTelefone.Text;
            this.Empresa.Email = txtEmail.Text;
            this.Empresa.Observacao = txtObservacao.Text;
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }
    }
}
