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
        
        public frmTecnico(Tecnico tecnico, string action)
        {
            InitializeComponent();
            this.tecnico = tecnico;
            SetForm(action);
        }
        
        private void frmTecnico_Load(object sender, EventArgs e)
        {

        }

        private void SetForm(string action)
        {
            if (action == "New")
            {                
                btnSalvar.Text = "Cadastrar";
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else if (action == "Show")
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else if (action == "Edit")
            {
                ShowUsuario();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
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
            this.tecnico.nome = txtNome.Text;
            this.tecnico.nasc = dtpNasc.Value;
            this.tecnico.sexo = cmbSexo.Text;
            this.tecnico.rg = rtnNoMask(mtbRG);
            this.tecnico.cpf = rtnNoMask(mtbCPF);            
            this.tecnico.cnh = rtnNoMask(mtbCNH);


            MessageBox.Show(this.tecnico.codigo.ToString());
            if (this.tecnico.SalvarTec())
            {
                btnSalvar.Text = "Salvar";
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                labCOD.Text = tecnico.codigo.ToString();
            }
            else
            {
                MessageBox.Show("Falha ao conectar com o servidor.\nVerifique sua conexão com o servidor.");
            }
        }

        private void ShowUsuario()
        {
            txtNome.Text = this.tecnico.nome;
            cmbSexo.Text = this.tecnico.sexo;
            mtbRG.Text = this.tecnico.rg;
            mtbCPF.Text = this.tecnico.nome;
            mtbCNH.Text = this.tecnico.nome;
            MessageBox.Show(this.tecnico.nome);
            MessageBox.Show(this.tecnico.nasc.ToString());
            MessageBox.Show(this.tecnico.sexo);
            MessageBox.Show(this.tecnico.rg);
            MessageBox.Show(this.tecnico.cpf);
            MessageBox.Show(this.tecnico.cnh);
        }
    }
}
