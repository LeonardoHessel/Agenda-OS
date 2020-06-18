namespace Agenda_OS
{
    partial class FormLogin
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
            this.pTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.pFooter = new System.Windows.Forms.Panel();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.labLogin = new System.Windows.Forms.Label();
            this.labSenha = new System.Windows.Forms.Label();
            this.labSenhaInvalida = new System.Windows.Forms.Label();
            this.pTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pTitulo.Controls.Add(this.btnFechar);
            this.pTitulo.Controls.Add(this.labTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(379, 60);
            this.pTitulo.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(297, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 60);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.ForeColor = System.Drawing.Color.White;
            this.labTitulo.Location = new System.Drawing.Point(12, 9);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(79, 32);
            this.labTitulo.TabIndex = 1;
            this.labTitulo.Text = "Login";
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 484);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(379, 10);
            this.pFooter.TabIndex = 1;
            // 
            // cbLogin
            // 
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(57, 270);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(265, 29);
            this.cbLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 331);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(265, 29);
            this.txtSenha.TabIndex = 1;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.White;
            this.btnAcessar.Location = new System.Drawing.Point(134, 386);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(111, 37);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Location = new System.Drawing.Point(53, 246);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(52, 21);
            this.labLogin.TabIndex = 4;
            this.labLogin.Text = "Login:";
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Location = new System.Drawing.Point(53, 307);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(56, 21);
            this.labSenha.TabIndex = 5;
            this.labSenha.Text = "Senha:";
            // 
            // labSenhaInvalida
            // 
            this.labSenhaInvalida.AutoSize = true;
            this.labSenhaInvalida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSenhaInvalida.ForeColor = System.Drawing.Color.DarkRed;
            this.labSenhaInvalida.Location = new System.Drawing.Point(211, 307);
            this.labSenhaInvalida.Name = "labSenhaInvalida";
            this.labSenhaInvalida.Size = new System.Drawing.Size(113, 21);
            this.labSenhaInvalida.TabIndex = 6;
            this.labSenhaInvalida.Text = "Senha inválida";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(379, 494);
            this.Controls.Add(this.labSenhaInvalida);
            this.Controls.Add(this.labSenha);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labSenhaInvalida;
    }
}