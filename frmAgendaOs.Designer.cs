namespace Agenda_OS
{
    partial class frmAgendaOs
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnAgendaOS = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnServicos);
            this.pnlMenu.Controls.Add(this.btnTecnicos);
            this.pnlMenu.Controls.Add(this.btnAgendaOS);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 75);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(520, 0);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(100, 75);
            this.btnServicos.TabIndex = 4;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.Location = new System.Drawing.Point(414, 0);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(100, 75);
            this.btnTecnicos.TabIndex = 3;
            this.btnTecnicos.Text = "Técnicos";
            this.btnTecnicos.UseVisualStyleBackColor = true;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnAgendaOS
            // 
            this.btnAgendaOS.Location = new System.Drawing.Point(308, 0);
            this.btnAgendaOS.Name = "btnAgendaOS";
            this.btnAgendaOS.Size = new System.Drawing.Size(100, 75);
            this.btnAgendaOS.TabIndex = 2;
            this.btnAgendaOS.Text = "Agenda - OS";
            this.btnAgendaOS.UseVisualStyleBackColor = true;
            this.btnAgendaOS.Click += new System.EventHandler(this.btnAgendaOS_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(202, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 75);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlUC
            // 
            this.pnlUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUC.Location = new System.Drawing.Point(0, 75);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(800, 515);
            this.pnlUC.TabIndex = 1;
            // 
            // frmAgendaOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.pnlMenu);
            this.KeyPreview = true;
            this.Name = "frmAgendaOs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda-Os";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgendaOs_FormClosing);
            this.Load += new System.EventHandler(this.frmAgendaOs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgendaOs_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgendaOs_KeyPress);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnAgendaOS;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Button btnServicos;
    }
}

