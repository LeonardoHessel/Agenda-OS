namespace Agenda_OS
{
    partial class UctAgendaOS
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
            this.labBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID_Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.labUsuario = new System.Windows.Forms.Label();
            this.gbFiltroStatus = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInativos = new System.Windows.Forms.RadioButton();
            this.rbAtivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.gbFiltroStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labBusca
            // 
            this.labBusca.AutoSize = true;
            this.labBusca.Location = new System.Drawing.Point(8, 5);
            this.labBusca.Name = "labBusca";
            this.labBusca.Size = new System.Drawing.Size(41, 17);
            this.labBusca.TabIndex = 0;
            this.labBusca.Text = "Busca";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(8, 25);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(300, 29);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.option_Changed);
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToResizeRows = false;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome_Cliente,
            this.colAssunto,
            this.colSituacao,
            this.colNome_Usuario,
            this.colAtendimento,
            this.colAbertura,
            this.colFechamento,
            this.colDescricao,
            this.colSolucao,
            this.colSolicitante,
            this.colID_Cliente,
            this.colID_Produto,
            this.colID_Usuário,
            this.colAtivo,
            this.colMSG});
            this.dgvOS.Location = new System.Drawing.Point(8, 64);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.RowHeadersVisible = false;
            this.dgvOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOS.Size = new System.Drawing.Size(784, 443);
            this.dgvOS.TabIndex = 6;
            this.dgvOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colNome_Cliente
            // 
            this.colNome_Cliente.DataPropertyName = "Nome_Cliente";
            this.colNome_Cliente.HeaderText = "Cliente";
            this.colNome_Cliente.Name = "colNome_Cliente";
            this.colNome_Cliente.ReadOnly = true;
            this.colNome_Cliente.Width = 200;
            // 
            // colAssunto
            // 
            this.colAssunto.DataPropertyName = "Assunto";
            this.colAssunto.HeaderText = "Assunto";
            this.colAssunto.Name = "colAssunto";
            this.colAssunto.ReadOnly = true;
            this.colAssunto.Width = 200;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "Situacao";
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Width = 75;
            // 
            // colNome_Usuario
            // 
            this.colNome_Usuario.DataPropertyName = "Nome_Usuario";
            this.colNome_Usuario.HeaderText = "Usuário";
            this.colNome_Usuario.Name = "colNome_Usuario";
            this.colNome_Usuario.ReadOnly = true;
            this.colNome_Usuario.Width = 75;
            // 
            // colAtendimento
            // 
            this.colAtendimento.DataPropertyName = "Atendimento";
            this.colAtendimento.HeaderText = "Atendimento";
            this.colAtendimento.Name = "colAtendimento";
            this.colAtendimento.ReadOnly = true;
            // 
            // colAbertura
            // 
            this.colAbertura.DataPropertyName = "Abertura";
            this.colAbertura.HeaderText = "Abertura";
            this.colAbertura.Name = "colAbertura";
            this.colAbertura.ReadOnly = true;
            this.colAbertura.Width = 115;
            // 
            // colFechamento
            // 
            this.colFechamento.DataPropertyName = "Fechamento";
            this.colFechamento.HeaderText = "Fechamento";
            this.colFechamento.Name = "colFechamento";
            this.colFechamento.ReadOnly = true;
            this.colFechamento.Width = 115;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Visible = false;
            // 
            // colSolucao
            // 
            this.colSolucao.DataPropertyName = "Solucao";
            this.colSolucao.HeaderText = "Solução";
            this.colSolucao.Name = "colSolucao";
            this.colSolucao.ReadOnly = true;
            this.colSolucao.Visible = false;
            // 
            // colSolicitante
            // 
            this.colSolicitante.DataPropertyName = "Solicitante";
            this.colSolicitante.HeaderText = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.ReadOnly = true;
            this.colSolicitante.Visible = false;
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.DataPropertyName = "ID_Cliente";
            this.colID_Cliente.HeaderText = "ID Cliente";
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.ReadOnly = true;
            this.colID_Cliente.Visible = false;
            // 
            // colID_Produto
            // 
            this.colID_Produto.DataPropertyName = "ID_Produto";
            this.colID_Produto.HeaderText = "ID Produto";
            this.colID_Produto.Name = "colID_Produto";
            this.colID_Produto.ReadOnly = true;
            this.colID_Produto.Visible = false;
            // 
            // colID_Usuário
            // 
            this.colID_Usuário.DataPropertyName = "ID_Usuario";
            this.colID_Usuário.HeaderText = "ID Usuário";
            this.colID_Usuário.Name = "colID_Usuário";
            this.colID_Usuário.ReadOnly = true;
            this.colID_Usuário.Visible = false;
            // 
            // colAtivo
            // 
            this.colAtivo.DataPropertyName = "Ativo";
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAtivo.Visible = false;
            // 
            // colMSG
            // 
            this.colMSG.DataPropertyName = "MSG";
            this.colMSG.HeaderText = "Mensagem";
            this.colMSG.Name = "colMSG";
            this.colMSG.ReadOnly = true;
            this.colMSG.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Agenda_OS.Properties.Resources.EditX32;
            this.btnEditar.Location = new System.Drawing.Point(686, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::Agenda_OS.Properties.Resources.NewX32;
            this.btnNovo.Location = new System.Drawing.Point(742, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.DisplayMember = "Nome";
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(530, 25);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(150, 29);
            this.cbUsuario.TabIndex = 14;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.option_Changed);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(530, 5);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(53, 17);
            this.labUsuario.TabIndex = 15;
            this.labUsuario.Text = "Usuário";
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
            this.gbFiltroStatus.TabIndex = 16;
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
            // UctAgendaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.gbFiltroStatus);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvOS);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.labBusca);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UctAgendaOS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.gbFiltroStatus.ResumeLayout(false);
            this.gbFiltroStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.GroupBox gbFiltroStatus;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbInativos;
        private System.Windows.Forms.RadioButton rbAtivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Usuário;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSG;
    }
}
