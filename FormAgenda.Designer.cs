namespace Agenda_OS
{
    partial class FormAgenda
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labUsuarioMone = new System.Windows.Forms.Label();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.pPerfilUsuario = new System.Windows.Forms.Panel();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.tPerfilHide = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pPerfilUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMenu.Controls.Add(this.btnProdutos);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnOS);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(673, 75);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(338, 0);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(75, 75);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(257, 0);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 75);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnOS
            // 
            this.btnOS.Location = new System.Drawing.Point(95, 0);
            this.btnOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(75, 75);
            this.btnOS.TabIndex = 2;
            this.btnOS.Text = "OS";
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.btnAgendaOS_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(176, 0);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 75);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(725, 0);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 75);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 149);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labUsuarioMone
            // 
            this.labUsuarioMone.AutoSize = true;
            this.labUsuarioMone.ForeColor = System.Drawing.Color.White;
            this.labUsuarioMone.Location = new System.Drawing.Point(3, 9);
            this.labUsuarioMone.Name = "labUsuarioMone";
            this.labUsuarioMone.Size = new System.Drawing.Size(93, 17);
            this.labUsuarioMone.TabIndex = 6;
            this.labUsuarioMone.Text = "Usuario Nome";
            // 
            // pnlUC
            // 
            this.pnlUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUC.Location = new System.Drawing.Point(0, 76);
            this.pnlUC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(800, 515);
            this.pnlUC.TabIndex = 1;
            // 
            // pPerfilUsuario
            // 
            this.pPerfilUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pPerfilUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.pPerfilUsuario.Controls.Add(this.btnEditarUsuario);
            this.pPerfilUsuario.Controls.Add(this.btnLogout);
            this.pPerfilUsuario.Controls.Add(this.labUsuarioMone);
            this.pPerfilUsuario.Location = new System.Drawing.Point(676, 0);
            this.pPerfilUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pPerfilUsuario.Name = "pPerfilUsuario";
            this.pPerfilUsuario.Size = new System.Drawing.Size(124, 178);
            this.pPerfilUsuario.TabIndex = 0;
            this.pPerfilUsuario.Visible = false;
            this.pPerfilUsuario.MouseEnter += new System.EventHandler(this.pPerfilUsuario_MouseEnter);
            this.pPerfilUsuario.MouseLeave += new System.EventHandler(this.pPerfilUsuario_MouseLeave);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditarUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.Location = new System.Drawing.Point(0, 120);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(124, 29);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // tPerfilHide
            // 
            this.tPerfilHide.Interval = 1000;
            this.tPerfilHide.Tick += new System.EventHandler(this.tPerfilHide_Tick);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.pPerfilUsuario);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAgenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda-Os";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgendaOs_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgendaOs_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgendaOs_KeyPress);
            this.pnlMenu.ResumeLayout(false);
            this.pPerfilUsuario.ResumeLayout(false);
            this.pPerfilUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label labUsuarioMone;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pPerfilUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Timer tPerfilHide;
    }
}

