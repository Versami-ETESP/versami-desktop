namespace versami_desktop.Views
{
    partial class FrmVisualizarPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarPost));
            this.imgCapaLivro = new System.Windows.Forms.PictureBox();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.panelLivro = new System.Windows.Forms.Panel();
            this.lblArrobaUser = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.txtConteuPublic = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapaLivro)).BeginInit();
            this.panelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCapaLivro
            // 
            this.imgCapaLivro.Location = new System.Drawing.Point(47, 9);
            this.imgCapaLivro.Name = "imgCapaLivro";
            this.imgCapaLivro.Size = new System.Drawing.Size(81, 120);
            this.imgCapaLivro.TabIndex = 0;
            this.imgCapaLivro.TabStop = false;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivro.ForeColor = System.Drawing.Color.White;
            this.lblTituloLivro.Location = new System.Drawing.Point(234, 57);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(184, 24);
            this.lblTituloLivro.TabIndex = 1;
            this.lblTituloLivro.Text = "TITULO DO LIVRO";
            this.lblTituloLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLivro
            // 
            this.panelLivro.AutoSize = true;
            this.panelLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(77)))), ((int)(((byte)(108)))));
            this.panelLivro.Controls.Add(this.lblTituloLivro);
            this.panelLivro.Controls.Add(this.imgCapaLivro);
            this.panelLivro.Location = new System.Drawing.Point(55, 192);
            this.panelLivro.Name = "panelLivro";
            this.panelLivro.Size = new System.Drawing.Size(614, 138);
            this.panelLivro.TabIndex = 4;
            this.panelLivro.Visible = false;
            // 
            // lblArrobaUser
            // 
            this.lblArrobaUser.AutoSize = true;
            this.lblArrobaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrobaUser.ForeColor = System.Drawing.Color.White;
            this.lblArrobaUser.Location = new System.Drawing.Point(74, 27);
            this.lblArrobaUser.Name = "lblArrobaUser";
            this.lblArrobaUser.Size = new System.Drawing.Size(94, 16);
            this.lblArrobaUser.TabIndex = 1;
            this.lblArrobaUser.Text = "arroba usuario";
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.Color.White;
            this.lblNomeUser.Location = new System.Drawing.Point(73, 3);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(143, 24);
            this.lblNomeUser.TabIndex = 0;
            this.lblNomeUser.Text = "Nome Usuario";
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = global::versami_desktop.Properties.Resources.placeholder_user;
            this.imgPerfil.InitialImage = null;
            this.imgPerfil.Location = new System.Drawing.Point(3, 3);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(53, 52);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 3;
            this.imgPerfil.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgPerfil);
            this.panel1.Controls.Add(this.lblNomeUser);
            this.panel1.Controls.Add(this.lblArrobaUser);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 63);
            this.panel1.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.LightGray;
            this.lblData.Location = new System.Drawing.Point(591, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(136, 18);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "20/10/2000 13:48";
            // 
            // txtConteuPublic
            // 
            this.txtConteuPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(65)))));
            this.txtConteuPublic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConteuPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteuPublic.ForeColor = System.Drawing.Color.White;
            this.txtConteuPublic.Location = new System.Drawing.Point(37, 81);
            this.txtConteuPublic.Name = "txtConteuPublic";
            this.txtConteuPublic.ReadOnly = true;
            this.txtConteuPublic.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConteuPublic.Size = new System.Drawing.Size(673, 105);
            this.txtConteuPublic.TabIndex = 7;
            this.txtConteuPublic.TabStop = false;
            this.txtConteuPublic.Text = resources.GetString("txtConteuPublic.Text");
            // 
            // FrmVisualizarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(752, 352);
            this.Controls.Add(this.txtConteuPublic);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmVisualizarPost";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVisualizarPost_FormClosed);
            this.Load += new System.EventHandler(this.FrmVisualizarPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCapaLivro)).EndInit();
            this.panelLivro.ResumeLayout(false);
            this.panelLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgCapaLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Panel panelLivro;
        private System.Windows.Forms.Label lblArrobaUser;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.RichTextBox txtConteuPublic;
    }
}