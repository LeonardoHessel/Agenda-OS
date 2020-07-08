namespace Agenda_OS
{
    partial class FormOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.labId = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labOSid = new System.Windows.Forms.Label();
            this.pRodape = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQuem = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labEmpresa = new System.Windows.Forms.Label();
            this.labAssunto = new System.Windows.Forms.Label();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.labQuem = new System.Windows.Forms.Label();
            this.labDescricao = new System.Windows.Forms.Label();
            this.labSolucao = new System.Windows.Forms.Label();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalizado = new System.Windows.Forms.DateTimePicker();
            this.labAbertura = new System.Windows.Forms.Label();
            this.labFechamento = new System.Windows.Forms.Label();
            this.labSituacao = new System.Windows.Forms.Label();
            this.labProduto = new System.Windows.Forms.Label();
            this.labAtendimento = new System.Windows.Forms.Label();
            this.cbAtendimento = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(338, 81);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(320, 25);
            this.cbUsuario.TabIndex = 0;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(338, 136);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(320, 25);
            this.txtAssunto.TabIndex = 1;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(12, 81);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(289, 25);
            this.txtEmpresa.TabIndex = 2;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(12, 136);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(140, 25);
            this.txtCNPJ.TabIndex = 3;
            this.txtCNPJ.TabStop = false;
            this.txtCNPJ.Text = "00.000.000/0000-00";
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pTitulo.Controls.Add(this.labId);
            this.pTitulo.Controls.Add(this.labTitulo);
            this.pTitulo.Controls.Add(this.labOSid);
            this.pTitulo.Controls.Add(this.btnFechar);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(670, 50);
            this.pTitulo.TabIndex = 4;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.ForeColor = System.Drawing.Color.White;
            this.labId.Location = new System.Drawing.Point(552, 11);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(23, 25);
            this.labId.TabIndex = 3;
            this.labId.Text = "0";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.White;
            this.labTitulo.Location = new System.Drawing.Point(7, 11);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(162, 25);
            this.labTitulo.TabIndex = 1;
            this.labTitulo.Text = "Ordem de Seviço";
            // 
            // labOSid
            // 
            this.labOSid.AutoSize = true;
            this.labOSid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOSid.ForeColor = System.Drawing.Color.White;
            this.labOSid.Location = new System.Drawing.Point(483, 11);
            this.labOSid.Name = "labOSid";
            this.labOSid.Size = new System.Drawing.Size(63, 25);
            this.labOSid.TabIndex = 2;
            this.labOSid.Text = "OS nº";
            // 
            // pRodape
            // 
            this.pRodape.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRodape.Location = new System.Drawing.Point(0, 424);
            this.pRodape.Name = "pRodape";
            this.pRodape.Size = new System.Drawing.Size(670, 20);
            this.pRodape.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 190);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(320, 90);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtQuem
            // 
            this.txtQuem.Location = new System.Drawing.Point(158, 136);
            this.txtQuem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuem.Name = "txtQuem";
            this.txtQuem.Size = new System.Drawing.Size(174, 25);
            this.txtQuem.TabIndex = 7;
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(12, 309);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(261, 25);
            this.cbProduto.TabIndex = 9;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(458, 309);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(200, 25);
            this.cbSituacao.TabIndex = 10;
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(335, 60);
            this.labUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(53, 17);
            this.labUsuario.TabIndex = 11;
            this.labUsuario.Text = "Usuário";
            // 
            // labEmpresa
            // 
            this.labEmpresa.AutoSize = true;
            this.labEmpresa.Location = new System.Drawing.Point(9, 60);
            this.labEmpresa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labEmpresa.Name = "labEmpresa";
            this.labEmpresa.Size = new System.Drawing.Size(59, 17);
            this.labEmpresa.TabIndex = 13;
            this.labEmpresa.Text = "Empresa";
            // 
            // labAssunto
            // 
            this.labAssunto.AutoSize = true;
            this.labAssunto.Location = new System.Drawing.Point(335, 115);
            this.labAssunto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labAssunto.Name = "labAssunto";
            this.labAssunto.Size = new System.Drawing.Size(54, 17);
            this.labAssunto.TabIndex = 14;
            this.labAssunto.Text = "Assunto";
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(9, 115);
            this.labCNPJ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(37, 17);
            this.labCNPJ.TabIndex = 15;
            this.labCNPJ.Text = "CNPJ";
            // 
            // labQuem
            // 
            this.labQuem.AutoSize = true;
            this.labQuem.Location = new System.Drawing.Point(155, 115);
            this.labQuem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labQuem.Name = "labQuem";
            this.labQuem.Size = new System.Drawing.Size(98, 17);
            this.labQuem.TabIndex = 16;
            this.labQuem.Text = "Quem solicitou:";
            // 
            // labDescricao
            // 
            this.labDescricao.AutoSize = true;
            this.labDescricao.Location = new System.Drawing.Point(9, 170);
            this.labDescricao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labDescricao.Name = "labDescricao";
            this.labDescricao.Size = new System.Drawing.Size(65, 17);
            this.labDescricao.TabIndex = 17;
            this.labDescricao.Text = "Descrição";
            // 
            // labSolucao
            // 
            this.labSolucao.AutoSize = true;
            this.labSolucao.Location = new System.Drawing.Point(335, 170);
            this.labSolucao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labSolucao.Name = "labSolucao";
            this.labSolucao.Size = new System.Drawing.Size(54, 17);
            this.labSolucao.TabIndex = 20;
            this.labSolucao.Text = "Solução";
            // 
            // txtSolucao
            // 
            this.txtSolucao.Location = new System.Drawing.Point(338, 190);
            this.txtSolucao.Multiline = true;
            this.txtSolucao.Name = "txtSolucao";
            this.txtSolucao.Size = new System.Drawing.Size(320, 90);
            this.txtSolucao.TabIndex = 19;
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.CustomFormat = "  dd/MM/yyyy  hh:mm:s";
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbertura.Location = new System.Drawing.Point(279, 309);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(173, 25);
            this.dtpAbertura.TabIndex = 22;
            // 
            // dtpFinalizado
            // 
            this.dtpFinalizado.CustomFormat = "  dd/MM/yyyy  hh:mm:s";
            this.dtpFinalizado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinalizado.Location = new System.Drawing.Point(279, 364);
            this.dtpFinalizado.Name = "dtpFinalizado";
            this.dtpFinalizado.Size = new System.Drawing.Size(173, 25);
            this.dtpFinalizado.TabIndex = 23;
            // 
            // labAbertura
            // 
            this.labAbertura.AutoSize = true;
            this.labAbertura.Location = new System.Drawing.Point(276, 289);
            this.labAbertura.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labAbertura.Name = "labAbertura";
            this.labAbertura.Size = new System.Drawing.Size(59, 17);
            this.labAbertura.TabIndex = 25;
            this.labAbertura.Text = "Abertura";
            // 
            // labFechamento
            // 
            this.labFechamento.AutoSize = true;
            this.labFechamento.Location = new System.Drawing.Point(276, 343);
            this.labFechamento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labFechamento.Name = "labFechamento";
            this.labFechamento.Size = new System.Drawing.Size(78, 17);
            this.labFechamento.TabIndex = 26;
            this.labFechamento.Text = "Fechamento";
            // 
            // labSituacao
            // 
            this.labSituacao.AutoSize = true;
            this.labSituacao.Location = new System.Drawing.Point(455, 288);
            this.labSituacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labSituacao.Name = "labSituacao";
            this.labSituacao.Size = new System.Drawing.Size(57, 17);
            this.labSituacao.TabIndex = 27;
            this.labSituacao.Text = "Situação";
            // 
            // labProduto
            // 
            this.labProduto.AutoSize = true;
            this.labProduto.Location = new System.Drawing.Point(9, 288);
            this.labProduto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labProduto.Name = "labProduto";
            this.labProduto.Size = new System.Drawing.Size(55, 17);
            this.labProduto.TabIndex = 28;
            this.labProduto.Text = "Produto";
            // 
            // labAtendimento
            // 
            this.labAtendimento.AutoSize = true;
            this.labAtendimento.Location = new System.Drawing.Point(9, 343);
            this.labAtendimento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labAtendimento.Name = "labAtendimento";
            this.labAtendimento.Size = new System.Drawing.Size(82, 17);
            this.labAtendimento.TabIndex = 30;
            this.labAtendimento.Text = "Atendimento";
            // 
            // cbAtendimento
            // 
            this.cbAtendimento.FormattingEnabled = true;
            this.cbAtendimento.Location = new System.Drawing.Point(12, 364);
            this.cbAtendimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAtendimento.Name = "cbAtendimento";
            this.cbAtendimento.Size = new System.Drawing.Size(261, 25);
            this.cbAtendimento.TabIndex = 29;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Image = global::Agenda_OS.Properties.Resources.TrashX32;
            this.btnDeletar.Location = new System.Drawing.Point(496, 364);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(50, 50);
            this.btnDeletar.TabIndex = 34;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Agenda_OS.Properties.Resources.EditX32;
            this.btnEditar.Location = new System.Drawing.Point(552, 364);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Agenda_OS.Properties.Resources.SaveX32;
            this.btnSalvar.Location = new System.Drawing.Point(608, 364);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Image = global::Agenda_OS.Properties.Resources.SearchX16;
            this.btnPesquisa.Location = new System.Drawing.Point(307, 81);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Agenda_OS.Properties.Resources.CloseX32;
            this.btnFechar.Location = new System.Drawing.Point(620, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 444);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labAtendimento);
            this.Controls.Add(this.cbAtendimento);
            this.Controls.Add(this.labProduto);
            this.Controls.Add(this.labSituacao);
            this.Controls.Add(this.labFechamento);
            this.Controls.Add(this.labAbertura);
            this.Controls.Add(this.dtpFinalizado);
            this.Controls.Add(this.dtpAbertura);
            this.Controls.Add(this.labSolucao);
            this.Controls.Add(this.txtSolucao);
            this.Controls.Add(this.labDescricao);
            this.Controls.Add(this.labQuem);
            this.Controls.Add(this.labCNPJ);
            this.Controls.Add(this.labAssunto);
            this.Controls.Add(this.labEmpresa);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtQuem);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.pRodape);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.cbUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OS";
            this.Load += new System.EventHandler(this.FormOS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOS_KeyDown);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pRodape;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtQuem;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.Label labEmpresa;
        private System.Windows.Forms.Label labAssunto;
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.Label labQuem;
        private System.Windows.Forms.Label labDescricao;
        private System.Windows.Forms.Label labSolucao;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.DateTimePicker dtpFinalizado;
        private System.Windows.Forms.Label labAbertura;
        private System.Windows.Forms.Label labFechamento;
        private System.Windows.Forms.Label labSituacao;
        private System.Windows.Forms.Label labProduto;
        private System.Windows.Forms.Label labAtendimento;
        private System.Windows.Forms.ComboBox cbAtendimento;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labOSid;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
    }
}