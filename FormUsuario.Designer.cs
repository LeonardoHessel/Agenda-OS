namespace Agenda_OS
{
    partial class FormUsuario
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.Nasc = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCNH = new System.Windows.Forms.MaskedTextBox();
            this.cnh = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.tcod = new System.Windows.Forms.Label();
            this.labCOD = new System.Windows.Forms.Label();
            this.gbxAcesso = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.labResetarLoginSenha = new System.Windows.Forms.Label();
            this.ofdImagenPerfil = new System.Windows.Forms.OpenFileDialog();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.gbxAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(22, 148);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(47, 17);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(79, 145);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 25);
            this.txtNome.TabIndex = 3;
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(79, 178);
            this.dtpNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(122, 25);
            this.dtpNasc.TabIndex = 4;
            this.dtpNasc.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Nasc
            // 
            this.Nasc.AutoSize = true;
            this.Nasc.Location = new System.Drawing.Point(22, 181);
            this.Nasc.Name = "Nasc";
            this.Nasc.Size = new System.Drawing.Size(40, 17);
            this.Nasc.TabIndex = 3;
            this.Nasc.Text = "Nasc.";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.ItemHeight = 17;
            this.cmbSexo.Items.AddRange(new object[] {
            "Selecione:",
            "Feminino",
            "Masculino",
            "Outros"});
            this.cmbSexo.Location = new System.Drawing.Point(255, 178);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(136, 25);
            this.cmbSexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "";
            this.btnSalvar.AccessibleName = "";
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(492, 273);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(395, 273);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(298, 273);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 30);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(79, 211);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbRG.Mask = "99.999.999-9";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(122, 25);
            this.mtbRG.TabIndex = 6;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(255, 211);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(136, 25);
            this.mtbCPF.TabIndex = 7;
            // 
            // mtbCNH
            // 
            this.mtbCNH.Location = new System.Drawing.Point(79, 244);
            this.mtbCNH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbCNH.Mask = "999 999 999 99";
            this.mtbCNH.Name = "mtbCNH";
            this.mtbCNH.Size = new System.Drawing.Size(122, 25);
            this.mtbCNH.TabIndex = 8;
            // 
            // cnh
            // 
            this.cnh.AutoSize = true;
            this.cnh.Location = new System.Drawing.Point(22, 247);
            this.cnh.Name = "cnh";
            this.cnh.Size = new System.Drawing.Size(38, 17);
            this.cnh.TabIndex = 15;
            this.cnh.Text = "CNH:";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(210, 214);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(32, 17);
            this.cpf.TabIndex = 16;
            this.cpf.Text = "CPF:";
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Location = new System.Drawing.Point(22, 214);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(28, 17);
            this.rg.TabIndex = 17;
            this.rg.Text = "RG:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(12, 14);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(74, 24);
            this.titulo.TabIndex = 18;
            this.titulo.Text = "Usuário";
            // 
            // tcod
            // 
            this.tcod.AutoSize = true;
            this.tcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcod.Location = new System.Drawing.Point(302, 18);
            this.tcod.Name = "tcod";
            this.tcod.Size = new System.Drawing.Size(25, 20);
            this.tcod.TabIndex = 19;
            this.tcod.Text = "id:";
            // 
            // labCOD
            // 
            this.labCOD.AutoSize = true;
            this.labCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCOD.Location = new System.Drawing.Point(333, 14);
            this.labCOD.Name = "labCOD";
            this.labCOD.Size = new System.Drawing.Size(32, 33);
            this.labCOD.TabIndex = 20;
            this.labCOD.Text = "0";
            // 
            // gbxAcesso
            // 
            this.gbxAcesso.Controls.Add(this.txtSenha);
            this.gbxAcesso.Controls.Add(this.labSenha);
            this.gbxAcesso.Controls.Add(this.txtLogin);
            this.gbxAcesso.Controls.Add(this.labLogin);
            this.gbxAcesso.Location = new System.Drawing.Point(16, 48);
            this.gbxAcesso.Name = "gbxAcesso";
            this.gbxAcesso.Size = new System.Drawing.Size(381, 87);
            this.gbxAcesso.TabIndex = 21;
            this.gbxAcesso.TabStop = false;
            this.gbxAcesso.Text = "Acesso";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(63, 51);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(312, 25);
            this.txtSenha.TabIndex = 2;
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Location = new System.Drawing.Point(6, 54);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(46, 17);
            this.labSenha.TabIndex = 24;
            this.labSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(63, 18);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(312, 25);
            this.txtLogin.TabIndex = 0;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Location = new System.Drawing.Point(6, 21);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(43, 17);
            this.labLogin.TabIndex = 22;
            this.labLogin.Text = "Login:";
            // 
            // labResetarLoginSenha
            // 
            this.labResetarLoginSenha.AutoSize = true;
            this.labResetarLoginSenha.ForeColor = System.Drawing.Color.Blue;
            this.labResetarLoginSenha.Location = new System.Drawing.Point(13, 290);
            this.labResetarLoginSenha.Name = "labResetarLoginSenha";
            this.labResetarLoginSenha.Size = new System.Drawing.Size(82, 17);
            this.labResetarLoginSenha.TabIndex = 12;
            this.labResetarLoginSenha.Text = "resetar login";
            this.labResetarLoginSenha.Click += new System.EventHandler(this.labResetarLoginSenha_Click);
            // 
            // ofdImagenPerfil
            // 
            this.ofdImagenPerfil.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files " +
    "(*.*)|*.*";
            this.ofdImagenPerfil.Title = "Imagem Perfil";
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = global::Agenda_OS.Properties.Resources.baseline_add_a_photo_black_48dp;
            this.pbxFoto.Location = new System.Drawing.Point(406, 14);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(173, 222);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFoto.TabIndex = 4;
            this.pbxFoto.TabStop = false;
            
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 317);
            this.Controls.Add(this.labResetarLoginSenha);
            this.Controls.Add(this.gbxAcesso);
            this.Controls.Add(this.labCOD);
            this.Controls.Add(this.tcod);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.cnh);
            this.Controls.Add(this.mtbCNH);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.Nasc);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUsuario";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTecnico_KeyDown);
            this.gbxAcesso.ResumeLayout(false);
            this.gbxAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label Nasc;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCNH;
        private System.Windows.Forms.Label cnh;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label tcod;
        private System.Windows.Forms.Label labCOD;
        private System.Windows.Forms.GroupBox gbxAcesso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labResetarLoginSenha;
        private System.Windows.Forms.OpenFileDialog ofdImagenPerfil;
    }
}