﻿namespace Agenda_OS
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.Filtrados = new System.Windows.Forms.Label();
            this.labNT = new System.Windows.Forms.Label();
            this.labNF = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ilBotoes = new System.Windows.Forms.ImageList(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cblinativos = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(78, 39);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(300, 29);
            this.txtbuscar.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(441, 148);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(39, 17);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total:";
            // 
            // Filtrados
            // 
            this.Filtrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrados.AutoSize = true;
            this.Filtrados.Location = new System.Drawing.Point(530, 148);
            this.Filtrados.Name = "Filtrados";
            this.Filtrados.Size = new System.Drawing.Size(61, 17);
            this.Filtrados.TabIndex = 3;
            this.Filtrados.Text = "Filtrados:";
            // 
            // labNT
            // 
            this.labNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNT.AutoSize = true;
            this.labNT.Location = new System.Drawing.Point(486, 148);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(15, 17);
            this.labNT.TabIndex = 4;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNF
            // 
            this.labNF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNF.AutoSize = true;
            this.labNF.Location = new System.Drawing.Point(597, 148);
            this.labNF.Name = "labNF";
            this.labNF.Size = new System.Drawing.Size(15, 17);
            this.labNF.TabIndex = 5;
            this.labNF.Text = "0";
            this.labNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.ilBotoes;
            this.btnNovo.Location = new System.Drawing.Point(78, 115);
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
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageIndex = 1;
            this.btnEditar.ImageList = this.ilBotoes;
            this.btnEditar.Location = new System.Drawing.Point(22, 115);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 199);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(660, 398);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // cblinativos
            // 
            this.cblinativos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cblinativos.AutoSize = true;
            this.cblinativos.Location = new System.Drawing.Point(384, 44);
            this.cblinativos.Name = "cblinativos";
            this.cblinativos.Size = new System.Drawing.Size(106, 21);
            this.cblinativos.TabIndex = 10;
            this.cblinativos.Text = "Listar inativos";
            this.cblinativos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Editar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Novo";
            // 
            // UctClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cblinativos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labNF);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.Filtrados);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txtbuscar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctClientes";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(660, 597);
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Filtrados;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.Label labNF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ImageList ilBotoes;
        private System.Windows.Forms.CheckBox cblinativos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
