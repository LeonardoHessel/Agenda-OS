namespace Agenda_OS
{
    partial class UctServicos
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.Selecionado = new System.Windows.Forms.Label();
            this.labNS = new System.Windows.Forms.Label();
            this.labNT = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(696, 461);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(36, 23);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(43, 13);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(111, 20);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(436, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(633, 23);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total:";
            // 
            // Selecionado
            // 
            this.Selecionado.AutoSize = true;
            this.Selecionado.Location = new System.Drawing.Point(633, 50);
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Size = new System.Drawing.Size(69, 13);
            this.Selecionado.TabIndex = 5;
            this.Selecionado.Text = "Selecionado:";
            // 
            // labNS
            // 
            this.labNS.AutoSize = true;
            this.labNS.Location = new System.Drawing.Point(758, 50);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(13, 13);
            this.labNS.TabIndex = 7;
            this.labNS.Text = "0";
            this.labNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNT
            // 
            this.labNT.AutoSize = true;
            this.labNT.Location = new System.Drawing.Point(758, 23);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(13, 13);
            this.labNT.TabIndex = 6;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(615, 461);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(534, 461);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // uctServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.labNS);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.Selecionado);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNovo);
            this.Name = "uctServicos";
            this.Size = new System.Drawing.Size(800, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Selecionado;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}
