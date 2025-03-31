namespace VersamiDesk
{
    partial class Form1
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblArrobaAdmin = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.Controls.Add(this.lblArrobaAdmin);
            this.pnlNav.Controls.Add(this.lblAdmin);
            this.pnlNav.Controls.Add(this.btnPosts);
            this.pnlNav.Controls.Add(this.btnLivros);
            this.pnlNav.Controls.Add(this.btnUsuarios);
            this.pnlNav.Controls.Add(this.btnInicio);
            this.pnlNav.Location = new System.Drawing.Point(12, 12);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(347, 891);
            this.pnlNav.TabIndex = 0;
            // 
            // lblArrobaAdmin
            // 
            this.lblArrobaAdmin.AutoSize = true;
            this.lblArrobaAdmin.Location = new System.Drawing.Point(94, 37);
            this.lblArrobaAdmin.Name = "lblArrobaAdmin";
            this.lblArrobaAdmin.Size = new System.Drawing.Size(51, 20);
            this.lblArrobaAdmin.TabIndex = 5;
            this.lblArrobaAdmin.Text = "label1";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(141, 81);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(54, 20);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin";
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(17, 481);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(307, 59);
            this.btnPosts.TabIndex = 3;
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Location = new System.Drawing.Point(17, 363);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(307, 59);
            this.btnLivros.TabIndex = 2;
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(17, 248);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(307, 59);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(17, 135);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(307, 59);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(397, 12);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1000, 891);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlNav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblArrobaAdmin;
    }
}

