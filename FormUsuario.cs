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
using Agenda_OS.Properties;

namespace Agenda_OS
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private string action;
        private Usuario usuario;
        private string endImagem;
        
        public string Action
        {
            get { return this.action; }
            set
            {
                this.action = value;
                SetForm();
            }
        }

        private string EnderecoIMG
        {
            get { return endImagem; }
            set
            {
                this.endImagem = value;
                if (value == null || value == "")
                {
                    pbxFoto.Image = Resources.AddFoto_48px;
                }
                else
                {
                    var stream = File.OpenRead(value);
                    pbxFoto.Image = Image.FromStream(stream);
                    stream.Dispose();
                }
            }
        }

        public Usuario Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        private void SetForm()
        {
            if (this.Action == "Novo")
            {
                cmbSexo.SelectedIndex = 0;
                labResetarLoginSenha.Hide();
                labResetarLoginSenha.Enabled = false;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                btnEditar.Enabled = false;
                btnInativarAtivar.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Cadastrar";
            }
            else if (this.Action == "Visualizar")
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
                
                btnInativarAtivar.Enabled = true;
                btnSalvar.Enabled = false;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Editar";
                
                if (this.Usuario.Ativo)
                {
                    btnInativarAtivar.Text = "Inativar";
                    btnEditar.Enabled = true;
                }
                else
                {
                    btnInativarAtivar.Text = "Ativar";
                    btnEditar.Enabled = false;
                }
                
            }
            else if (this.Action == "Editar")
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
                btnInativarAtivar.Enabled = false;
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
            
            string sexo = cmbSexo.Text;
            if (sexo == "Masculino" || sexo == "Feminino")
                this.usuario.Sexo = sexo;
            else
                this.usuario.Sexo = null;
            
            this.usuario.RG = rtnNoMask(mtbRG);
            this.usuario.CPF = rtnNoMask(mtbCPF);
            this.usuario.CNH = rtnNoMask(mtbCNH);

            string imgEndereco = this.EnderecoIMG;
            if (imgEndereco == "" || imgEndereco == null)
            {
                this.usuario.PerfilIMG = null;
            }
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
            txtID.Text = this.usuario.ID.ToString();
            txtLogin.Text = this.usuario.Login;
            txtSenha.Text = this.usuario.Senha;
            txtNome.Text = this.usuario.Nome;
            if (this.usuario.Sexo == null)
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
            if (true)
            {
                if (this.Action == "Novo")
                {
                    if (this.usuario.Inserir())
                    {
                        this.Action = "Visualizar";
                    }
                    else
                    {
                        MessageBox.Show(Conexao.msg);
                        btnSalvar.Enabled = true;
                    }
                }
                else
                {
                    if (this.usuario.Atualizar())
                    {
                        this.Action = "Visualizar";
                    }
                    else
                    {
                        MessageBox.Show(Conexao.msg);
                        btnSalvar.Enabled = true;
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Login não disponivel.\n Escolha outro para continuar o cadastro.");
            //    btnSalvar.Enabled = true;
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.Action == "Editar")
            {
                this.Action = "Visualizar";
            }
            else
            {
                this.Action = "Editar";
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
                btnInativarAtivar.PerformClick();
            }
        }

        private void labResetarLoginSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            //if (this.Action == "Editar")
            //{
            //    DialogResult res = ofdBuscaArquivo.ShowDialog();
            //    if (res == DialogResult.OK)
            //    {
            //        EnderecoIMG = ofdBuscaArquivo.FileName;
            //    }
            //}
        }

        private void btnInativarAtivar_Click(object sender, EventArgs e)
        {
            FormAgenda.usuario.LoadPermissoesUsuario();
            Permissao permissao = FormAgenda.usuario.Permissoes.Find(x => x.ID_Modulo == 4);
            if (permissao.Acesso)
            {
                if (this.Usuario.ID != FormAgenda.usuario.ID)
                {
                    if (this.Usuario.AlterarStatus())
                    {
                        this.Action = "Visualizar";
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel inativar o um usuário logado");
                }
            }
            else
            {
                MessageBox.Show("Exemplo: O seu usuário não possue a permissão para inativar outros usuários");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
