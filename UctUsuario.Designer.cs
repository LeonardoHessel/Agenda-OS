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
            this.labBuscar = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.Selecionado = new System.Windows.Forms.Label();
            this.labNS = new System.Windows.Forms.Label();
            this.labNT = new System.Windows.Forms.Label();
            this.chbDeletados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(9, 9);
            this.labBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(72, 25);
            this.labBuscar.TabIndex = 0;
            this.labBuscar.Text = "Buscar:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(703, 476);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 30);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(89, 9);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(327, 29);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnDeletar
            // 
            this.btnDeletar.AccessibleDescription = "Inativa um usuário";
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Location = new System.Drawing.Point(511, 476);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(88, 30);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(607, 476);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 30);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.AllowUserToAddRows = false;
            this.dgvTecnico.AllowUserToDeleteRows = false;
            this.dgvTecnico.AllowUserToResizeRows = false;
            this.dgvTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvTecnico.Location = new System.Drawing.Point(9, 46);
            this.dgvTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.ReadOnly = true;
            this.dgvTecnico.Size = new System.Drawing.Size(782, 422);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // Selecionado
            // 
            this.Selecionado.AutoSize = true;
            this.Selecionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionado.Location = new System.Drawing.Point(658, 13);
            this.Selecionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Size = new System.Drawing.Size(66, 21);
            this.Selecionado.TabIndex = 7;
            this.Selecionado.Text = "Filtrado:";
            // 
            // labNS
            // 
            this.labNS.AutoSize = true;
            this.labNS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNS.Location = new System.Drawing.Point(732, 13);
            this.labNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(19, 21);
            this.labNS.TabIndex = 9;
            this.labNS.Text = "0";
            this.labNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNT
            // 
            this.labNT.AutoSize = true;
            this.labNT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNT.Location = new System.Drawing.Point(590, 13);
            this.labNT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(19, 21);
            this.labNT.TabIndex = 8;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbDeletados
            // 
            this.chbDeletados.AutoSize = true;
            this.chbDeletados.Location = new System.Drawing.Point(423, 14);
            this.chbDeletados.Name = "chbDeletados";
            this.chbDeletados.Size = new System.Drawing.Size(86, 21);
            this.chbDeletados.TabIndex = 2;
            this.chbDeletados.Text = "Deletados";
            this.chbDeletados.UseVisualStyleBackColor = true;
            this.chbDeletados.CheckedChanged += new System.EventHandler(this.chbDeletados_CheckedChanged);
            // 
            // UctUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.chbDeletados);
            this.Controls.Add(this.labNS);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.Selecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labBuscar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UctUsuario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Selecionado;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNH;
        private System.Windows.Forms.CheckBox chbDeletados;
    }
}
