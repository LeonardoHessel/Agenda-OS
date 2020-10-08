namespace Agenda_OS
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.labRazao = new System.Windows.Forms.Label();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtbIE = new System.Windows.Forms.MaskedTextBox();
            this.labFantasia = new System.Windows.Forms.Label();
            this.labCPF_CNPJ = new System.Windows.Forms.Label();
            this.labRG_IE = new System.Windows.Forms.Label();
            this.cbRegime = new System.Windows.Forms.ComboBox();
            this.labRegime = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.labTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labContador = new System.Windows.Forms.Label();
            this.cbContador = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.labObservacao = new System.Windows.Forms.Label();
            this.pForm = new System.Windows.Forms.Panel();
            this.pInformacao = new System.Windows.Forms.Panel();
            this.chbInativar = new System.Windows.Forms.CheckBox();
            this.labID = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pEndereco = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.labNumero = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.labUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labCidade = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.labCEP = new System.Windows.Forms.Label();
            this.labEndereco = new System.Windows.Forms.Label();
            this.labRua = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labBairro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pForm.SuspendLayout();
            this.pInformacao.SuspendLayout();
            this.pEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(71, 64);
            this.labRazao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(45, 14);
            this.labRazao.TabIndex = 38;
            this.labRazao.Text = "Razão:";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbCNPJ.Location = new System.Drawing.Point(154, 128);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(125, 22);
            this.mtbCNPJ.TabIndex = 3;
            this.mtbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(154, 61);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(461, 22);
            this.txtRazao.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(154, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 22);
            this.txtNome.TabIndex = 2;
            // 
            // mtbIE
            // 
            this.mtbIE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbIE.Location = new System.Drawing.Point(332, 128);
            this.mtbIE.Mask = "999,999,999,999";
            this.mtbIE.Name = "mtbIE";
            this.mtbIE.Size = new System.Drawing.Size(105, 22);
            this.mtbIE.TabIndex = 4;
            this.mtbIE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labFantasia
            // 
            this.labFantasia.AutoSize = true;
            this.labFantasia.Location = new System.Drawing.Point(71, 97);
            this.labFantasia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labFantasia.Name = "labFantasia";
            this.labFantasia.Size = new System.Drawing.Size(58, 14);
            this.labFantasia.TabIndex = 44;
            this.labFantasia.Text = "Fantasia:";
            // 
            // labCPF_CNPJ
            // 
            this.labCPF_CNPJ.AutoSize = true;
            this.labCPF_CNPJ.Location = new System.Drawing.Point(71, 131);
            this.labCPF_CNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labCPF_CNPJ.Name = "labCPF_CNPJ";
            this.labCPF_CNPJ.Size = new System.Drawing.Size(69, 14);
            this.labCPF_CNPJ.TabIndex = 46;
            this.labCPF_CNPJ.Text = "CPF/CNPJ:";
            // 
            // labRG_IE
            // 
            this.labRG_IE.AutoSize = true;
            this.labRG_IE.Location = new System.Drawing.Point(285, 131);
            this.labRG_IE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labRG_IE.Name = "labRG_IE";
            this.labRG_IE.Size = new System.Drawing.Size(41, 14);
            this.labRG_IE.TabIndex = 47;
            this.labRG_IE.Text = "RG/IE:";
            // 
            // cbRegime
            // 
            this.cbRegime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegime.FormattingEnabled = true;
            this.cbRegime.Items.AddRange(new object[] {
            "Lucro",
            "Simples"});
            this.cbRegime.Location = new System.Drawing.Point(499, 128);
            this.cbRegime.Name = "cbRegime";
            this.cbRegime.Size = new System.Drawing.Size(116, 22);
            this.cbRegime.TabIndex = 5;
            // 
            // labRegime
            // 
            this.labRegime.AutoSize = true;
            this.labRegime.Location = new System.Drawing.Point(443, 131);
            this.labRegime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labRegime.Name = "labRegime";
            this.labRegime.Size = new System.Drawing.Size(50, 14);
            this.labRegime.TabIndex = 49;
            this.labRegime.Text = "Regime:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(154, 163);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(461, 22);
            this.txtTelefone.TabIndex = 6;
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(71, 166);
            this.labTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(56, 14);
            this.labTelefone.TabIndex = 51;
            this.labTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(461, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(71, 233);
            this.labEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(45, 14);
            this.labEmail.TabIndex = 53;
            this.labEmail.Text = "E-mail:";
            // 
            // labContador
            // 
            this.labContador.AutoSize = true;
            this.labContador.Location = new System.Drawing.Point(71, 199);
            this.labContador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labContador.Name = "labContador";
            this.labContador.Size = new System.Drawing.Size(61, 14);
            this.labContador.TabIndex = 55;
            this.labContador.Text = "Contador:";
            // 
            // cbContador
            // 
            this.cbContador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContador.Enabled = false;
            this.cbContador.FormattingEnabled = true;
            this.cbContador.Location = new System.Drawing.Point(154, 196);
            this.cbContador.Name = "cbContador";
            this.cbContador.Size = new System.Drawing.Size(461, 22);
            this.cbContador.TabIndex = 7;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(154, 262);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(461, 62);
            this.txtObservacao.TabIndex = 9;
            // 
            // labObservacao
            // 
            this.labObservacao.AutoSize = true;
            this.labObservacao.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labObservacao.Location = new System.Drawing.Point(71, 265);
            this.labObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labObservacao.Name = "labObservacao";
            this.labObservacao.Size = new System.Drawing.Size(74, 14);
            this.labObservacao.TabIndex = 57;
            this.labObservacao.Text = "Observação:";
            // 
            // pForm
            // 
            this.pForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pForm.BackColor = System.Drawing.Color.White;
            this.pForm.Controls.Add(this.pInformacao);
            this.pForm.Controls.Add(this.pEndereco);
            this.pForm.Controls.Add(this.btnSalvar);
            this.pForm.Controls.Add(this.btnEditar);
            this.pForm.Location = new System.Drawing.Point(0, 40);
            this.pForm.Margin = new System.Windows.Forms.Padding(1);
            this.pForm.Name = "pForm";
            this.pForm.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pForm.Size = new System.Drawing.Size(800, 520);
            this.pForm.TabIndex = 58;
            // 
            // pInformacao
            // 
            this.pInformacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pInformacao.Controls.Add(this.chbInativar);
            this.pInformacao.Controls.Add(this.labRegime);
            this.pInformacao.Controls.Add(this.labID);
            this.pInformacao.Controls.Add(this.labInfo);
            this.pInformacao.Controls.Add(this.txtID);
            this.pInformacao.Controls.Add(this.txtRazao);
            this.pInformacao.Controls.Add(this.labRazao);
            this.pInformacao.Controls.Add(this.cbContador);
            this.pInformacao.Controls.Add(this.txtNome);
            this.pInformacao.Controls.Add(this.cbRegime);
            this.pInformacao.Controls.Add(this.mtbIE);
            this.pInformacao.Controls.Add(this.txtTelefone);
            this.pInformacao.Controls.Add(this.labEmail);
            this.pInformacao.Controls.Add(this.labObservacao);
            this.pInformacao.Controls.Add(this.labContador);
            this.pInformacao.Controls.Add(this.labRG_IE);
            this.pInformacao.Controls.Add(this.labFantasia);
            this.pInformacao.Controls.Add(this.labTelefone);
            this.pInformacao.Controls.Add(this.txtEmail);
            this.pInformacao.Controls.Add(this.mtbCNPJ);
            this.pInformacao.Controls.Add(this.txtObservacao);
            this.pInformacao.Controls.Add(this.labCPF_CNPJ);
            this.pInformacao.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInformacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pInformacao.Location = new System.Drawing.Point(36, 19);
            this.pInformacao.Name = "pInformacao";
            this.pInformacao.Size = new System.Drawing.Size(728, 335);
            this.pInformacao.TabIndex = 66;
            // 
            // chbInativar
            // 
            this.chbInativar.AutoSize = true;
            this.chbInativar.Location = new System.Drawing.Point(548, 34);
            this.chbInativar.Name = "chbInativar";
            this.chbInativar.Size = new System.Drawing.Size(67, 18);
            this.chbInativar.TabIndex = 60;
            this.chbInativar.Text = "Inativar";
            this.chbInativar.UseVisualStyleBackColor = true;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(71, 35);
            this.labID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(21, 14);
            this.labID.TabIndex = 59;
            this.labID.Text = "ID:";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.BackColor = System.Drawing.Color.Transparent;
            this.labInfo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labInfo.Location = new System.Drawing.Point(10, 10);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(74, 14);
            this.labInfo.TabIndex = 0;
            this.labInfo.Text = "Informações";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(154, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 22);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pEndereco
            // 
            this.pEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pEndereco.Controls.Add(this.txtNumero);
            this.pEndereco.Controls.Add(this.labNumero);
            this.pEndereco.Controls.Add(this.mtbCEP);
            this.pEndereco.Controls.Add(this.cbUF);
            this.pEndereco.Controls.Add(this.labUF);
            this.pEndereco.Controls.Add(this.txtCidade);
            this.pEndereco.Controls.Add(this.labCidade);
            this.pEndereco.Controls.Add(this.txtRua);
            this.pEndereco.Controls.Add(this.labCEP);
            this.pEndereco.Controls.Add(this.labEndereco);
            this.pEndereco.Controls.Add(this.labRua);
            this.pEndereco.Controls.Add(this.txtBairro);
            this.pEndereco.Controls.Add(this.labBairro);
            this.pEndereco.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pEndereco.Location = new System.Drawing.Point(36, 360);
            this.pEndereco.Name = "pEndereco";
            this.pEndereco.Size = new System.Drawing.Size(728, 95);
            this.pEndereco.TabIndex = 65;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(535, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // labNumero
            // 
            this.labNumero.AutoSize = true;
            this.labNumero.Location = new System.Drawing.Point(507, 27);
            this.labNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labNumero.Name = "labNumero";
            this.labNumero.Size = new System.Drawing.Size(22, 14);
            this.labNumero.TabIndex = 72;
            this.labNumero.Text = "N°:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbCEP.Location = new System.Drawing.Point(154, 25);
            this.mtbCEP.Mask = "99,999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(75, 22);
            this.mtbCEP.TabIndex = 0;
            this.mtbCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(555, 58);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(60, 22);
            this.cbUF.TabIndex = 5;
            // 
            // labUF
            // 
            this.labUF.AutoSize = true;
            this.labUF.Location = new System.Drawing.Point(524, 61);
            this.labUF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labUF.Name = "labUF";
            this.labUF.Size = new System.Drawing.Size(25, 14);
            this.labUF.TabIndex = 68;
            this.labUF.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(370, 58);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(148, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // labCidade
            // 
            this.labCidade.AutoSize = true;
            this.labCidade.Location = new System.Drawing.Point(316, 61);
            this.labCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labCidade.Name = "labCidade";
            this.labCidade.Size = new System.Drawing.Size(48, 14);
            this.labCidade.TabIndex = 66;
            this.labCidade.Text = "Cidade:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(273, 25);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(228, 22);
            this.txtRua.TabIndex = 1;
            // 
            // labCEP
            // 
            this.labCEP.AutoSize = true;
            this.labCEP.Location = new System.Drawing.Point(71, 27);
            this.labCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labCEP.Name = "labCEP";
            this.labCEP.Size = new System.Drawing.Size(33, 14);
            this.labCEP.TabIndex = 70;
            this.labCEP.Text = "CEP:";
            // 
            // labEndereco
            // 
            this.labEndereco.AutoSize = true;
            this.labEndereco.BackColor = System.Drawing.Color.Transparent;
            this.labEndereco.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.labEndereco.Location = new System.Drawing.Point(10, 10);
            this.labEndereco.Name = "labEndereco";
            this.labEndereco.Size = new System.Drawing.Size(57, 14);
            this.labEndereco.TabIndex = 0;
            this.labEndereco.Text = "Endereço";
            // 
            // labRua
            // 
            this.labRua.AutoSize = true;
            this.labRua.Location = new System.Drawing.Point(235, 27);
            this.labRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labRua.Name = "labRua";
            this.labRua.Size = new System.Drawing.Size(32, 14);
            this.labRua.TabIndex = 63;
            this.labRua.Text = "Rua:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(154, 58);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(156, 22);
            this.txtBairro.TabIndex = 3;
            // 
            // labBairro
            // 
            this.labBairro.AutoSize = true;
            this.labBairro.Location = new System.Drawing.Point(71, 61);
            this.labBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labBairro.Name = "labBairro";
            this.labBairro.Size = new System.Drawing.Size(43, 14);
            this.labBairro.TabIndex = 64;
            this.labBairro.Text = "Bairro:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "";
            this.btnSalvar.AccessibleName = "";
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(673, 470);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(565, 470);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(760, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labTitulo.Location = new System.Drawing.Point(297, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(206, 25);
            this.labTitulo.TabIndex = 59;
            this.labTitulo.Text = "Cadastro de Clientes";
            // 
            // FormCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.pForm);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEmpresa_KeyDown);
            this.pForm.ResumeLayout(false);
            this.pInformacao.ResumeLayout(false);
            this.pInformacao.PerformLayout();
            this.pEndereco.ResumeLayout(false);
            this.pEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labRazao;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtbIE;
        private System.Windows.Forms.Label labFantasia;
        private System.Windows.Forms.Label labCPF_CNPJ;
        private System.Windows.Forms.Label labRG_IE;
        private System.Windows.Forms.ComboBox cbRegime;
        private System.Windows.Forms.Label labRegime;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labContador;
        private System.Windows.Forms.ComboBox cbContador;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label labObservacao;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pEndereco;
        private System.Windows.Forms.Label labEndereco;
        private System.Windows.Forms.Panel pInformacao;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.CheckBox chbInativar;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label labRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label labBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label labNumero;
        private System.Windows.Forms.Label labCEP;
        private System.Windows.Forms.Label labUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labCidade;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
    }
}