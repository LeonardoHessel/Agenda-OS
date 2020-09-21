namespace Agenda_OS
{
    partial class UctUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UctUsuario));
            this.labBuscar = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltroStatus = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInativos = new System.Windows.Forms.RadioButton();
            this.rbAtivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
            this.gbFiltroStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(8, 5);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(44, 17);
            this.labBuscar.TabIndex = 0;
            this.labBuscar.Text = "Busca:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(742, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(8, 25);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(300, 29);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.option_Changed);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(686, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.AllowUserToAddRows = false;
            this.dgvTecnico.AllowUserToDeleteRows = false;
            this.dgvTecnico.AllowUserToOrderColumns = true;
            this.dgvTecnico.AllowUserToResizeRows = false;
            this.dgvTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTecnico.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Login,
            this.Senha,
            this.Nome,
            this.Nascimento,
            this.Sexo,
            this.RG,
            this.CPF,
            this.CNH});
            this.dgvTecnico.Location = new System.Drawing.Point(8, 64);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.ReadOnly = true;
            this.dgvTecnico.RowHeadersVisible = false;
            this.dgvTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecnico.Size = new System.Drawing.Size(784, 443);
            this.dgvTecnico.TabIndex = 5;
            this.dgvTecnico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTecnico_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Nascimento
            // 
            this.Nascimento.DataPropertyName = "nasc";
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 75;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "rg";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // CNH
            // 
            this.CNH.DataPropertyName = "cnh";
            this.CNH.HeaderText = "CNH";
            this.CNH.Name = "CNH";
            this.CNH.ReadOnly = true;
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
            // UctUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.gbFiltroStatus);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labBuscar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctUsuario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            this.gbFiltroStatus.ResumeLayout(false);
            this.gbFiltroStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNH;
        private System.Windows.Forms.GroupBox gbFiltroStatus;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbInativos;
        private System.Windows.Forms.RadioButton rbAtivos;
    }
}
