namespace Agenda_OS
{
    partial class FormConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracao));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pForm = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConfiguação = new System.Windows.Forms.TabPage();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtBancoDados = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labServidor = new System.Windows.Forms.Label();
            this.labPorta = new System.Windows.Forms.Label();
            this.labBancdoDados = new System.Windows.Forms.Label();
            this.labUsuario = new System.Windows.Forms.Label();
            this.labSenha = new System.Windows.Forms.Label();
            this.pForm.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpConfiguação.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleDescription = "";
            this.btnSalvar.AccessibleName = "";
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(206, 293);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 30);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Tag = "";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(300, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 32);
            this.btnFechar.TabIndex = 37;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labTitulo.Location = new System.Drawing.Point(5, 5);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(140, 25);
            this.labTitulo.TabIndex = 39;
            this.labTitulo.Text = "Configuração";
            // 
            // pForm
            // 
            this.pForm.BackColor = System.Drawing.SystemColors.Control;
            this.pForm.Controls.Add(this.tabControl1);
            this.pForm.Location = new System.Drawing.Point(1, 32);
            this.pForm.Margin = new System.Windows.Forms.Padding(0);
            this.pForm.Name = "pForm";
            this.pForm.Padding = new System.Windows.Forms.Padding(10);
            this.pForm.Size = new System.Drawing.Size(348, 417);
            this.pForm.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConfiguação);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 391);
            this.tabControl1.TabIndex = 39;
            // 
            // tpConfiguação
            // 
            this.tpConfiguação.Controls.Add(this.btnSalvar);
            this.tpConfiguação.Controls.Add(this.labSenha);
            this.tpConfiguação.Controls.Add(this.labUsuario);
            this.tpConfiguação.Controls.Add(this.labBancdoDados);
            this.tpConfiguação.Controls.Add(this.labPorta);
            this.tpConfiguação.Controls.Add(this.labServidor);
            this.tpConfiguação.Controls.Add(this.txtSenha);
            this.tpConfiguação.Controls.Add(this.txtUsuario);
            this.tpConfiguação.Controls.Add(this.txtBancoDados);
            this.tpConfiguação.Controls.Add(this.txtPorta);
            this.tpConfiguação.Controls.Add(this.txtServer);
            this.tpConfiguação.Location = new System.Drawing.Point(4, 25);
            this.tpConfiguação.Name = "tpConfiguação";
            this.tpConfiguação.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguação.Size = new System.Drawing.Size(314, 362);
            this.tpConfiguação.TabIndex = 0;
            this.tpConfiguação.Text = "Configuração";
            this.tpConfiguação.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(8, 37);
            this.txtServer.Margin = new System.Windows.Forms.Padding(5);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(298, 22);
            this.txtServer.TabIndex = 57;
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(8, 85);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(5);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(298, 22);
            this.txtPorta.TabIndex = 58;
            // 
            // txtBancoDados
            // 
            this.txtBancoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancoDados.Location = new System.Drawing.Point(8, 133);
            this.txtBancoDados.Margin = new System.Windows.Forms.Padding(5);
            this.txtBancoDados.Name = "txtBancoDados";
            this.txtBancoDados.Size = new System.Drawing.Size(298, 22);
            this.txtBancoDados.TabIndex = 59;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(8, 181);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(298, 22);
            this.txtUsuario.TabIndex = 60;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(8, 229);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(298, 22);
            this.txtSenha.TabIndex = 61;
            // 
            // labServidor
            // 
            this.labServidor.AutoSize = true;
            this.labServidor.Location = new System.Drawing.Point(8, 16);
            this.labServidor.Name = "labServidor";
            this.labServidor.Size = new System.Drawing.Size(59, 16);
            this.labServidor.TabIndex = 62;
            this.labServidor.Text = "Servidor";
            // 
            // labPorta
            // 
            this.labPorta.AutoSize = true;
            this.labPorta.Location = new System.Drawing.Point(8, 64);
            this.labPorta.Name = "labPorta";
            this.labPorta.Size = new System.Drawing.Size(40, 16);
            this.labPorta.TabIndex = 63;
            this.labPorta.Text = "Porta";
            // 
            // labBancdoDados
            // 
            this.labBancdoDados.AutoSize = true;
            this.labBancdoDados.Location = new System.Drawing.Point(8, 112);
            this.labBancdoDados.Name = "labBancdoDados";
            this.labBancdoDados.Size = new System.Drawing.Size(108, 16);
            this.labBancdoDados.TabIndex = 64;
            this.labBancdoDados.Text = "Banco de dados";
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(8, 160);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(55, 16);
            this.labUsuario.TabIndex = 65;
            this.labUsuario.Text = "Usuário";
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Location = new System.Drawing.Point(8, 208);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(47, 16);
            this.labSenha.TabIndex = 66;
            this.labSenha.Text = "Senha";
            // 
            // FormConfiguracao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.pForm);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguracao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pForm.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpConfiguação.ResumeLayout(false);
            this.tpConfiguação.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel pForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConfiguação;
        private System.Windows.Forms.Label labPorta;
        private System.Windows.Forms.Label labServidor;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtBancoDados;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label labBancdoDados;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.Label labUsuario;
    }
}