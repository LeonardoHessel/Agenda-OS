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
    public partial class FormUsuario : Form
    {
        private Usuario usuario;
        private String endImagem;
        private String EnderecoIMG
        {
            get { return endImagem; }
            set
            {
                this.endImagem = value;
                if (value != null)
                {
                    var stream = File.OpenRead(value);
                    pbxFoto.Image = Image.FromStream(stream);
                    stream.Dispose();
                }
            }
        }
        
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
        
        public FormUsuario(Usuario usuario, string action)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Action = action;
        }

        private void SetForm()
        {
            if (this.Action == "New")
            {
                cmbSexo.SelectedIndex = 0;
                labResetarLoginSenha.Hide();
                labResetarLoginSenha.Enabled = false;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Cadastrar";
            }
            else if (this.Action == "Show")
            {
                ShowUsuario();
                labResetarLoginSenha.Hide();
                labResetarLoginSenha.Enabled = false;
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
                txtNome.Enabled = false;
                dtpNasc.Enabled = false;
                cmbSexo.Enabled = false;
                mtbRG.Enabled = false;
                mtbCPF.Enabled = false;
                mtbCNH.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Editar";
            }
            else if (this.Action == "Edit")
            {
                ShowUsuario();
                labResetarLoginSenha.Show();
                labResetarLoginSenha.Enabled = true;
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
                txtNome.Enabled = true;
                dtpNasc.Enabled = true;
                cmbSexo.Enabled = true;
                mtbRG.Enabled = true;
                mtbCPF.Enabled = true;
                mtbCNH.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Cancelar";
                VerificarUsuario();
            }
        }

        private void SetUsuario()
        {
            this.usuario.Login = txtLogin.Text;
            this.usuario.Senha = txtSenha.Text;
            this.usuario.Nome = txtNome.Text;
            this.usuario.Nasc = dtpNasc.Value;
            this.usuario.Sexo = cmbSexo.Text;
            this.usuario.RG = rtnNoMask(mtbRG);
            this.usuario.CPF = rtnNoMask(mtbCPF);
            this.usuario.CNH = rtnNoMask(mtbCNH);
            // Foto Perfil
            string caminho = @"..\..\Imagens\usuarios\";
            string nome = this.usuario.ID.ToString();
            if (caminho + nome != this.EnderecoIMG)
            {
                if (ofdImagenPerfil.FileName != "")
                {
                    File.Copy(EnderecoIMG, caminho + nome, true);
                    this.usuario.PerfilIMG = caminho + nome;
                }
            }
            // fim
        }

        private void VerificarUsuario()
        {
            if (FormAgenda.usuario.ID == usuario.ID)
            {
                labResetarLoginSenha.Hide();
                labResetarLoginSenha.Enabled = false;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
            }
        }

        private void ShowUsuario()
        {
            labCOD.Text = this.usuario.ID.ToString();
            txtLogin.Text = this.usuario.Login;
            txtSenha.Text = this.usuario.Senha;
            txtNome.Text = this.usuario.Nome;
            if (this.usuario.Sexo == "")
            {
                cmbSexo.SelectedIndex = 0;
            }
            else
            {
                cmbSexo.Text = this.usuario.Sexo;
            }

            dtpNasc.Value = this.usuario.Nasc;
            mtbRG.Text = this.usuario.RG;
            mtbCPF.Text = this.usuario.CPF;
            mtbCNH.Text = this.usuario.CNH;
            EnderecoIMG = this.usuario.PerfilIMG;
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
            if (this.usuario.VerificarLogin() == 0 || this.Action == "Edit")
            {
                if (this.usuario.SalvarUsuario(this.Action))
                {
                    this.Action = "Show";
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

        private void frmTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (btnEditar.Text == "Cancelar")
                {
                    btnEditar.PerformClick();
                }
                else
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.F2 && btnEditar.Text == "Editar")
            {
                btnEditar.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSalvar.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnExcluir.PerformClick();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnExcluir");
        }

        private void labResetarLoginSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            if (this.Action == "Edit")
            {
                DialogResult res = ofdImagenPerfil.ShowDialog();
                if (res == DialogResult.OK)
                {
                    EnderecoIMG = ofdImagenPerfil.FileName;
                }
            }
        }
    }
}
