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
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Views
{
    public partial class FrmLivros: Form
    {
        Autor autor = new Autor();
        Genero genero = new Genero();

        DataTable dt;
        LivroController lc = new LivroController();
        OpenFileDialog ofd1 = new OpenFileDialog();
        byte[] capaLivro;
        bool isActive = false;
        public FrmLivros()
        {
            InitializeComponent();

        }

        private void formatarGrid()
        {
            gridLivros.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            gridLivros.AllowUserToAddRows = false; //ESCONDE A NOVA LINHA DO GRID
            gridLivros.AllowUserToDeleteRows = false;
            gridLivros.RowHeadersVisible = false; //ESCONDE O PONTEIRO DO GRID
            gridLivros.ReadOnly = true;
            //permite personalizar o grid
            gridLivros.AutoGenerateColumns = false;
            gridLivros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            gridLivros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            gridLivros.RowsDefaultCellStyle.BackColor = Color.FromArgb(26, 42, 65);
            gridLivros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridLivros.ForeColor = Color.White;
            //altera o cabecalho
            gridLivros.EnableHeadersVisualStyles = false;
            gridLivros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            gridLivros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //altera o nome das colunas
            gridLivros.Columns[0].HeaderText = "ID";
            gridLivros.Columns[1].HeaderText = "NOME DO LIVRO";
            gridLivros.Columns[2].HeaderText = "DESCRIÇÃO";
            //altera o tamanho das colunas
            gridLivros.Columns[0].Width = 28;
            gridLivros.Columns[1].Width = 250;
            gridLivros.Columns[2].Width = 600;
            //não permite seleção de multiplas linhas    
            gridLivros.MultiSelect = false;
            //ao clicar, seleciona a linha inteira
            gridLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Expande a célula automáticamente
            gridLivros.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void limparCampos()
        {
            txtAutor.Text = "";
            txtDescLivros.Text = "";
            txtGenero.Text = "";
            txtIdLivro.Text = "";
            txtNomeLivro.Text = "";
            pbCapa.Image = null;
        }

        private void estadoCampos(bool estado)
        {
            txtNomeLivro.Enabled = estado;
            txtDescLivros.Enabled = estado;
            btnBuscarAutor.Enabled = estado;
            btnBuscarGenero.Enabled = estado;
            btnAlterarImg.Enabled = estado;
            btnAdicionar.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnBuscarLivro.Enabled = estado;
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            gridLivros.DataSource = lc.carregarGrid();
            formatarGrid();
        }

        private void gridLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string id = gridLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
                dt = lc.obtemLivroGrid(id);

                txtIdLivro.Text = dt.Rows[0]["idLivro"].ToString();
                txtNomeLivro.Text = dt.Rows[0]["nomeLivro"].ToString();
                txtDescLivros.Text = dt.Rows[0]["descLivro"].ToString();
                txtAutor.Text = dt.Rows[0]["nomeAutor"].ToString();
                txtGenero.Text = dt.Rows[0]["nomeGenero"].ToString();

                try
                {
                    byte[] imgArray= (byte[]) dt.Rows[0]["imgCapa"];
                    Image imgCapa = UtilitarioImagens.ConverteByteParaImagem(imgArray);
                    pbCapa.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbCapa.Image = imgCapa;
                }catch(Exception ex)
                {
                    Console.WriteLine("Erro ao converter Imagem: " + ex.Message);
                }
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            FrmBuscaAutor ba = new FrmBuscaAutor();

            if(ba.ShowDialog() == DialogResult.OK && autor.getAutorID() > 0)
            {
                txtAutor.Text = autor.getName();
            }
            
        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            FrmBuscaGenero bg = new FrmBuscaGenero();
            if(bg.ShowDialog() == DialogResult.OK && genero.getGeneroID() > 0)
            {
                txtGenero.Text = genero.getType();
            }
            
        }

        private void btnAlterarImg_Click(object sender, EventArgs e)
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

            if(dr == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd1.FileName);
                pbCapa.SizeMode = PictureBoxSizeMode.StretchImage;
                pbCapa.Image = img;
                capaLivro = UtilitarioImagens.ConverteImagemParaByteArray(img);
            }
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var situacaoCampos = string.IsNullOrEmpty(txtNomeLivro.Text)
                || string.IsNullOrEmpty(txtDescLivros.Text)
                || string.IsNullOrEmpty(txtGenero.Text)
                || string.IsNullOrEmpty(txtAutor.Text)
                || capaLivro == null;

            if (string.IsNullOrEmpty(txtIdLivro.Text))
            {
                if (!situacaoCampos)
                {
                    var livro = new Livro(txtNomeLivro.Text.ToUpper(), txtDescLivros.Text, capaLivro, txtGenero.Text, txtAutor.Text);

                    if (lc.insertLivro(livro))
                    {
                        MessageBox.Show("Livro Cadastrado!");
                        capaLivro = null;
                        gridLivros.DataSource = lc.carregarGrid();
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Livro Não Cadastrado. Tente mais tarde!");
                        limparCampos();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Preencha todos campos antes de adicionar um livro!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Este livro já está cadastrado! Por favor, pressione limpar campos antes de adicionar novo livro!", "Livro Existente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var idLivro = txtIdLivro.Text;

            if (!string.IsNullOrEmpty(idLivro))
            {
                if(MessageBox.Show("Deseja Excluir Esse Livro?", "Excluir Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lc.deleteLivro(idLivro);
                    limparCampos();
                    gridLivros.DataSource = lc.carregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro para excluí-lo!", "Seleção Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idLivro = txtIdLivro.Text;

            if (!string.IsNullOrEmpty(idLivro))
            {
                if((MessageBox.Show("Deseja Alterar Esse Livro?", "Alterar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)){
                    int opc = capaLivro != null ? 2 : 1;
                    Livro livro = new Livro(txtNomeLivro.Text.ToUpper(), txtDescLivros.Text, capaLivro, txtGenero.Text, txtAutor.Text);
                    livro.setBookID(Convert.ToInt32(txtIdLivro.Text));
                    lc.updateLivro(livro, opc);
                    limparCampos();
                    gridLivros.DataSource = lc.carregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro para alterá-lo!", "Seleção Vazia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarLivro_Click(object sender, EventArgs e)
        {
            FrmBuscaLivro bl = new FrmBuscaLivro();
            Livro lv = new Livro();
            if (bl.ShowDialog() == DialogResult.OK && lv.getBookID() > 0)
            {
                dt = lc.obtemLivroGrid(lv.getBookID().ToString());

                txtIdLivro.Text = dt.Rows[0]["idLivro"].ToString();
                txtNomeLivro.Text = dt.Rows[0]["nomeLivro"].ToString();
                txtDescLivros.Text = dt.Rows[0]["descLivro"].ToString();
                txtAutor.Text = dt.Rows[0]["nomeAutor"].ToString();
                txtGenero.Text = dt.Rows[0]["nomeGenero"].ToString();

                try
                {
                    byte[] imgArray = (byte[])dt.Rows[0]["imgCapa"];
                    Image imgCapa = UtilitarioImagens.ConverteByteParaImagem(imgArray);
                    pbCapa.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbCapa.Image = imgCapa;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao converter Imagem: " + ex.Message);
                }

            }
        }
    }
}
