using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Controllers;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Views
{
    public partial class FrmBlog: Form
    {
        DataTable dt;
        BlogController controller = new BlogController();
        OpenFileDialog ofd1 = new OpenFileDialog();
        byte[] imgPost;
        bool isActive = false;

        public FrmBlog()
        {
            InitializeComponent();
        }

        //Botao de adicionar imagem do post

        private void FrmBlog_Load(object sender, EventArgs e)
        {
            gridBlogPost.DataSource = controller.carregarGrid();
            formatarGrid();


        }

        private void formatarGrid()
        {
            gridBlogPost.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            gridBlogPost.AllowUserToAddRows = false; //ESCONDE A NOVA LINHA DO GRID
            gridBlogPost.AllowUserToDeleteRows = false;
            gridBlogPost.RowHeadersVisible = false; //ESCONDE O PONTEIRO DO GRID
            gridBlogPost.ReadOnly = true;
            //permite personalizar o grid
            gridBlogPost.AutoGenerateColumns = false;
            gridBlogPost.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            //  Esta é a linha nova que ajusta as colunas ao tamanho do grid
            gridBlogPost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridBlogPost.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            gridBlogPost.RowsDefaultCellStyle.BackColor = Color.FromArgb(26, 42, 65);
            gridBlogPost.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridBlogPost.ForeColor = Color.White;
            //altera o cabecalho
            gridBlogPost.EnableHeadersVisualStyles = false;
            gridBlogPost.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridBlogPost.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //altera o nome das colunas
            gridBlogPost.Columns[0].HeaderText = "ID";
            gridBlogPost.Columns[1].HeaderText = "TÍTULO";
            gridBlogPost.Columns[2].HeaderText = "DESCRIÇÃO";
            //altera o tamanho das colunas
            gridBlogPost.Columns[0].Width = 28;
            gridBlogPost.Columns[1].Width = 250;
            gridBlogPost.Columns[2].Width = 600;
            //não permite seleção de multiplas linhas    
            gridBlogPost.MultiSelect = false;
            //ao clicar, seleciona a linha inteira
            gridBlogPost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Expande a célula automáticamente
            gridBlogPost.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void estadoCampos(bool estado)
        {
            txtTituloPost.Enabled = estado;
            txtDescricaoPost.Enabled = estado;
            btnImgPost.Enabled = estado;
            btnAdicionar.Enabled = estado;
            btnEditar.Enabled = estado;
            //btnBuscarLivro.Enabled = estado;
        }

        private void limparCampos()
        {
            txtTituloPost.Text = "";
            txtDescricaoPost.Text = "";
            txtIdPost.Text = "";
            PictureBoxPost.Image = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!isActive)
            {
                isActive = true;
                estadoCampos(isActive);
            }
            else
            {
                isActive = false;
                estadoCampos(isActive);
            }
        }

        private void btnImgPost_Click(object sender, EventArgs e)
        {
            ofd1.Title = "Selecionar Imagem";
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|\" + \"All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = ofd1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd1.FileName);
                PictureBoxPost.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxPost.Image = img;
                imgPost = UtilitarioImagens.ConverteImagemParaByteArray(img);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            bool camposInvalidos = string.IsNullOrEmpty(txtTituloPost.Text)
                || string.IsNullOrEmpty(txtDescricaoPost.Text)
                || imgPost == null;

            if (string.IsNullOrEmpty(txtIdPost.Text))
            {
                if (!camposInvalidos)
                {
                    // Criação do objeto BlogPost com os dados obrigatórios
                    BlogPost post = new BlogPost(
                        txtTituloPost.Text.ToUpper(),
                        txtDescricaoPost.Text,
                        imgPost
                    );

                    post.setDataPost(DateTime.Now);
                    post.setIdAdmin(1); // Substitua por ID do admin logado, se tiver

                    if (controller.insertPost(post))
                    {
                        MessageBox.Show("Post cadastrado com sucesso!");
                        imgPost = null;
                        gridBlogPost.DataSource = controller.carregarGrid();
                        limparCampos();
                    }
                    else
                    {
                        Debug.WriteLine("Falha no insertPost(). Verifique os parâmetros e o SQL.");
                        MessageBox.Show("Post não cadastrado. Tente novamente mais tarde!");
                        limparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos antes de adicionar um post!",
                        "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Este post já está cadastrado! Pressione 'Limpar Campos' antes de adicionar um novo post!",
                    "Post Existente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var idPost = txtIdPost.Text;

            if (!string.IsNullOrEmpty(idPost))
            {
                if (MessageBox.Show("Deseja excluir esse post?", "Excluir Post", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BlogController bc = new BlogController();
                    bc.deletePost(idPost);

                    limparCampos(); // Método que limpa os campos do formulário
                    gridBlogPost.DataSource = bc.carregarGrid(); // Recarrega o grid
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um post para excluí-lo!", "Seleção Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /*
            FrmPesquisarBlog busca = new FrmPesquisarBlog();

            if (busca.ShowDialog() == DialogResult.OK)
            {
                BlogController bc = new BlogController();
                BlogPost post = bc.BuscarPorId(busca.IdSelecionado);

                if (post != null)
                {
                    txtIdPost.Text = post.getIdPost().ToString();
                    txtTituloPost.Text = post.getTitulo();
                    txtDescricaoPost.Text = post.getConteudo();
                    imgPost = post.getImagem();
                    PictureBoxPost.Image = UtilitarioImagens.ConverteByteParaImagem(imgPost);
                    PictureBoxPost.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }*/
        }

        private void CarregarPostSelecionado(int id)
        {
            BlogPost post = controller.BuscarPorId(id);

            if (post != null)
            {
                txtIdPost.Text = post.getIdPost().ToString();
                txtTituloPost.Text = post.getTitulo();
                txtDescricaoPost.Text = post.getConteudo();

                if (post.getImagem() != null && post.getImagem().Length > 0)
                {
                    PictureBoxPost.Image = UtilitarioImagens.ConverteByteParaImagem(post.getImagem());
                    PictureBoxPost.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    PictureBoxPost.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Post não encontrado.");
            }
        }

        private int ObterIdSelecionado()
        {
            if (gridBlogPost.CurrentRow != null)
            {
                // Confirme qual coluna tem o ID, se não for 0, mude para o índice correto
                return Convert.ToInt32(gridBlogPost.CurrentRow.Cells[0].Value);
            }
            return -1; // id inválido
        }

        private void gridBlogPost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = ObterIdSelecionado();

            if (id > 0)
            {
                CarregarPostSelecionado(id);
            }
        }
    }
}
