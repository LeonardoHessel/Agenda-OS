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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.labNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.labNasc = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.labSexo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInativarAtivar = new System.Windows.Forms.Button();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCNH = new System.Windows.Forms.MaskedTextBox();
            this.labCNH = new System.Windows.Forms.Label();
            this.labCPF = new System.Windows.Forms.Label();
            this.labRG = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.gbAcesso = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.labResetarLoginSenha = new System.Windows.Forms.Label();
            this.ofdBuscaArquivo = new System.Windows.Forms.OpenFileDialog();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.pFormulario = new System.Windows.Forms.Panel();
            this.tcUsuaario = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tpPermissoes = new System.Windows.Forms.TabPage();
            this.labNotificacao = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.pFormulario.SuspendLayout();
            this.tcUsuaario.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.tpPermissoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNome.Location = new System.Drawing.Point(13, 19);
            this.labNome.Margin = new System.Windows.Forms.Padding(3);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(48, 16);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 25);
            this.txtNome.TabIndex = 0;
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(60, 28);
            this.dtpNasc.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(148, 25);
            this.dtpNasc.TabIndex = 4;
            // 
            // labNasc
            // 
            this.labNasc.AutoSize = true;
            this.labNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNasc.Location = new System.Drawing.Point(7, 35);
            this.labNasc.Margin = new System.Windows.Forms.Padding(3);
            this.labNasc.Name = "labNasc";
            this.labNasc.Size = new System.Drawing.Size(43, 16);
            this.labNasc.TabIndex = 3;
            this.labNasc.Text = "Nasc.";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.ItemHeight = 17;
            this.cmbSexo.Items.AddRange(new object[] {
            "Selecione:",
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(321, 28);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(158, 25);
            this.cmbSexo.TabIndex = 5;
            // 
            // labSexo
            // 
            this.labSexo.AutoSize = true;
            this.labSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSexo.Location = new System.Drawing.Point(271, 35);
            this.labSexo.Margin = new System.Windows.Forms.Padding(3);
            this.labSexo.Name = "labSexo";
            this.labSexo.Size = new System.Drawing.Size(42, 16);
            this.labSexo.TabIndex = 6;
            this.labSexo.Text = "Sexo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "";
            this.btnSalvar.AccessibleName = "";
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(635, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(538, 10);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInativarAtivar
            // 
            this.btnInativarAtivar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInativarAtivar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInativarAtivar.FlatAppearance.BorderSize = 0;
            this.btnInativarAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInativarAtivar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInativarAtivar.Location = new System.Drawing.Point(441, 10);
            this.btnInativarAtivar.Margin = new System.Windows.Forms.Padding(0);
            this.btnInativarAtivar.Name = "btnInativarAtivar";
            this.btnInativarAtivar.Size = new System.Drawing.Size(87, 30);
            this.btnInativarAtivar.TabIndex = 11;
            this.btnInativarAtivar.Text = "Inativar";
            this.btnInativarAtivar.UseVisualStyleBackColor = false;
            this.btnInativarAtivar.Click += new System.EventHandler(this.btnInativarAtivar_Click);
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(60, 63);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(5);
            this.mtbRG.Mask = "99,999,999-9";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(91, 25);
            this.mtbRG.TabIndex = 6;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(204, 63);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(5);
            this.mtbCPF.Mask = "999,999,999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(101, 25);
            this.mtbCPF.TabIndex = 7;
            // 
            // mtbCNH
            // 
            this.mtbCNH.Location = new System.Drawing.Point(366, 63);
            this.mtbCNH.Margin = new System.Windows.Forms.Padding(5);
            this.mtbCNH.Mask = "999 999 999 99";
            this.mtbCNH.Name = "mtbCNH";
            this.mtbCNH.Size = new System.Drawing.Size(113, 25);
            this.mtbCNH.TabIndex = 8;
            // 
            // labCNH
            // 
            this.labCNH.AutoSize = true;
            this.labCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCNH.Location = new System.Drawing.Point(318, 67);
            this.labCNH.Margin = new System.Windows.Forms.Padding(3);
            this.labCNH.Name = "labCNH";
            this.labCNH.Size = new System.Drawing.Size(40, 16);
            this.labCNH.TabIndex = 15;
            this.labCNH.Text = "CNH:";
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCPF.Location = new System.Drawing.Point(159, 67);
            this.labCPF.Margin = new System.Windows.Forms.Padding(3);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(37, 16);
            this.labCPF.TabIndex = 16;
            this.labCPF.Text = "CPF:";
            // 
            // labRG
            // 
            this.labRG.AutoSize = true;
            this.labRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRG.Location = new System.Drawing.Point(7, 67);
            this.labRG.Margin = new System.Windows.Forms.Padding(3);
            this.labRG.Name = "labRG";
            this.labRG.Size = new System.Drawing.Size(31, 16);
            this.labRG.TabIndex = 17;
            this.labRG.Text = "RG:";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labTitulo.Location = new System.Drawing.Point(5, 5);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(86, 25);
            this.labTitulo.TabIndex = 18;
            this.labTitulo.Text = "Usuário";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(382, 19);
            this.labID.Margin = new System.Windows.Forms.Padding(3);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(24, 16);
            this.labID.TabIndex = 19;
            this.labID.Text = "ID:";
            // 
            // gbAcesso
            // 
            this.gbAcesso.Controls.Add(this.txtSenha);
            this.gbAcesso.Controls.Add(this.labSenha);
            this.gbAcesso.Controls.Add(this.txtLogin);
            this.gbAcesso.Controls.Add(this.labLogin);
            this.gbAcesso.Location = new System.Drawing.Point(13, 48);
            this.gbAcesso.Name = "gbAcesso";
            this.gbAcesso.Padding = new System.Windows.Forms.Padding(5);
            this.gbAcesso.Size = new System.Drawing.Size(491, 65);
            this.gbAcesso.TabIndex = 21;
            this.gbAcesso.TabStop = false;
            this.gbAcesso.Text = "Acesso";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(304, 28);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(175, 25);
            this.txtSenha.TabIndex = 2;
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSenha.Location = new System.Drawing.Point(246, 32);
            this.labSenha.Margin = new System.Windows.Forms.Padding(3);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(50, 16);
            this.labSenha.TabIndex = 24;
            this.labSenha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(60, 28);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(175, 25);
            this.txtLogin.TabIndex = 0;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.Location = new System.Drawing.Point(8, 32);
            this.labLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(44, 16);
            this.labLogin.TabIndex = 22;
            this.labLogin.Text = "Login:";
            // 
            // labResetarLoginSenha
            // 
            this.labResetarLoginSenha.AutoSize = true;
            this.labResetarLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labResetarLoginSenha.ForeColor = System.Drawing.Color.Blue;
            this.labResetarLoginSenha.Location = new System.Drawing.Point(13, 230);
            this.labResetarLoginSenha.Margin = new System.Windows.Forms.Padding(3);
            this.labResetarLoginSenha.Name = "labResetarLoginSenha";
            this.labResetarLoginSenha.Size = new System.Drawing.Size(82, 16);
            this.labResetarLoginSenha.TabIndex = 12;
            this.labResetarLoginSenha.Text = "resetar login";
            this.labResetarLoginSenha.Click += new System.EventHandler(this.labResetarLoginSenha_Click);
            // 
            // ofdBuscaArquivo
            // 
            this.ofdBuscaArquivo.DefaultExt = "Images";
            this.ofdBuscaArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|All files " +
    "(*.*)|*.*";
            this.ofdBuscaArquivo.Title = "Selecionar Arquivo";
            // 
            // pbxFoto
            // 
            this.pbxFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = global::Agenda_OS.Properties.Resources.AddFoto_48px;
            this.pbxFoto.Location = new System.Drawing.Point(519, 10);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(173, 222);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFoto.TabIndex = 4;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Click += new System.EventHandler(this.pbxFoto_Click);
            // 
            // pFormulario
            // 
            this.pFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pFormulario.BackColor = System.Drawing.SystemColors.Control;
            this.pFormulario.Controls.Add(this.btnSalvar);
            this.pFormulario.Controls.Add(this.btnEditar);
            this.pFormulario.Controls.Add(this.btnInativarAtivar);
            this.pFormulario.Controls.Add(this.tcUsuaario);
            this.pFormulario.Location = new System.Drawing.Point(1, 32);
            this.pFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.pFormulario.Name = "pFormulario";
            this.pFormulario.Padding = new System.Windows.Forms.Padding(10);
            this.pFormulario.Size = new System.Drawing.Size(730, 320);
            this.pFormulario.TabIndex = 22;
            // 
            // tcUsuaario
            // 
            this.tcUsuaario.Controls.Add(this.tpInfo);
            this.tcUsuaario.Controls.Add(this.tpPermissoes);
            this.tcUsuaario.Location = new System.Drawing.Point(10, 25);
            this.tcUsuaario.Margin = new System.Windows.Forms.Padding(0);
            this.tcUsuaario.Name = "tcUsuaario";
            this.tcUsuaario.SelectedIndex = 0;
            this.tcUsuaario.Size = new System.Drawing.Size(710, 285);
            this.tcUsuaario.TabIndex = 26;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.labNome);
            this.tpInfo.Controls.Add(this.pbxFoto);
            this.tpInfo.Controls.Add(this.gbInformacoes);
            this.tpInfo.Controls.Add(this.labID);
            this.tpInfo.Controls.Add(this.txtID);
            this.tpInfo.Controls.Add(this.txtNome);
            this.tpInfo.Controls.Add(this.labResetarLoginSenha);
            this.tpInfo.Controls.Add(this.gbAcesso);
            this.tpInfo.Location = new System.Drawing.Point(4, 26);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(10);
            this.tpInfo.Size = new System.Drawing.Size(702, 255);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Informações";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.labNasc);
            this.gbInformacoes.Controls.Add(this.dtpNasc);
            this.gbInformacoes.Controls.Add(this.labSexo);
            this.gbInformacoes.Controls.Add(this.cmbSexo);
            this.gbInformacoes.Controls.Add(this.labRG);
            this.gbInformacoes.Controls.Add(this.mtbRG);
            this.gbInformacoes.Controls.Add(this.labCPF);
            this.gbInformacoes.Controls.Add(this.mtbCPF);
            this.gbInformacoes.Controls.Add(this.labCNH);
            this.gbInformacoes.Controls.Add(this.mtbCNH);
            this.gbInformacoes.Location = new System.Drawing.Point(13, 119);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Padding = new System.Windows.Forms.Padding(5);
            this.gbInformacoes.Size = new System.Drawing.Size(491, 105);
            this.gbInformacoes.TabIndex = 25;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Detalhes";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(414, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(90, 25);
            this.txtID.TabIndex = 22;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tpPermissoes
            // 
            this.tpPermissoes.Controls.Add(this.labNotificacao);
            this.tpPermissoes.Location = new System.Drawing.Point(4, 22);
            this.tpPermissoes.Name = "tpPermissoes";
            this.tpPermissoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpPermissoes.Size = new System.Drawing.Size(702, 259);
            this.tpPermissoes.TabIndex = 1;
            this.tpPermissoes.Text = "Permissões";
            this.tpPermissoes.UseVisualStyleBackColor = true;
            // 
            // labNotificacao
            // 
            this.labNotificacao.AutoSize = true;
            this.labNotificacao.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNotificacao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labNotificacao.Location = new System.Drawing.Point(212, 104);
            this.labNotificacao.Name = "labNotificacao";
            this.labNotificacao.Size = new System.Drawing.Size(269, 37);
            this.labNotificacao.TabIndex = 0;
            this.labNotificacao.Text = "Em desenvolvimento";
            this.labNotificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(682, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 32);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(732, 353);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.pFormulario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTecnico_KeyDown);
            this.gbAcesso.ResumeLayout(false);
            this.gbAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.pFormulario.ResumeLayout(false);
            this.tcUsuaario.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.tpPermissoes.ResumeLayout(false);
            this.tpPermissoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label labNasc;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label labSexo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInativarAtivar;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCNH;
        private System.Windows.Forms.Label labCNH;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.Label labRG;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.GroupBox gbAcesso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labResetarLoginSenha;
        private System.Windows.Forms.OpenFileDialog ofdBuscaArquivo;
        private System.Windows.Forms.Panel pFormulario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TabControl tcUsuaario;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpPermissoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labNotificacao;
    }
}