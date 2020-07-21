namespace Agenda_OS
{
    partial class FormEmpresa
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
            this.pTittulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labID = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pFooter = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.pTittulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTittulo
            // 
            this.pTittulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pTittulo.Controls.Add(this.btnFechar);
            this.pTittulo.Controls.Add(this.labID);
            this.pTittulo.Controls.Add(this.labNum);
            this.pTittulo.Controls.Add(this.labTitulo);
            this.pTittulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTittulo.Location = new System.Drawing.Point(0, 0);
            this.pTittulo.Margin = new System.Windows.Forms.Padding(5);
            this.pTittulo.Name = "pTittulo";
            this.pTittulo.Size = new System.Drawing.Size(624, 50);
            this.pTittulo.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Agenda_OS.Properties.Resources.CloseX32;
            this.btnFechar.Location = new System.Drawing.Point(574, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labID
            // 
            this.labID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.ForeColor = System.Drawing.Color.White;
            this.labID.Location = new System.Drawing.Point(493, 9);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(23, 25);
            this.labID.TabIndex = 5;
            this.labID.Text = "0";
            // 
            // labNum
            // 
            this.labNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNum.ForeColor = System.Drawing.Color.White;
            this.labNum.Location = new System.Drawing.Point(424, 9);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(33, 25);
            this.labNum.TabIndex = 4;
            this.labNum.Text = "nº";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.White;
            this.labTitulo.Location = new System.Drawing.Point(12, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(87, 25);
            this.labTitulo.TabIndex = 2;
            this.labTitulo.Text = "Empresa";
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 458);
            this.pFooter.Margin = new System.Windows.Forms.Padding(5);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(624, 20);
            this.pFooter.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Image = global::Agenda_OS.Properties.Resources.TrashX32;
            this.btnDeletar.Location = new System.Drawing.Point(450, 400);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(50, 50);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Agenda_OS.Properties.Resources.EditX32;
            this.btnEditar.Location = new System.Drawing.Point(506, 400);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Agenda_OS.Properties.Resources.SaveX32;
            this.btnSalvar.Location = new System.Drawing.Point(562, 400);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labRazao
            // 
            this.labRazao.AutoSize = true;
            this.labRazao.Location = new System.Drawing.Point(9, 60);
            this.labRazao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labRazao.Name = "labRazao";
            this.labRazao.Size = new System.Drawing.Size(44, 17);
            this.labRazao.TabIndex = 38;
            this.labRazao.Text = "Razão";
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbCNPJ.Location = new System.Drawing.Point(298, 80);
            this.mtbCNPJ.Mask = " 99,999,999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(154, 25);
            this.mtbCNPJ.TabIndex = 1;
            this.mtbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(12, 80);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(280, 25);
            this.txtRazao.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 133);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 25);
            this.txtNome.TabIndex = 3;
            // 
            // mtbIE
            // 
            this.mtbIE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbIE.Location = new System.Drawing.Point(458, 80);
            this.mtbIE.Mask = " 999,999,999,999";
            this.mtbIE.Name = "mtbIE";
            this.mtbIE.Size = new System.Drawing.Size(154, 25);
            this.mtbIE.TabIndex = 2;
            this.mtbIE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labFantasia
            // 
            this.labFantasia.AutoSize = true;
            this.labFantasia.Location = new System.Drawing.Point(9, 113);
            this.labFantasia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labFantasia.Name = "labFantasia";
            this.labFantasia.Size = new System.Drawing.Size(55, 17);
            this.labFantasia.TabIndex = 44;
            this.labFantasia.Text = "Fantasia";
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(295, 60);
            this.labCNPJ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(37, 17);
            this.labCNPJ.TabIndex = 46;
            this.labCNPJ.Text = "CNPJ";
            // 
            // labIE
            // 
            this.labIE.AutoSize = true;
            this.labIE.Location = new System.Drawing.Point(455, 60);
            this.labIE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labIE.Name = "labIE";
            this.labIE.Size = new System.Drawing.Size(18, 17);
            this.labIE.TabIndex = 47;
            this.labIE.Text = "IE";
            // 
            // cbRegime
            // 
            this.cbRegime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegime.FormattingEnabled = true;
            this.cbRegime.Items.AddRange(new object[] {
            "Lucro",
            "Simples"});
            this.cbRegime.Location = new System.Drawing.Point(298, 133);
            this.cbRegime.Name = "cbRegime";
            this.cbRegime.Size = new System.Drawing.Size(154, 25);
            this.cbRegime.TabIndex = 4;
            // 
            // labRegime
            // 
            this.labRegime.AutoSize = true;
            this.labRegime.Location = new System.Drawing.Point(295, 113);
            this.labRegime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labRegime.Name = "labRegime";
            this.labRegime.Size = new System.Drawing.Size(52, 17);
            this.labRegime.TabIndex = 49;
            this.labRegime.Text = "Regime";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 186);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(280, 25);
            this.txtTelefone.TabIndex = 6;
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(9, 166);
            this.labTelefone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(57, 17);
            this.labTelefone.TabIndex = 51;
            this.labTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(298, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(295, 166);
            this.labEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(39, 17);
            this.labEmail.TabIndex = 53;
            this.labEmail.Text = "Email";
            // 
            // labContador
            // 
            this.labContador.AutoSize = true;
            this.labContador.Location = new System.Drawing.Point(455, 113);
            this.labContador.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labContador.Name = "labContador";
            this.labContador.Size = new System.Drawing.Size(63, 17);
            this.labContador.TabIndex = 55;
            this.labContador.Text = "Contador";
            // 
            // cbContador
            // 
            this.cbContador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContador.FormattingEnabled = true;
            this.cbContador.Location = new System.Drawing.Point(458, 133);
            this.cbContador.Name = "cbContador";
            this.cbContador.Size = new System.Drawing.Size(154, 25);
            this.cbContador.TabIndex = 5;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 239);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(600, 150);
            this.txtObservacao.TabIndex = 8;
            // 
            // labObservacao
            // 
            this.labObservacao.AutoSize = true;
            this.labObservacao.Location = new System.Drawing.Point(9, 219);
            this.labObservacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labObservacao.Name = "labObservacao";
            this.labObservacao.Size = new System.Drawing.Size(78, 17);
            this.labObservacao.TabIndex = 57;
            this.labObservacao.Text = "Observação";
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 478);
            this.Controls.Add(this.labObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labContador);
            this.Controls.Add(this.cbContador);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labRegime);
            this.Controls.Add(this.cbRegime);
            this.Controls.Add(this.labIE);
            this.Controls.Add(this.labCNPJ);
            this.Controls.Add(this.labFantasia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtbIE);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.labRazao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pTittulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEmpresa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEmpresa_KeyDown);
            this.pTittulo.ResumeLayout(false);
            this.pTittulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTittulo;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
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
    }
}