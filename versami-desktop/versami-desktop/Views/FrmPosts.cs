using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Controllers;

namespace versami_desktop.Views
{
    public partial class FrmPosts : Form
    {
        public FrmPosts()
        {
            InitializeComponent();
        }

        private void FrmPosts_Load(object sender, EventArgs e)
        {
            CarregarPosts();
        }

        private void CarregarPosts()
        {
            PostController controller = new PostController();
            DataTable dt = controller.listarPosts();

         //   panel.Controls.Clear(); // Limpa antes de adicionar novos posts

            int y = 50;

            foreach (DataRow row in dt.Rows)
            {
                Panel postPanel = new Panel
                {
                    Width = panel.Width - 100, // margem de 50px de cada lado
                    Height = 180,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(26, 42, 65),
                    Location = new Point(50, y) // << usa a variável y para empilhar os posts
                };


                // Foto de perfil
                PictureBox pic = new PictureBox
                {
                    Size = new Size(60, 60),
                    Location = new Point(10, 10),
                    BackColor = Color.Gray,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                // Você pode carregar a imagem real aqui se tiver a coluna fotoUsuario

                // Nome do usuário
                Label lblUsuario = new Label
                {
                    Text = row["nome"].ToString(),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(80, 10),
                    AutoSize = true
                };

                // Conteúdo da publicação
                Label lblConteudo = new Label
                {
                    Text = row["conteudo"].ToString(),
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.White,
                    Location = new Point(80, 40),
                    MaximumSize = new Size(postPanel.Width - 100, 0),
                    AutoSize = true
                };

                // Data da publicação
                Label lblData = new Label
                {
                    Text = Convert.ToDateTime(row["dataPublic"]).ToString("dd/MM/yyyy HH:mm"),
                    Font = new Font("Segoe UI", 8, FontStyle.Italic),
                    ForeColor = Color.LightGray,
                    Location = new Point(80, lblConteudo.Bottom + 5),
                    AutoSize = true
                };

                // Curtidas
                Label lblCurtidas = new Label
                {
                    Text = "❤ " + row["qtdCurtidas"].ToString(),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(80, lblData.Bottom + 10),
                    AutoSize = true
                };

                // Comentários
                Label lblComentarios = new Label
                {
                    Text = "💬 " + row["qtdComentarios"].ToString(),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(lblCurtidas.Right + 20, lblData.Bottom + 10),
                    AutoSize = true
                };

                // Adiciona controles ao postPanel
                postPanel.Controls.Add(pic);
                postPanel.Controls.Add(lblUsuario);
                postPanel.Controls.Add(lblConteudo);
                postPanel.Controls.Add(lblData);
                postPanel.Controls.Add(lblCurtidas);
                postPanel.Controls.Add(lblComentarios);

                panel.Controls.Add(postPanel);

                y += postPanel.Height + 15; // soma a altura para o próximo post

                // Botão Excluir
                Button btnExcluir = new Button
                {
                    Text = "Excluir",
                    BackColor = Color.Firebrick,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(postPanel.Width - 100, postPanel.Height - 40), // canto inferior direito
                    Tag = row["idPublicacao"] // importante para identificar qual post excluir
                };
                btnExcluir.Click += BtnExcluir_Click;

                postPanel.Controls.Add(btnExcluir);



            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idPublicacao = Convert.ToInt32(btn.Tag);

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este post?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                PostController controller = new PostController();
                controller.excluirPost(idPublicacao);
                CarregarPosts(); // atualiza a lista de posts
            }
        }
    }

}
