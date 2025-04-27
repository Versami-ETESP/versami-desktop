namespace versami_desktop.Views
{
    partial class FrmAlteraSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtArroba = new System.Windows.Forms.TextBox();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arroba:";
            // 
            // txtArroba
            // 
            this.txtArroba.Location = new System.Drawing.Point(153, 28);
            this.txtArroba.Name = "txtArroba";
            this.txtArroba.Size = new System.Drawing.Size(267, 20);
            this.txtArroba.TabIndex = 1;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Enabled = false;
            this.txtPergunta.Location = new System.Drawing.Point(153, 69);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(267, 20);
            this.txtPergunta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pergunta Secreta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Location = new System.Drawing.Point(153, 107);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(267, 20);
            this.txtResposta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resposta:";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(153, 147);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(267, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nova senha:";
            // 
            // txtConfirma
            // 
            this.txtConfirma.Enabled = false;
            this.txtConfirma.Location = new System.Drawing.Point(153, 186);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(267, 20);
            this.txtConfirma.TabIndex = 9;
            this.txtConfirma.UseSystemPasswordChar = true;
            this.txtConfirma.Leave += new System.EventHandler(this.txtConfirma_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar Senha:";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.Turquoise;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Location = new System.Drawing.Point(440, 22);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(136, 29);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "Buscar Usuário";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.BackColor = System.Drawing.Color.Turquoise;
            this.btnAltera.Enabled = false;
            this.btnAltera.FlatAppearance.BorderSize = 0;
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltera.ForeColor = System.Drawing.Color.White;
            this.btnAltera.Location = new System.Drawing.Point(229, 228);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(164, 35);
            this.btnAltera.TabIndex = 11;
            this.btnAltera.Text = "Redefinir Senha";
            this.btnAltera.UseVisualStyleBackColor = false;
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMensagem.Location = new System.Drawing.Point(43, 281);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(522, 34);
            this.lblMensagem.TabIndex = 12;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAlteraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(597, 324);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArroba);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlteraSenha";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci Minha Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArroba;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Label lblMensagem;
    }
}