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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOS));
            this.pForm = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtivarInativar = new System.Windows.Forms.Button();
            this.tcOS = new System.Windows.Forms.TabControl();
            this.tbOS = new System.Windows.Forms.TabPage();
            this.mtbDoc = new System.Windows.Forms.MaskedTextBox();
            this.labID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.labSolicitante = new System.Windows.Forms.Label();
            this.labCliente = new System.Windows.Forms.Label();
            this.labCPFCNPJ = new System.Windows.Forms.Label();
            this.labAssunto = new System.Windows.Forms.Label();
            this.labDescricao = new System.Windows.Forms.Label();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.dbStatus = new System.Windows.Forms.GroupBox();
            this.labAbertura = new System.Windows.Forms.Label();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalizado = new System.Windows.Forms.DateTimePicker();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.labFechamento = new System.Windows.Forms.Label();
            this.labSituacao = new System.Windows.Forms.Label();
            this.cbAtendimento = new System.Windows.Forms.ComboBox();
            this.labAtendimento = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labSolucao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.labProduto = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.labTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pForm.SuspendLayout();
            this.tcOS.SuspendLayout();
            this.tbOS.SuspendLayout();
            this.dbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pForm
            // 
            this.pForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pForm.BackColor = System.Drawing.SystemColors.Control;
            this.pForm.Controls.Add(this.btnSalvar);
            this.pForm.Controls.Add(this.btnEditar);
            this.pForm.Controls.Add(this.btnAtivarInativar);
            this.pForm.Controls.Add(this.tcOS);
            this.pForm.Location = new System.Drawing.Point(1, 32);
            this.pForm.Margin = new System.Windows.Forms.Padding(0);
            this.pForm.Name = "pForm";
            this.pForm.Padding = new System.Windows.Forms.Padding(10);
            this.pForm.Size = new System.Drawing.Size(740, 490);
            this.pForm.TabIndex = 31;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "";
            this.btnSalvar.AccessibleName = "";
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(643, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Tag = "";
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
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(546, 10);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 37;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtivarInativar
            // 
            this.btnAtivarInativar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtivarInativar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAtivarInativar.FlatAppearance.BorderSize = 0;
            this.btnAtivarInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivarInativar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivarInativar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtivarInativar.Location = new System.Drawing.Point(449, 10);
            this.btnAtivarInativar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnAtivarInativar.Name = "btnAtivarInativar";
            this.btnAtivarInativar.Size = new System.Drawing.Size(87, 30);
            this.btnAtivarInativar.TabIndex = 38;
            this.btnAtivarInativar.Text = "Inativar";
            this.btnAtivarInativar.UseVisualStyleBackColor = false;
            this.btnAtivarInativar.Click += new System.EventHandler(this.btnAtivarInativar_Click);
            // 
            // tcOS
            // 
            this.tcOS.Controls.Add(this.tbOS);
            this.tcOS.Location = new System.Drawing.Point(10, 25);
            this.tcOS.Margin = new System.Windows.Forms.Padding(0);
            this.tcOS.Name = "tcOS";
            this.tcOS.SelectedIndex = 0;
            this.tcOS.Size = new System.Drawing.Size(720, 455);
            this.tcOS.TabIndex = 39;
            // 
            // tbOS
            // 
            this.tbOS.Controls.Add(this.mtbDoc);
            this.tbOS.Controls.Add(this.labID);
            this.tbOS.Controls.Add(this.txtID);
            this.tbOS.Controls.Add(this.txtSolicitante);
            this.tbOS.Controls.Add(this.labSolicitante);
            this.tbOS.Controls.Add(this.labCliente);
            this.tbOS.Controls.Add(this.labCPFCNPJ);
            this.tbOS.Controls.Add(this.labAssunto);
            this.tbOS.Controls.Add(this.labDescricao);
            this.tbOS.Controls.Add(this.btnPesquisaCliente);
            this.tbOS.Controls.Add(this.txtSolucao);
            this.tbOS.Controls.Add(this.dbStatus);
            this.tbOS.Controls.Add(this.txtCliente);
            this.tbOS.Controls.Add(this.labSolucao);
            this.tbOS.Controls.Add(this.txtDescricao);
            this.tbOS.Controls.Add(this.txtAssunto);
            this.tbOS.Controls.Add(this.labProduto);
            this.tbOS.Controls.Add(this.cbProduto);
            this.tbOS.Controls.Add(this.labUsuario);
            this.tbOS.Controls.Add(this.cbUsuario);
            this.tbOS.Location = new System.Drawing.Point(4, 26);
            this.tbOS.Margin = new System.Windows.Forms.Padding(0);
            this.tbOS.Name = "tbOS";
            this.tbOS.Padding = new System.Windows.Forms.Padding(10);
            this.tbOS.Size = new System.Drawing.Size(712, 425);
            this.tbOS.TabIndex = 0;
            this.tbOS.Text = "Ordem de Serviço";
            this.tbOS.UseVisualStyleBackColor = true;
            // 
            // mtbDoc
            // 
            this.mtbDoc.Enabled = false;
            this.mtbDoc.Location = new System.Drawing.Point(86, 48);
            this.mtbDoc.Mask = "00,000,000/0000-00";
            this.mtbDoc.Name = "mtbDoc";
            this.mtbDoc.Size = new System.Drawing.Size(131, 25);
            this.mtbDoc.TabIndex = 76;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(522, 19);
            this.labID.Margin = new System.Windows.Forms.Padding(0);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(24, 16);
            this.labID.TabIndex = 74;
            this.labID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(551, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 25);
            this.txtID.TabIndex = 75;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(292, 50);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(5);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(161, 25);
            this.txtSolicitante.TabIndex = 58;
            // 
            // labSolicitante
            // 
            this.labSolicitante.AutoSize = true;
            this.labSolicitante.Location = new System.Drawing.Point(220, 53);
            this.labSolicitante.Margin = new System.Windows.Forms.Padding(0);
            this.labSolicitante.Name = "labSolicitante";
            this.labSolicitante.Size = new System.Drawing.Size(67, 17);
            this.labSolicitante.TabIndex = 69;
            this.labSolicitante.Text = "Solicitante";
            // 
            // labCliente
            // 
            this.labCliente.AutoSize = true;
            this.labCliente.Location = new System.Drawing.Point(12, 18);
            this.labCliente.Margin = new System.Windows.Forms.Padding(0);
            this.labCliente.Name = "labCliente";
            this.labCliente.Size = new System.Drawing.Size(47, 17);
            this.labCliente.TabIndex = 66;
            this.labCliente.Text = "Cliente";
            // 
            // labCPFCNPJ
            // 
            this.labCPFCNPJ.AutoSize = true;
            this.labCPFCNPJ.Location = new System.Drawing.Point(12, 53);
            this.labCPFCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.labCPFCNPJ.Name = "labCPFCNPJ";
            this.labCPFCNPJ.Size = new System.Drawing.Size(71, 17);
            this.labCPFCNPJ.TabIndex = 68;
            this.labCPFCNPJ.Text = "CPF / CNPJ";
            // 
            // labAssunto
            // 
            this.labAssunto.AutoSize = true;
            this.labAssunto.Location = new System.Drawing.Point(12, 88);
            this.labAssunto.Margin = new System.Windows.Forms.Padding(0);
            this.labAssunto.Name = "labAssunto";
            this.labAssunto.Size = new System.Drawing.Size(54, 17);
            this.labAssunto.TabIndex = 67;
            this.labAssunto.Text = "Assunto";
            // 
            // labDescricao
            // 
            this.labDescricao.AutoSize = true;
            this.labDescricao.Location = new System.Drawing.Point(10, 120);
            this.labDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.labDescricao.Name = "labDescricao";
            this.labDescricao.Size = new System.Drawing.Size(65, 17);
            this.labDescricao.TabIndex = 70;
            this.labDescricao.Text = "Descrição";
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisaCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCliente.Image = global::Agenda_OS.Properties.Resources.SearchX16;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(461, 15);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(25, 25);
            this.btnPesquisaCliente.TabIndex = 64;
            this.btnPesquisaCliente.UseVisualStyleBackColor = false;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // txtSolucao
            // 
            this.txtSolucao.Location = new System.Drawing.Point(86, 220);
            this.txtSolucao.Margin = new System.Windows.Forms.Padding(5);
            this.txtSolucao.Multiline = true;
            this.txtSolucao.Name = "txtSolucao";
            this.txtSolucao.Size = new System.Drawing.Size(610, 90);
            this.txtSolucao.TabIndex = 62;
            // 
            // dbStatus
            // 
            this.dbStatus.Controls.Add(this.labAbertura);
            this.dbStatus.Controls.Add(this.dtpAbertura);
            this.dbStatus.Controls.Add(this.dtpFinalizado);
            this.dbStatus.Controls.Add(this.cbSituacao);
            this.dbStatus.Controls.Add(this.labFechamento);
            this.dbStatus.Controls.Add(this.labSituacao);
            this.dbStatus.Controls.Add(this.cbAtendimento);
            this.dbStatus.Controls.Add(this.labAtendimento);
            this.dbStatus.Location = new System.Drawing.Point(13, 315);
            this.dbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.dbStatus.Size = new System.Drawing.Size(681, 98);
            this.dbStatus.TabIndex = 73;
            this.dbStatus.TabStop = false;
            this.dbStatus.Text = "Status";
            // 
            // labAbertura
            // 
            this.labAbertura.AutoSize = true;
            this.labAbertura.Location = new System.Drawing.Point(375, 27);
            this.labAbertura.Margin = new System.Windows.Forms.Padding(0);
            this.labAbertura.Name = "labAbertura";
            this.labAbertura.Size = new System.Drawing.Size(59, 17);
            this.labAbertura.TabIndex = 25;
            this.labAbertura.Text = "Abertura";
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.CustomFormat = "dd/MM/yyyy  hh:mm:s";
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbertura.Location = new System.Drawing.Point(484, 23);
            this.dtpAbertura.Margin = new System.Windows.Forms.Padding(5);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(182, 25);
            this.dtpAbertura.TabIndex = 9;
            // 
            // dtpFinalizado
            // 
            this.dtpFinalizado.CustomFormat = "dd/MM/yyyy  hh:mm:s";
            this.dtpFinalizado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinalizado.Location = new System.Drawing.Point(484, 58);
            this.dtpFinalizado.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFinalizado.Name = "dtpFinalizado";
            this.dtpFinalizado.Size = new System.Drawing.Size(182, 25);
            this.dtpFinalizado.TabIndex = 10;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Agendado",
            "Cancelado",
            "Finalizado",
            "Pendente"});
            this.cbSituacao.Location = new System.Drawing.Point(97, 58);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(5);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(221, 25);
            this.cbSituacao.TabIndex = 8;
            // 
            // labFechamento
            // 
            this.labFechamento.AutoSize = true;
            this.labFechamento.Location = new System.Drawing.Point(375, 61);
            this.labFechamento.Margin = new System.Windows.Forms.Padding(0);
            this.labFechamento.Name = "labFechamento";
            this.labFechamento.Size = new System.Drawing.Size(78, 17);
            this.labFechamento.TabIndex = 26;
            this.labFechamento.Text = "Fechamento";
            // 
            // labSituacao
            // 
            this.labSituacao.AutoSize = true;
            this.labSituacao.Location = new System.Drawing.Point(10, 61);
            this.labSituacao.Margin = new System.Windows.Forms.Padding(0);
            this.labSituacao.Name = "labSituacao";
            this.labSituacao.Size = new System.Drawing.Size(57, 17);
            this.labSituacao.TabIndex = 27;
            this.labSituacao.Text = "Situação";
            // 
            // cbAtendimento
            // 
            this.cbAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtendimento.FormattingEnabled = true;
            this.cbAtendimento.ItemHeight = 17;
            this.cbAtendimento.Items.AddRange(new object[] {
            "Selecione a forma de Atendimento:",
            "WhatsApp",
            "Ligação",
            "E-mail",
            "Skype",
            "Cliente",
            "In loco"});
            this.cbAtendimento.Location = new System.Drawing.Point(97, 23);
            this.cbAtendimento.Margin = new System.Windows.Forms.Padding(5);
            this.cbAtendimento.Name = "cbAtendimento";
            this.cbAtendimento.Size = new System.Drawing.Size(221, 25);
            this.cbAtendimento.TabIndex = 7;
            // 
            // labAtendimento
            // 
            this.labAtendimento.AutoSize = true;
            this.labAtendimento.Location = new System.Drawing.Point(10, 27);
            this.labAtendimento.Margin = new System.Windows.Forms.Padding(0);
            this.labAtendimento.Name = "labAtendimento";
            this.labAtendimento.Size = new System.Drawing.Size(82, 17);
            this.labAtendimento.TabIndex = 30;
            this.labAtendimento.Text = "Atendimento";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(86, 15);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(367, 25);
            this.txtCliente.TabIndex = 56;
            // 
            // labSolucao
            // 
            this.labSolucao.AutoSize = true;
            this.labSolucao.Location = new System.Drawing.Point(10, 220);
            this.labSolucao.Margin = new System.Windows.Forms.Padding(0);
            this.labSolucao.Name = "labSolucao";
            this.labSolucao.Size = new System.Drawing.Size(54, 17);
            this.labSolucao.TabIndex = 71;
            this.labSolucao.Text = "Solução";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(86, 120);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(610, 90);
            this.txtDescricao.TabIndex = 61;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(86, 85);
            this.txtAssunto.Margin = new System.Windows.Forms.Padding(5);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(367, 25);
            this.txtAssunto.TabIndex = 59;
            // 
            // labProduto
            // 
            this.labProduto.AutoSize = true;
            this.labProduto.Location = new System.Drawing.Point(458, 88);
            this.labProduto.Margin = new System.Windows.Forms.Padding(0);
            this.labProduto.Name = "labProduto";
            this.labProduto.Size = new System.Drawing.Size(55, 17);
            this.labProduto.TabIndex = 72;
            this.labProduto.Text = "Produto";
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(518, 85);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(5);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(178, 25);
            this.cbProduto.TabIndex = 63;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(458, 53);
            this.labUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(53, 17);
            this.labUsuario.TabIndex = 65;
            this.labUsuario.Text = "Usuário";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(519, 50);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(177, 25);
            this.cbUsuario.TabIndex = 57;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labTitulo.Location = new System.Drawing.Point(5, 5);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(184, 25);
            this.labTitulo.TabIndex = 19;
            this.labTitulo.Text = "Ordem de Serviço";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(692, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 32);
            this.btnFechar.TabIndex = 32;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(742, 523);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.pForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOS_KeyDown);
            this.pForm.ResumeLayout(false);
            this.tcOS.ResumeLayout(false);
            this.tbOS.ResumeLayout(false);
            this.tbOS.PerformLayout();
            this.dbStatus.ResumeLayout(false);
            this.dbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAtivarInativar;
        private System.Windows.Forms.TabControl tcOS;
        private System.Windows.Forms.TabPage tbOS;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label labSolicitante;
        private System.Windows.Forms.Label labCliente;
        private System.Windows.Forms.Label labCPFCNPJ;
        private System.Windows.Forms.Label labAssunto;
        private System.Windows.Forms.Label labDescricao;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.GroupBox dbStatus;
        private System.Windows.Forms.Label labAbertura;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.DateTimePicker dtpFinalizado;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label labFechamento;
        private System.Windows.Forms.Label labSituacao;
        private System.Windows.Forms.ComboBox cbAtendimento;
        private System.Windows.Forms.Label labAtendimento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label labSolucao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label labProduto;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.MaskedTextBox mtbDoc;
    }
}