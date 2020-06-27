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
            this.Total = new System.Windows.Forms.Label();
            this.Filtrados = new System.Windows.Forms.Label();
            this.labNT = new System.Windows.Forms.Label();
            this.labNF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(3, 13);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(44, 17);
            this.Busca.TabIndex = 0;
            this.Busca.Text = "Busca:";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(586, 18);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 17);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total:";
            // 
            // Filtrados
            // 
            this.Filtrados.AutoSize = true;
            this.Filtrados.Location = new System.Drawing.Point(682, 18);
            this.Filtrados.Name = "Filtrados";
            this.Filtrados.Size = new System.Drawing.Size(61, 17);
            this.Filtrados.TabIndex = 2;
            this.Filtrados.Text = "Filtrados:";
            // 
            // labNT
            // 
            this.labNT.AutoSize = true;
            this.labNT.Location = new System.Drawing.Point(758, 18);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(15, 17);
            this.labNT.TabIndex = 4;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNF
            // 
            this.labNF.AutoSize = true;
            this.labNF.Location = new System.Drawing.Point(644, 18);
            this.labNF.Name = "labNF";
            this.labNF.Size = new System.Drawing.Size(15, 17);
            this.labNF.TabIndex = 3;
            this.labNF.Text = "0";
            this.labNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 25);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(709, 472);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 30);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(520, 472);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 30);
            this.btnDeletar.TabIndex = 8;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(615, 472);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 30);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // UctAgendaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.labNF);
            this.Controls.Add(this.Filtrados);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Busca);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UctAgendaOS";
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Filtrados;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.Label labNF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
    }
}
