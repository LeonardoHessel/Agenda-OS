namespace Agenda_OS
{
    partial class UctClientes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscaEmpresa = new System.Windows.Forms.TextBox();
            this.Busca = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbFiltroStatus = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInativos = new System.Windows.Forms.RadioButton();
            this.rbAtivos = new System.Windows.Forms.RadioButton();
            this.pRodape = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbFiltroStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscaEmpresa
            // 
            this.txtBuscaEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaEmpresa.Location = new System.Drawing.Point(8, 25);
            this.txtBuscaEmpresa.Name = "txtBuscaEmpresa";
            this.txtBuscaEmpresa.Size = new System.Drawing.Size(300, 29);
            this.txtBuscaEmpresa.TabIndex = 0;
            this.txtBuscaEmpresa.TextChanged += new System.EventHandler(this.option_Changed);
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(3, 0);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(44, 17);
            this.Busca.TabIndex = 1;
            this.Busca.Text = "Busca:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(114, 93);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 35);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(8, 93);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCNPJ,
            this.colIE,
            this.colRazao,
            this.colNome,
            this.colRegime,
            this.colContador,
            this.colID_Contador,
            this.colLogradouro,
            this.colNumero,
            this.colComplemento,
            this.colCEP,
            this.colBairro,
            this.colMunicipio,
            this.colUF,
            this.colTelefone,
            this.colEmail,
            this.colObservacao,
            this.colDel});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.dgvClientes.Location = new System.Drawing.Point(0, 134);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(800, 341);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientes_MouseDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colCNPJ
            // 
            this.colCNPJ.DataPropertyName = "CNPJ";
            this.colCNPJ.HeaderText = "CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            this.colCNPJ.Width = 110;
            // 
            // colIE
            // 
            this.colIE.DataPropertyName = "IE";
            this.colIE.HeaderText = "IE";
            this.colIE.Name = "colIE";
            this.colIE.ReadOnly = true;
            this.colIE.Visible = false;
            // 
            // colRazao
            // 
            this.colRazao.DataPropertyName = "Razao";
            this.colRazao.HeaderText = "Razão";
            this.colRazao.Name = "colRazao";
            this.colRazao.ReadOnly = true;
            this.colRazao.Visible = false;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colRegime
            // 
            this.colRegime.DataPropertyName = "Regime";
            this.colRegime.HeaderText = "Regime";
            this.colRegime.Name = "colRegime";
            this.colRegime.ReadOnly = true;
            this.colRegime.Visible = false;
            // 
            // colContador
            // 
            this.colContador.DataPropertyName = "Contador";
            this.colContador.HeaderText = "Contador";
            this.colContador.Name = "colContador";
            this.colContador.ReadOnly = true;
            this.colContador.Visible = false;
            // 
            // colID_Contador
            // 
            this.colID_Contador.DataPropertyName = "ID_Contador";
            this.colID_Contador.HeaderText = "ID_Contador";
            this.colID_Contador.Name = "colID_Contador";
            this.colID_Contador.ReadOnly = true;
            this.colID_Contador.Visible = false;
            // 
            // colLogradouro
            // 
            this.colLogradouro.DataPropertyName = "Logradouro";
            this.colLogradouro.HeaderText = "Logradouro";
            this.colLogradouro.Name = "colLogradouro";
            this.colLogradouro.ReadOnly = true;
            this.colLogradouro.Visible = false;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numero";
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Visible = false;
            // 
            // colComplemento
            // 
            this.colComplemento.DataPropertyName = "complemento";
            this.colComplemento.HeaderText = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.ReadOnly = true;
            this.colComplemento.Visible = false;
            // 
            // colCEP
            // 
            this.colCEP.DataPropertyName = "cep";
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.ReadOnly = true;
            this.colCEP.Visible = false;
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Visible = false;
            // 
            // colMunicipio
            // 
            this.colMunicipio.DataPropertyName = "municipio";
            this.colMunicipio.HeaderText = "Município";
            this.colMunicipio.Name = "colMunicipio";
            this.colMunicipio.ReadOnly = true;
            this.colMunicipio.Visible = false;
            // 
            // colUF
            // 
            this.colUF.DataPropertyName = "uf";
            this.colUF.HeaderText = "UF";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Visible = false;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "Telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 150;
            // 
            // colObservacao
            // 
            this.colObservacao.DataPropertyName = "Observacao";
            this.colObservacao.HeaderText = "Observação";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.ReadOnly = true;
            this.colObservacao.Width = 200;
            // 
            // colDel
            // 
            this.colDel.DataPropertyName = "Ativo";
            this.colDel.HeaderText = "Ativo";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDel.Visible = false;
            // 
            // gbFiltroStatus
            // 
            this.gbFiltroStatus.Controls.Add(this.rbTodos);
            this.gbFiltroStatus.Controls.Add(this.rbInativos);
            this.gbFiltroStatus.Controls.Add(this.rbAtivos);
            this.gbFiltroStatus.Location = new System.Drawing.Point(314, 5);
            this.gbFiltroStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbFiltroStatus.Name = "gbFiltroStatus";
            this.gbFiltroStatus.Size = new System.Drawing.Size(210, 50);
            this.gbFiltroStatus.TabIndex = 15;
            this.gbFiltroStatus.TabStop = false;
            this.gbFiltroStatus.Text = "Status";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 21);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(62, 21);
            this.rbTodos.TabIndex = 10;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.option_Changed);
            // 
            // rbInativos
            // 
            this.rbInativos.AutoSize = true;
            this.rbInativos.Location = new System.Drawing.Point(135, 21);
            this.rbInativos.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rbInativos.Name = "rbInativos";
            this.rbInativos.Size = new System.Drawing.Size(70, 21);
            this.rbInativos.TabIndex = 11;
            this.rbInativos.Text = "Inativos";
            this.rbInativos.UseVisualStyleBackColor = true;
            this.rbInativos.CheckedChanged += new System.EventHandler(this.option_Changed);
            // 
            // rbAtivos
            // 
            this.rbAtivos.AutoSize = true;
            this.rbAtivos.Checked = true;
            this.rbAtivos.Location = new System.Drawing.Point(71, 21);
            this.rbAtivos.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rbAtivos.Name = "rbAtivos";
            this.rbAtivos.Size = new System.Drawing.Size(61, 21);
            this.rbAtivos.TabIndex = 12;
            this.rbAtivos.TabStop = true;
            this.rbAtivos.Text = "Ativos";
            this.rbAtivos.UseVisualStyleBackColor = true;
            this.rbAtivos.CheckedChanged += new System.EventHandler(this.option_Changed);
            // 
            // pRodape
            // 
            this.pRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.pRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pRodape.Location = new System.Drawing.Point(0, 475);
            this.pRodape.Margin = new System.Windows.Forms.Padding(0);
            this.pRodape.Name = "pRodape";
            this.pRodape.Size = new System.Drawing.Size(800, 40);
            this.pRodape.TabIndex = 16;
            // 
            // UctClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.gbFiltroStatus);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.txtBuscaEmpresa);
            this.Controls.Add(this.pRodape);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctClientes";
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbFiltroStatus.ResumeLayout(false);
            this.gbFiltroStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscaEmpresa;
        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbFiltroStatus;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbInativos;
        private System.Windows.Forms.RadioButton rbAtivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDel;
        private System.Windows.Forms.Panel pRodape;
    }
}
