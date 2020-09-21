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
            this.labCNPJ = new System.Windows.Forms.Label();
            this.labIE = new System.Windows.Forms.Label();
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInativarAtivar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.labID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(8, 14);
            this.labRazao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(47, 17);
            this.labRazao.TabIndex = 38;
            this.labRazao.Text = "Razão:";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbCNPJ.Location = new System.Drawing.Point(400, 11);
            this.mtbCNPJ.Mask = "99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(136, 25);
            this.mtbCNPJ.TabIndex = 1;
            this.mtbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(72, 11);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(276, 25);
            this.txtRazao.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 25);
            this.txtNome.TabIndex = 3;
            // 
            // mtbIE
            // 
            this.mtbIE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbIE.Location = new System.Drawing.Point(400, 39);
            this.mtbIE.Mask = "999,999,999,999";
            this.mtbIE.Name = "mtbIE";
            this.mtbIE.Size = new System.Drawing.Size(118, 25);
            this.mtbIE.TabIndex = 2;
            this.mtbIE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labFantasia
            // 
            this.labFantasia.AutoSize = true;
            this.labFantasia.Location = new System.Drawing.Point(8, 48);
            this.labFantasia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labFantasia.Name = "labFantasia";
            this.labFantasia.Size = new System.Drawing.Size(58, 17);
            this.labFantasia.TabIndex = 44;
            this.labFantasia.Text = "Fantasia:";
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(354, 16);
            this.labCNPJ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(40, 17);
            this.labCNPJ.TabIndex = 46;
            this.labCNPJ.Text = "CNPJ:";
            // 
            // labIE
            // 
            this.labIE.AutoSize = true;
            this.labIE.Location = new System.Drawing.Point(373, 45);
            this.labIE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labIE.Name = "labIE";
            this.labIE.Size = new System.Drawing.Size(21, 17);
            this.labIE.TabIndex = 47;
            this.labIE.Text = "IE:";
            // 
            // cbRegime
            // 
            this.cbRegime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegime.FormattingEnabled = true;
            this.cbRegime.Items.AddRange(new object[] {
            "Lucro",
            "Simples"});
            this.cbRegime.Location = new System.Drawing.Point(580, 42);
            this.cbRegime.Name = "cbRegime";
            this.cbRegime.Size = new System.Drawing.Size(129, 25);
            this.cbRegime.TabIndex = 4;
            // 
            // labRegime
            // 
            this.labRegime.AutoSize = true;
            this.labRegime.Location = new System.Drawing.Point(524, 45);
            this.labRegime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labRegime.Name = "labRegime";
            this.labRegime.Size = new System.Drawing.Size(55, 17);
            this.labRegime.TabIndex = 49;
            this.labRegime.Text = "Regime:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(72, 74);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(276, 25);
            this.txtTelefone.TabIndex = 6;
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(8, 77);
            this.labTelefone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(60, 17);
            this.labTelefone.TabIndex = 51;
            this.labTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(637, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(8, 108);
            this.labEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(47, 17);
            this.labEmail.TabIndex = 53;
            this.labEmail.Text = "E-mail:";
            // 
            // labContador
            // 
            this.labContador.AutoSize = true;
            this.labContador.Location = new System.Drawing.Point(354, 77);
            this.labContador.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labContador.Name = "labContador";
            this.labContador.Size = new System.Drawing.Size(66, 17);
            this.labContador.TabIndex = 55;
            this.labContador.Text = "Contador:";
            // 
            // cbContador
            // 
            this.cbContador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContador.Enabled = false;
            this.cbContador.FormattingEnabled = true;
            this.cbContador.Location = new System.Drawing.Point(426, 74);
            this.cbContador.Name = "cbContador";
            this.cbContador.Size = new System.Drawing.Size(283, 25);
            this.cbContador.TabIndex = 5;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(11, 158);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(698, 71);
            this.txtObservacao.TabIndex = 8;
            // 
            // labObservacao
            // 
            this.labObservacao.AutoSize = true;
            this.labObservacao.Location = new System.Drawing.Point(8, 138);
            this.labObservacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labObservacao.Name = "labObservacao";
            this.labObservacao.Size = new System.Drawing.Size(81, 17);
            this.labObservacao.TabIndex = 57;
            this.labObservacao.Text = "Observação:";
            // 
            // pForm
            // 
            this.pForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pForm.BackColor = System.Drawing.SystemColors.Control;
            this.pForm.Controls.Add(this.btnSalvar);
            this.pForm.Controls.Add(this.btnEditar);
            this.pForm.Controls.Add(this.btnInativarAtivar);
            this.pForm.Controls.Add(this.tabControl1);
            this.pForm.Location = new System.Drawing.Point(1, 32);
            this.pForm.Margin = new System.Windows.Forms.Padding(1);
            this.pForm.Name = "pForm";
            this.pForm.Padding = new System.Windows.Forms.Padding(10);
            this.pForm.Size = new System.Drawing.Size(757, 313);
            this.pForm.TabIndex = 58;
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
            this.btnSalvar.Location = new System.Drawing.Point(660, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 61;
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
            this.btnEditar.Location = new System.Drawing.Point(563, 10);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 62;
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
            this.btnInativarAtivar.Location = new System.Drawing.Point(466, 10);
            this.btnInativarAtivar.Margin = new System.Windows.Forms.Padding(0);
            this.btnInativarAtivar.Name = "btnInativarAtivar";
            this.btnInativarAtivar.Size = new System.Drawing.Size(87, 30);
            this.btnInativarAtivar.TabIndex = 63;
            this.btnInativarAtivar.Text = "Inativar";
            this.btnInativarAtivar.UseVisualStyleBackColor = false;
            this.btnInativarAtivar.Click += new System.EventHandler(this.btnInativarAtivar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Location = new System.Drawing.Point(13, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 274);
            this.tabControl1.TabIndex = 64;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.labID);
            this.tpInfo.Controls.Add(this.txtID);
            this.tpInfo.Controls.Add(this.labRazao);
            this.tpInfo.Controls.Add(this.labRegime);
            this.tpInfo.Controls.Add(this.cbRegime);
            this.tpInfo.Controls.Add(this.txtTelefone);
            this.tpInfo.Controls.Add(this.labObservacao);
            this.tpInfo.Controls.Add(this.labIE);
            this.tpInfo.Controls.Add(this.labTelefone);
            this.tpInfo.Controls.Add(this.mtbCNPJ);
            this.tpInfo.Controls.Add(this.labCNPJ);
            this.tpInfo.Controls.Add(this.txtObservacao);
            this.tpInfo.Controls.Add(this.txtEmail);
            this.tpInfo.Controls.Add(this.txtRazao);
            this.tpInfo.Controls.Add(this.labFantasia);
            this.tpInfo.Controls.Add(this.labContador);
            this.tpInfo.Controls.Add(this.labEmail);
            this.tpInfo.Controls.Add(this.mtbIE);
            this.tpInfo.Controls.Add(this.txtNome);
            this.tpInfo.Controls.Add(this.cbContador);
            this.tpInfo.Location = new System.Drawing.Point(4, 26);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(5);
            this.tpInfo.Size = new System.Drawing.Size(723, 244);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Informações";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(551, 19);
            this.labID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 17);
            this.labID.TabIndex = 59;
            this.labID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(580, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 25);
            this.txtID.TabIndex = 58;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(708, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 32);
            this.btnFechar.TabIndex = 60;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labTitulo.Location = new System.Drawing.Point(5, 5);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(79, 25);
            this.labTitulo.TabIndex = 59;
            this.labTitulo.Text = "Cliente";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(759, 346);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.pForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEmpresa_KeyDown);
            this.pForm.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
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
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.Label labIE;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInativarAtivar;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TextBox txtID;
    }
}