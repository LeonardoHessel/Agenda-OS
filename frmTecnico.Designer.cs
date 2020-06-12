namespace Agenda_OS
{
    partial class frmTecnico
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.Nasc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCNH = new System.Windows.Forms.MaskedTextBox();
            this.cnh = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.tcod = new System.Windows.Forms.Label();
            this.labCOD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(8, 58);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(53, 81);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(117, 20);
            this.dtpNasc.TabIndex = 2;
            this.dtpNasc.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Nasc
            // 
            this.Nasc.AutoSize = true;
            this.Nasc.Location = new System.Drawing.Point(17, 89);
            this.Nasc.Name = "Nasc";
            this.Nasc.Size = new System.Drawing.Size(35, 13);
            this.Nasc.TabIndex = 3;
            this.Nasc.Text = "Nasc.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 179);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Selecione:",
            "Feminino",
            "Masculino",
            "Outros"});
            this.cmbSexo.Location = new System.Drawing.Point(216, 81);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(122, 21);
            this.cmbSexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(501, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(420, 290);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(339, 290);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(53, 107);
            this.mtbRG.Mask = "99.999.999-9";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(117, 20);
            this.mtbRG.TabIndex = 12;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(216, 107);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(122, 20);
            this.mtbCPF.TabIndex = 13;
            // 
            // mtbCNH
            // 
            this.mtbCNH.Location = new System.Drawing.Point(53, 133);
            this.mtbCNH.Mask = "999 999 999 99";
            this.mtbCNH.Name = "mtbCNH";
            this.mtbCNH.Size = new System.Drawing.Size(117, 20);
            this.mtbCNH.TabIndex = 14;
            // 
            // cnh
            // 
            this.cnh.AutoSize = true;
            this.cnh.Location = new System.Drawing.Point(17, 141);
            this.cnh.Name = "cnh";
            this.cnh.Size = new System.Drawing.Size(33, 13);
            this.cnh.TabIndex = 15;
            this.cnh.Text = "CNH:";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(181, 115);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(30, 13);
            this.cpf.TabIndex = 16;
            this.cpf.Text = "CPF:";
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Location = new System.Drawing.Point(17, 115);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(26, 13);
            this.rg.TabIndex = 17;
            this.rg.Text = "RG:";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(8, 5);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(64, 20);
            this.titulo.TabIndex = 18;
            this.titulo.Text = "Técnico";
            // 
            // tcod
            // 
            this.tcod.AutoSize = true;
            this.tcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcod.Location = new System.Drawing.Point(343, 16);
            this.tcod.Name = "tcod";
            this.tcod.Size = new System.Drawing.Size(25, 20);
            this.tcod.TabIndex = 19;
            this.tcod.Text = "id:";
            // 
            // labCOD
            // 
            this.labCOD.AutoSize = true;
            this.labCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCOD.Location = new System.Drawing.Point(390, 5);
            this.labCOD.Name = "labCOD";
            this.labCOD.Size = new System.Drawing.Size(32, 33);
            this.labCOD.TabIndex = 20;
            this.labCOD.Text = "0";
            this.labCOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.labCOD);
            this.Controls.Add(this.tcod);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.cnh);
            this.Controls.Add(this.mtbCNH);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Nasc);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "frmTecnico";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Técnico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label Nasc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCNH;
        private System.Windows.Forms.Label cnh;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label tcod;
        private System.Windows.Forms.Label labCOD;
    }
}