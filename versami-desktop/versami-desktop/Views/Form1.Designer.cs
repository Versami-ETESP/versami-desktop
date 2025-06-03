namespace versami_desktop
{
    partial class FrmPrincipal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.lblNomeAdmin = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBlog = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelInfos.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.btnBlog);
            this.panelPrincipal.Controls.Add(this.btnPosts);
            this.panelPrincipal.Controls.Add(this.btnLivros);
            this.panelPrincipal.Controls.Add(this.btnUsuarios);
            this.panelPrincipal.Controls.Add(this.btnInicio);
            this.panelPrincipal.Controls.Add(this.panelInfos);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(250, 799);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelInfos
            // 
            this.panelInfos.BackColor = System.Drawing.Color.Transparent;
            this.panelInfos.Controls.Add(this.lblPermissao);
            this.panelInfos.Controls.Add(this.lblNomeAdmin);
            this.panelInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfos.Location = new System.Drawing.Point(0, 0);
            this.panelInfos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(248, 105);
            this.panelInfos.TabIndex = 0;
            // 
            // lblPermissao
            // 
            this.lblPermissao.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPermissao.Location = new System.Drawing.Point(4, 59);
            this.lblPermissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(242, 29);
            this.lblPermissao.TabIndex = 1;
            this.lblPermissao.Text = "Admin";
            this.lblPermissao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeAdmin
            // 
            this.lblNomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAdmin.ForeColor = System.Drawing.Color.White;
            this.lblNomeAdmin.Location = new System.Drawing.Point(4, 11);
            this.lblNomeAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAdmin.Name = "lblNomeAdmin";
            this.lblNomeAdmin.Size = new System.Drawing.Size(242, 31);
            this.lblNomeAdmin.TabIndex = 0;
            this.lblNomeAdmin.Text = "Nome Usuário";
            this.lblNomeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(250, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1185, 799);
            this.panelForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::versami_desktop.Properties.Resources.logout_48dp_FFFFFF_FILL0_wght400_GRAD0_opsz48;
            this.btnSair.Location = new System.Drawing.Point(78, 715);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 68);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBlog
            // 
            this.btnBlog.FlatAppearance.BorderSize = 0;
            this.btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlog.ForeColor = System.Drawing.Color.White;
            this.btnBlog.Image = global::versami_desktop.Properties.Resources.bookmark_48dp;
            this.btnBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlog.Location = new System.Drawing.Point(0, 289);
            this.btnBlog.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlog.Name = "btnBlog";
            this.btnBlog.Size = new System.Drawing.Size(244, 82);
            this.btnBlog.TabIndex = 5;
            this.btnBlog.Text = "Blog";
            this.btnBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlog.UseVisualStyleBackColor = true;
            this.btnBlog.Click += new System.EventHandler(this.btnBlog_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.FlatAppearance.BorderSize = 0;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosts.ForeColor = System.Drawing.Color.White;
            this.btnPosts.Image = global::versami_desktop.Properties.Resources.flag_48dp;
            this.btnPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosts.Location = new System.Drawing.Point(2, 379);
            this.btnPosts.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(244, 82);
            this.btnPosts.TabIndex = 4;
            this.btnPosts.Text = "Denúncias";
            this.btnPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.FlatAppearance.BorderSize = 0;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Image = global::versami_desktop.Properties.Resources.menu_book;
            this.btnLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLivros.Location = new System.Drawing.Point(1, 199);
            this.btnLivros.Margin = new System.Windows.Forms.Padding(4);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(244, 82);
            this.btnLivros.TabIndex = 3;
            this.btnLivros.Text = "Livros";
            this.btnLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::versami_desktop.Properties.Resources.person_add_48dp;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(4, 469);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(244, 82);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Novo Usuário";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::versami_desktop.Properties.Resources.home_48dp;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(1, 109);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(244, 82);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1435, 799);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.Text = "Versami Administrador";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelInfos.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.Label lblNomeAdmin;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label1;
    }
}

