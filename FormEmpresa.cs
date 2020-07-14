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

        public FormEmpresa(Empresa empresa, string acao)
        {
            InitializeComponent();
            this.Empresa = empresa;
            this.Acao = acao;
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
                HabilitarCampos(true);
                btnDeletar.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else if (this.Acao == "Editar")
            {
                ExibirEmpresa();
                HabilitarCampos(true);
                btnEditar.Enabled = false;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else if (this.Acao == "Visualizar")
            {
                ExibirEmpresa();
                HabilitarCampos(false);
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
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
            if (true) // Verificar Permisao
            {
                SetEmpresa();
                if (this.Empresa.SalvarEmpresa(this.Acao))
                {
                    ExibirEmpresa();
                    this.Acao = "Visualizar";
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
            //this.Empresa = new Empresa();
            this.Empresa.CNPJ = rtnNoMask(mtbCNPJ);
            this.Empresa.IE = rtnNoMask(mtbIE);
            this.Empresa.Razao = txtRazao.Text;
            this.Empresa.Nome = txtNome.Text;
            this.Empresa.Regime = cbRegime.Text;
            this.Empresa.ID_Contador = 0; // Contador definico como 0 -----------
            this.Empresa.Telefone = txtTelefone.Text;
            this.Empresa.Email = txtEmail.Text;
            this.Empresa.Observacao = txtObservacao.Text;
        }

        private void ExibirEmpresa()
        {
            labID.Text = this.Empresa.ID.ToString();
            mtbCNPJ.Text = this.Empresa.CNPJ;
            mtbIE.Text = this.Empresa.IE;
            txtRazao.Text = this.Empresa.Razao;
            txtNome.Text = this.Empresa.Nome;
            cbRegime.Text = this.Empresa.Regime;
            //cbContador.Text = this.Empresa.Contador.Nome;
            txtTelefone.Text = this.Empresa.Telefone;
            txtEmail.Text = this.Empresa.Email;
            txtObservacao.Text = this.Empresa.Observacao;
        }

        private void HabilitarCampos(bool vf)
        {
            labID.Enabled = vf;
            mtbCNPJ.Enabled = vf;
            mtbIE.Enabled = vf;
            txtRazao.Enabled = vf;
            txtNome.Enabled = vf;
            cbRegime.Enabled = vf;
            cbContador.Enabled = vf;
            txtTelefone.Enabled = vf;
            txtEmail.Enabled = vf;
            txtObservacao.Enabled = vf;
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Acao = "Editar";
        }
    }
}
