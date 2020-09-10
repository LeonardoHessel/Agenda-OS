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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UctClientes));
            this.txtBuscaEmpresa = new System.Windows.Forms.TextBox();
            this.Busca = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ilBotoes = new System.Windows.Forms.ImageList(this.components);
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
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltroStatus = new System.Windows.Forms.GroupBox();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.rbtnAtivos = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbFiltroStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscaEmpresa
            // 
            this.txtBuscaEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaEmpresa.Location = new System.Drawing.Point(97, 28);
            this.txtBuscaEmpresa.Name = "txtBuscaEmpresa";
            this.txtBuscaEmpresa.Size = new System.Drawing.Size(300, 29);
            this.txtBuscaEmpresa.TabIndex = 0;
            this.txtBuscaEmpresa.TextChanged += new System.EventHandler(this.txtBuscaEmpresa_TextChanged);
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(97, 8);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(44, 17);
            this.Busca.TabIndex = 1;
            this.Busca.Text = "Busca:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.ilBotoes;
            this.btnNovo.Location = new System.Drawing.Point(742, 49);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // ilBotoes
            // 
            this.ilBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBotoes.ImageStream")));
            this.ilBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBotoes.Images.SetKeyName(0, "icons8_add_file.ico");
            this.ilBotoes.Images.SetKeyName(1, "icons8_edit.ico");
            this.ilBotoes.Images.SetKeyName(2, "icons8_save.ico");
            this.ilBotoes.Images.SetKeyName(3, "icons8_trash.ico");
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageIndex = 1;
            this.btnEditar.ImageList = this.ilBotoes;
            this.btnEditar.Location = new System.Drawing.Point(686, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colEmail,
            this.colTelefone,
            this.colObservacao,
            this.colDel});
            this.dgvClientes.Location = new System.Drawing.Point(8, 105);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(784, 402);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientes_MouseDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colCNPJ
            // 
            this.colCNPJ.DataPropertyName = "cnpj";
            this.colCNPJ.HeaderText = "CNPJ";
            this.colCNPJ.Name = "colCNPJ";
            this.colCNPJ.ReadOnly = true;
            // 
            // colIE
            // 
            this.colIE.DataPropertyName = "ie";
            this.colIE.HeaderText = "IE";
            this.colIE.Name = "colIE";
            this.colIE.ReadOnly = true;
            // 
            // colRazao
            // 
            this.colRazao.DataPropertyName = "razao";
            this.colRazao.HeaderText = "Razão";
            this.colRazao.Name = "colRazao";
            this.colRazao.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colRegime
            // 
            this.colRegime.DataPropertyName = "regime";
            this.colRegime.HeaderText = "Regime";
            this.colRegime.Name = "colRegime";
            this.colRegime.ReadOnly = true;
            // 
            // colContador
            // 
            this.colContador.DataPropertyName = "contador";
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
            this.colLogradouro.DataPropertyName = "logradouro";
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
            // colEmail
            // 
            this.colEmail.DataPropertyName = "telefone";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.DataPropertyName = "telefone";
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colObservacao
            // 
            this.colObservacao.DataPropertyName = "obsevacao";
            this.colObservacao.HeaderText = "Observação";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.ReadOnly = true;
            // 
            // colDel
            // 
            this.colDel.DataPropertyName = "del";
            this.colDel.HeaderText = "Ativo";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Visible = false;
            // 
            // gbFiltroStatus
            // 
            this.gbFiltroStatus.Controls.Add(this.rbtnInativo);
            this.gbFiltroStatus.Controls.Add(this.rbtnAtivos);
            this.gbFiltroStatus.Controls.Add(this.rbtnTodos);
            this.gbFiltroStatus.Location = new System.Drawing.Point(8, 8);
            this.gbFiltroStatus.Name = "gbFiltroStatus";
            this.gbFiltroStatus.Padding = new System.Windows.Forms.Padding(1);
            this.gbFiltroStatus.Size = new System.Drawing.Size(83, 91);
            this.gbFiltroStatus.TabIndex = 10;
            this.gbFiltroStatus.TabStop = false;
            this.gbFiltroStatus.Text = "Status";
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(4, 67);
            this.rbtnInativo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(70, 21);
            this.rbtnInativo.TabIndex = 2;
            this.rbtnInativo.Text = "Inativos";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            this.rbtnInativo.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbtnAtivos
            // 
            this.rbtnAtivos.AutoSize = true;
            this.rbtnAtivos.Location = new System.Drawing.Point(4, 43);
            this.rbtnAtivos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rbtnAtivos.Name = "rbtnAtivos";
            this.rbtnAtivos.Size = new System.Drawing.Size(61, 21);
            this.rbtnAtivos.TabIndex = 1;
            this.rbtnAtivos.Text = "Ativos";
            this.rbtnAtivos.UseVisualStyleBackColor = true;
            this.rbtnAtivos.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Checked = true;
            this.rbtnTodos.Location = new System.Drawing.Point(4, 19);
            this.rbtnTodos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(62, 21);
            this.rbtnTodos.TabIndex = 0;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // UctClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.gbFiltroStatus);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.txtBuscaEmpresa);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctClientes";
            this.Padding = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.ImageList ilBotoes;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDel;
        private System.Windows.Forms.GroupBox gbFiltroStatus;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.RadioButton rbtnAtivos;
        private System.Windows.Forms.RadioButton rbtnTodos;
    }
}
