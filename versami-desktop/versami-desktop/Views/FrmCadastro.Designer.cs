namespace versami_desktop.Views
{
    partial class FrmCadastro
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArroba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.rdoMaster = new System.Windows.Forms.RadioButton();
            this.rdoBanir = new System.Windows.Forms.RadioButton();
            this.rdoModerador = new System.Windows.Forms.RadioButton();
            this.rdoEditLivro = new System.Windows.Forms.RadioButton();
            this.rdoPublicar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.Image = global::versami_desktop.Properties.Resources.Grupo_Logo;
            this.lblLogo.Location = new System.Drawing.Point(301, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(224, 112);
            this.lblLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 177);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // txtArroba
            // 
            this.txtArroba.Location = new System.Drawing.Point(438, 245);
            this.txtArroba.Name = "txtArroba";
            this.txtArroba.Size = new System.Drawing.Size(275, 20);
            this.txtArroba.TabIndex = 7;
            this.txtArroba.Leave += new System.EventHandler(this.txtArroba_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(435, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arroba de Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(100, 317);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(289, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // txtConfirma
            // 
            this.txtConfirma.Location = new System.Drawing.Point(438, 317);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(275, 20);
            this.txtConfirma.TabIndex = 11;
            this.txtConfirma.UseSystemPasswordChar = true;
            this.txtConfirma.Leave += new System.EventHandler(this.txtConfirma_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(435, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de Nascimento";
            // 
            // dateBirth
            // 
            this.dateBirth.Location = new System.Drawing.Point(438, 177);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(275, 20);
            this.dateBirth.TabIndex = 13;
            this.dateBirth.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // rdoMaster
            // 
            this.rdoMaster.AutoSize = true;
            this.rdoMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaster.ForeColor = System.Drawing.Color.White;
            this.rdoMaster.Location = new System.Drawing.Point(100, 406);
            this.rdoMaster.Name = "rdoMaster";
            this.rdoMaster.Size = new System.Drawing.Size(72, 22);
            this.rdoMaster.TabIndex = 14;
            this.rdoMaster.TabStop = true;
            this.rdoMaster.Text = "Master";
            this.rdoMaster.UseVisualStyleBackColor = true;
            // 
            // rdoBanir
            // 
            this.rdoBanir.AutoSize = true;
            this.rdoBanir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBanir.ForeColor = System.Drawing.Color.White;
            this.rdoBanir.Location = new System.Drawing.Point(490, 406);
            this.rdoBanir.Name = "rdoBanir";
            this.rdoBanir.Size = new System.Drawing.Size(96, 22);
            this.rdoBanir.TabIndex = 15;
            this.rdoBanir.TabStop = true;
            this.rdoBanir.Text = "Banir User";
            this.rdoBanir.UseVisualStyleBackColor = true;
            // 
            // rdoModerador
            // 
            this.rdoModerador.AutoSize = true;
            this.rdoModerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModerador.ForeColor = System.Drawing.Color.White;
            this.rdoModerador.Location = new System.Drawing.Point(355, 406);
            this.rdoModerador.Name = "rdoModerador";
            this.rdoModerador.Size = new System.Drawing.Size(99, 22);
            this.rdoModerador.TabIndex = 16;
            this.rdoModerador.TabStop = true;
            this.rdoModerador.Text = "Moderador";
            this.rdoModerador.UseVisualStyleBackColor = true;
            // 
            // rdoEditLivro
            // 
            this.rdoEditLivro.AutoSize = true;
            this.rdoEditLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEditLivro.ForeColor = System.Drawing.Color.White;
            this.rdoEditLivro.Location = new System.Drawing.Point(213, 406);
            this.rdoEditLivro.Name = "rdoEditLivro";
            this.rdoEditLivro.Size = new System.Drawing.Size(108, 22);
            this.rdoEditLivro.TabIndex = 17;
            this.rdoEditLivro.TabStop = true;
            this.rdoEditLivro.Text = "Editar Livros";
            this.rdoEditLivro.UseVisualStyleBackColor = true;
            // 
            // rdoPublicar
            // 
            this.rdoPublicar.AutoSize = true;
            this.rdoPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPublicar.ForeColor = System.Drawing.Color.White;
            this.rdoPublicar.Location = new System.Drawing.Point(620, 406);
            this.rdoPublicar.Name = "rdoPublicar";
            this.rdoPublicar.Size = new System.Drawing.Size(113, 22);
            this.rdoPublicar.TabIndex = 18;
            this.rdoPublicar.TabStop = true;
            this.rdoPublicar.Text = "Publicar Blog";
            this.rdoPublicar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(386, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de Permissao";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(438, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Turquoise;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(292, 447);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(110, 38);
            this.btnEntrar.TabIndex = 20;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMensagem.Location = new System.Drawing.Point(288, 512);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 20);
            this.lblMensagem.TabIndex = 22;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(856, 557);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoPublicar);
            this.Controls.Add(this.rdoEditLivro);
            this.Controls.Add(this.rdoModerador);
            this.Controls.Add(this.rdoBanir);
            this.Controls.Add(this.rdoMaster);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArroba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogo);
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArroba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.RadioButton rdoMaster;
        private System.Windows.Forms.RadioButton rdoBanir;
        private System.Windows.Forms.RadioButton rdoModerador;
        private System.Windows.Forms.RadioButton rdoEditLivro;
        private System.Windows.Forms.RadioButton rdoPublicar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblMensagem;
    }
}