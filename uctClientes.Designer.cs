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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Busca = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Filtrados = new System.Windows.Forms.Label();
            this.labNT = new System.Windows.Forms.Label();
            this.labNF = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ilBotoes = new System.Windows.Forms.ImageList(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 25);
            this.textBox1.TabIndex = 0;
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(6, 11);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(44, 17);
            this.Busca.TabIndex = 1;
            this.Busca.Text = "Busca:";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(416, 11);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 17);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total:";
            // 
            // Filtrados
            // 
            this.Filtrados.AutoSize = true;
            this.Filtrados.Location = new System.Drawing.Point(577, 11);
            this.Filtrados.Name = "Filtrados";
            this.Filtrados.Size = new System.Drawing.Size(61, 17);
            this.Filtrados.TabIndex = 3;
            this.Filtrados.Text = "Filtrados:";
            // 
            // labNT
            // 
            this.labNT.AutoSize = true;
            this.labNT.Location = new System.Drawing.Point(531, 11);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(15, 17);
            this.labNT.TabIndex = 4;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNF
            // 
            this.labNF.AutoSize = true;
            this.labNF.Location = new System.Drawing.Point(692, 11);
            this.labNF.Name = "labNF";
            this.labNF.Size = new System.Drawing.Size(15, 17);
            this.labNF.TabIndex = 5;
            this.labNF.Text = "0";
            this.labNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ImageIndex = 3;
            this.btnNovo.ImageList = this.ilBotoes;
            this.btnNovo.Location = new System.Drawing.Point(741, 455);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(5, 10, 9, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageKey = "icons8_edit.ico";
            this.btnEditar.ImageList = this.ilBotoes;
            this.btnEditar.Location = new System.Drawing.Point(681, 455);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cnpjcpf,
            this.Nome});
            this.dgvClientes.Location = new System.Drawing.Point(9, 37);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(782, 408);
            this.dgvClientes.TabIndex = 9;
            // 
            // ilBotoes
            // 
            this.ilBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBotoes.ImageStream")));
            this.ilBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBotoes.Images.SetKeyName(0, "icons8_trash.ico");
            this.ilBotoes.Images.SetKeyName(1, "icons8_edit.ico");
            this.ilBotoes.Images.SetKeyName(2, "icons8_save.ico");
            this.ilBotoes.Images.SetKeyName(3, "icons8_add_file.ico");
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // cnpjcpf
            // 
            this.cnpjcpf.HeaderText = "CNPJ / CPF";
            this.cnpjcpf.Name = "cnpjcpf";
            this.cnpjcpf.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // UctClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labNF);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.Filtrados);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UctClientes";
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Filtrados;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.Label labNF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ImageList ilBotoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}
