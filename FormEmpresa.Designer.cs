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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labId = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labRazao = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.MaskedTextBox();
            this.labFantasia = new System.Windows.Forms.Label();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.labIE = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labRegime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labTelefone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labContador = new System.Windows.Forms.Label();
            this.Contador = new System.Windows.Forms.ComboBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabContato = new System.Windows.Forms.TabPage();
            this.tabContador = new System.Windows.Forms.TabPage();
            this.gbTelefones = new System.Windows.Forms.GroupBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.tabObservacao = new System.Windows.Forms.TabPage();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabContato.SuspendLayout();
            this.gbTelefones.SuspendLayout();
            this.tabObservacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.labId);
            this.panel1.Controls.Add(this.labNum);
            this.panel1.Controls.Add(this.labTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 50);
            this.panel1.TabIndex = 0;
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
            // 
            // labId
            // 
            this.labId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labId.ForeColor = System.Drawing.Color.White;
            this.labId.Location = new System.Drawing.Point(493, 9);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(23, 25);
            this.labId.TabIndex = 5;
            this.labId.Text = "0";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 529);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 20);
            this.panel2.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Image = global::Agenda_OS.Properties.Resources.TrashX32;
            this.btnDeletar.Location = new System.Drawing.Point(434, 456);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(50, 50);
            this.btnDeletar.TabIndex = 37;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Agenda_OS.Properties.Resources.EditX32;
            this.btnEditar.Location = new System.Drawing.Point(490, 456);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::Agenda_OS.Properties.Resources.SaveX32;
            this.btnSalvar.Location = new System.Drawing.Point(546, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 50);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(298, 80);
            this.txtCNPJ.Mask = " 99,999,999/9999-99";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(154, 25);
            this.txtCNPJ.TabIndex = 39;
            this.txtCNPJ.Text = "45913696000185";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(12, 80);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(280, 25);
            this.txtRazao.TabIndex = 40;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(12, 133);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(280, 25);
            this.txtFantasia.TabIndex = 42;
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(458, 80);
            this.txtIE.Mask = " 999,999,999,999";
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(154, 25);
            this.txtIE.TabIndex = 41;
            this.txtIE.Text = "669071366117";
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
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lucro",
            "Simples"});
            this.comboBox2.Location = new System.Drawing.Point(298, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 25);
            this.comboBox2.TabIndex = 48;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 25);
            this.textBox1.TabIndex = 50;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(314, 25);
            this.textBox2.TabIndex = 52;
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
            // Contador
            // 
            this.Contador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Contador.FormattingEnabled = true;
            this.Contador.Items.AddRange(new object[] {
            "Lucro",
            "Simples"});
            this.Contador.Location = new System.Drawing.Point(458, 133);
            this.Contador.Name = "Contador";
            this.Contador.Size = new System.Drawing.Size(154, 25);
            this.Contador.TabIndex = 54;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabContato);
            this.tab.Controls.Add(this.tabContador);
            this.tab.Controls.Add(this.tabObservacao);
            this.tab.Location = new System.Drawing.Point(12, 217);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(600, 233);
            this.tab.TabIndex = 56;
            // 
            // tabContato
            // 
            this.tabContato.Controls.Add(this.gbEmail);
            this.tabContato.Controls.Add(this.gbTelefones);
            this.tabContato.Location = new System.Drawing.Point(4, 26);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContato.Size = new System.Drawing.Size(592, 203);
            this.tabContato.TabIndex = 1;
            this.tabContato.Text = "Contato";
            this.tabContato.UseVisualStyleBackColor = true;
            // 
            // tabContador
            // 
            this.tabContador.Location = new System.Drawing.Point(4, 26);
            this.tabContador.Name = "tabContador";
            this.tabContador.Size = new System.Drawing.Size(592, 203);
            this.tabContador.TabIndex = 2;
            this.tabContador.Text = "Contador";
            this.tabContador.UseVisualStyleBackColor = true;
            // 
            // gbTelefones
            // 
            this.gbTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTelefones.Controls.Add(this.textBox3);
            this.gbTelefones.Location = new System.Drawing.Point(6, 6);
            this.gbTelefones.Name = "gbTelefones";
            this.gbTelefones.Size = new System.Drawing.Size(270, 191);
            this.gbTelefones.TabIndex = 0;
            this.gbTelefones.TabStop = false;
            this.gbTelefones.Text = "Telefones";
            // 
            // gbEmail
            // 
            this.gbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEmail.Location = new System.Drawing.Point(282, 6);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(304, 191);
            this.gbEmail.TabIndex = 1;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Telefones";
            // 
            // tabObservacao
            // 
            this.tabObservacao.Controls.Add(this.txtObservacao);
            this.tabObservacao.Location = new System.Drawing.Point(4, 26);
            this.tabObservacao.Name = "tabObservacao";
            this.tabObservacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabObservacao.Size = new System.Drawing.Size(592, 203);
            this.tabObservacao.TabIndex = 3;
            this.tabObservacao.Text = "Observações";
            this.tabObservacao.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(6, 6);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(580, 191);
            this.txtObservacao.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 24);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 161);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "3259-0000\r\n996328576\r\n32132132\r\n";
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 549);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.labContador);
            this.Controls.Add(this.Contador);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labTelefone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labRegime);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labIE);
            this.Controls.Add(this.labCNPJ);
            this.Controls.Add(this.labFantasia);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.txtIE);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.labRazao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEmpresa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabContato.ResumeLayout(false);
            this.gbTelefones.ResumeLayout(false);
            this.gbTelefones.PerformLayout();
            this.tabObservacao.ResumeLayout(false);
            this.tabObservacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labRazao;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.MaskedTextBox txtIE;
        private System.Windows.Forms.Label labFantasia;
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.Label labIE;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labRegime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labContador;
        private System.Windows.Forms.ComboBox Contador;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabContato;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.GroupBox gbTelefones;
        private System.Windows.Forms.TabPage tabContador;
        private System.Windows.Forms.TabPage tabObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox textBox3;
    }
}