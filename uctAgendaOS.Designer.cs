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
            this.Busca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(8, 14);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(44, 17);
            this.Busca.TabIndex = 0;
            this.Busca.Text = "Busca:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(58, 8);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(400, 29);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.AllowUserToOrderColumns = true;
            this.dgvOS.AllowUserToResizeRows = false;
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Nome_Cliente,
            this.Assunto,
            this.Abertura,
            this.Usuário,
            this.Nome_Usuario,
            this.Situação});
            this.dgvOS.Location = new System.Drawing.Point(8, 43);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.ReadOnly = true;
            this.dgvOS.Size = new System.Drawing.Size(784, 408);
            this.dgvOS.TabIndex = 6;
            this.dgvOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOS_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ID_Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Visible = false;
            this.Cliente.Width = 50;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.DataPropertyName = "Nome_Cliente";
            this.Nome_Cliente.HeaderText = "Cliente";
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            this.Nome_Cliente.Width = 150;
            // 
            // Assunto
            // 
            this.Assunto.DataPropertyName = "Assunto";
            this.Assunto.HeaderText = "Assunto";
            this.Assunto.Name = "Assunto";
            this.Assunto.ReadOnly = true;
            this.Assunto.Width = 200;
            // 
            // Abertura
            // 
            this.Abertura.DataPropertyName = "Abertura";
            this.Abertura.HeaderText = "Abertura";
            this.Abertura.Name = "Abertura";
            this.Abertura.ReadOnly = true;
            // 
            // Usuário
            // 
            this.Usuário.DataPropertyName = "ID_Usuario";
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.Name = "Usuário";
            this.Usuário.ReadOnly = true;
            this.Usuário.Visible = false;
            this.Usuário.Width = 50;
            // 
            // Nome_Usuario
            // 
            this.Nome_Usuario.DataPropertyName = "Nome_Usuario";
            this.Nome_Usuario.HeaderText = "Usuário";
            this.Nome_Usuario.Name = "Nome_Usuario";
            this.Nome_Usuario.ReadOnly = true;
            // 
            // Situação
            // 
            this.Situação.DataPropertyName = "Situacao";
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Agenda_OS.Properties.Resources.EditX32;
            this.btnEditar.Location = new System.Drawing.Point(686, 457);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::Agenda_OS.Properties.Resources.NewX32;
            this.btnNovo.Location = new System.Drawing.Point(742, 457);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // UctAgendaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvOS);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.Busca);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UctAgendaOS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
    }
}
