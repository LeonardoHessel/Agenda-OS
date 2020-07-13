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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UctUsuario));
            this.labBuscar = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ilBotoes = new System.Windows.Forms.ImageList(this.components);
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
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
            this.labBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(8, 43);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(44, 17);
            this.labBuscar.TabIndex = 0;
            this.labBuscar.Text = "Busca:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.ilBotoes;
            this.btnNovo.Location = new System.Drawing.Point(83, 104);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 50);
            this.btnNovo.TabIndex = 1;
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
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(58, 37);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(300, 29);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ImageIndex = 1;
            this.btnEditar.ImageList = this.ilBotoes;
            this.btnEditar.Location = new System.Drawing.Point(27, 104);
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
            this.dgvTecnico.AllowUserToResizeRows = false;
            this.dgvTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTecnico.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTecnico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Location = new System.Drawing.Point(0, 199);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.ReadOnly = true;
            this.dgvTecnico.Size = new System.Drawing.Size(660, 398);
            this.dgvTecnico.TabIndex = 5;
            
            this.dgvTecnico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTecnico_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // Selecionado
            // 
            this.Selecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Selecionado.AutoSize = true;
            this.Selecionado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionado.Location = new System.Drawing.Point(548, 137);
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Size = new System.Drawing.Size(61, 17);
            this.Selecionado.TabIndex = 7;
            this.Selecionado.Text = "Filtrados:";
            // 
            // labNS
            // 
            this.labNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNS.AutoSize = true;
            this.labNS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNS.Location = new System.Drawing.Point(615, 137);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(15, 17);
            this.labNS.TabIndex = 9;
            this.labNS.Text = "0";
            this.labNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labNT
            // 
            this.labNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labNT.AutoSize = true;
            this.labNT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNT.Location = new System.Drawing.Point(479, 137);
            this.labNT.Name = "labNT";
            this.labNT.Size = new System.Drawing.Size(15, 17);
            this.labNT.TabIndex = 8;
            this.labNT.Text = "0";
            this.labNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbDeletados
            // 
            this.chbDeletados.AutoSize = true;
            this.chbDeletados.Location = new System.Drawing.Point(364, 42);
            this.chbDeletados.Name = "chbDeletados";
            this.chbDeletados.Size = new System.Drawing.Size(106, 21);
            this.chbDeletados.TabIndex = 2;
            this.chbDeletados.Text = "Listar inativos";
            this.chbDeletados.UseVisualStyleBackColor = true;
            this.chbDeletados.CheckedChanged += new System.EventHandler(this.chbDeletados_CheckedChanged);
            // 
            // UctUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selecionado);
            this.Controls.Add(this.labNS);
            this.Controls.Add(this.labNT);
            this.Controls.Add(this.chbDeletados);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labBuscar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UctUsuario";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(660, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Selecionado;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.Label labNT;
        private System.Windows.Forms.CheckBox chbDeletados;
        private System.Windows.Forms.ImageList ilBotoes;
    }
}
