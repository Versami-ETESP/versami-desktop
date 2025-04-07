namespace versami_desktop.Views
{
    partial class FrmLivros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.txtDescLivros = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(77)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.gridLivros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 262);
            this.panel1.TabIndex = 0;
            // 
            // gridLivros
            // 
            this.gridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLivros.Location = new System.Drawing.Point(19, 39);
            this.gridLivros.Name = "gridLivros";
            this.gridLivros.Size = new System.Drawing.Size(882, 197);
            this.gridLivros.TabIndex = 1;
            this.gridLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLivros_CellClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(409, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(77)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnAdicionar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnBuscarLivro);
            this.panel2.Controls.Add(this.btnBuscarGenero);
            this.panel2.Controls.Add(this.btnBuscarAutor);
            this.panel2.Controls.Add(this.txtDescLivros);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtGenero);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAutor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNomeLivro);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIdLivro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(116, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 336);
            this.panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Turquoise;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(566, 188);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 38);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Turquoise;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(566, 138);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 38);
            this.btnAdicionar.TabIndex = 18;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Turquoise;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(566, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 38);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Turquoise;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(566, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 38);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.BackColor = System.Drawing.Color.Turquoise;
            this.btnBuscarLivro.FlatAppearance.BorderSize = 0;
            this.btnBuscarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLivro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLivro.Location = new System.Drawing.Point(300, 76);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLivro.TabIndex = 15;
            this.btnBuscarLivro.Text = "Buscar";
            this.btnBuscarLivro.UseVisualStyleBackColor = false;
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.BackColor = System.Drawing.Color.Turquoise;
            this.btnBuscarGenero.FlatAppearance.BorderSize = 0;
            this.btnBuscarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarGenero.ForeColor = System.Drawing.Color.White;
            this.btnBuscarGenero.Location = new System.Drawing.Point(300, 177);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGenero.TabIndex = 14;
            this.btnBuscarGenero.Text = "Buscar";
            this.btnBuscarGenero.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.Turquoise;
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAutor.Location = new System.Drawing.Point(300, 124);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAutor.TabIndex = 13;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // txtDescLivros
            // 
            this.txtDescLivros.Enabled = false;
            this.txtDescLivros.Location = new System.Drawing.Point(28, 238);
            this.txtDescLivros.Name = "txtDescLivros";
            this.txtDescLivros.Size = new System.Drawing.Size(347, 76);
            this.txtDescLivros.TabIndex = 12;
            this.txtDescLivros.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(405, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Capa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(399, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 187);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(28, 177);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(246, 20);
            this.txtGenero.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gênero";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(28, 128);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(246, 20);
            this.txtAutor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição do Livro";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Enabled = false;
            this.txtNomeLivro.Location = new System.Drawing.Point(28, 76);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(246, 20);
            this.txtNomeLivro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Livro";
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Enabled = false;
            this.txtIdLivro.Location = new System.Drawing.Point(28, 28);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(246, 20);
            this.txtIdLivro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(948, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLivros";
            this.Text = "FrmLivros";
            this.Load += new System.EventHandler(this.FrmLivros_Load);
            this.Enter += new System.EventHandler(this.FrmLivros_Enter);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescLivros;
        private System.Windows.Forms.Button btnBuscarGenero;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarLivro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
    }
}