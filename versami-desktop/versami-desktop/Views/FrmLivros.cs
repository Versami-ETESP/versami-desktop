using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Views
{
    public partial class FrmLivros: Form
    {
        Conexao con;
        DataTable dt;
        Autor autor = new Autor();
        Genero genero = new Genero();
        public FrmLivros()
        {
            InitializeComponent();

        }
        private void FrmLivros_Load(object sender, EventArgs e)
        {
            carregarGrid();
            formatarGrid();
        }

        private void carregarGrid()
        {
            String sql = "SELECT idLivro, nomeLivro, descLivro FROM tblLivro";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Consulta SQL: " + e.Message);
            }

            gridLivros.DataSource = dt;
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
            gridLivros.RowsDefaultCellStyle.BackColor = Color.FromArgb(26,42,65);
            gridLivros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56,77,108);
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
        }

        private void gridLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string id = gridLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtIdLivro.Text = id;

                try
                {
                    con = new Conexao();
                    dt = con.executarSQL("SELECT * FROM tblLivro WHERE idLivro=" + id);

                    string idAutor = dt.Rows[0]["idAutor"].ToString(), idGenero = dt.Rows[0]["idGenero"].ToString();

                    txtNomeLivro.Text = dt.Rows[0]["nomeLivro"].ToString();
                    txtDescLivros.Text = dt.Rows[0]["descLivro"].ToString();

                    dt = con.executarSQL("SELECT nomeAutor FROM tblAutor WHERE idAutor=" + idAutor);
                    txtAutor.Text = dt.Rows[0]["nomeAutor"].ToString();

                    dt = con.executarSQL("SELECT nomeGenero FROM tblGenero WHERE idGenero=" + idGenero);
                    txtGenero.Text = dt.Rows[0]["nomeGenero"].ToString();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Erro Consulta SQL: " + ex.Message);
                }
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            FrmBuscaAutor ba = new FrmBuscaAutor();

            if(ba.ShowDialog() == DialogResult.OK)
            {
                if (autor.getAutorID() > 0)
                {
                    dt = con.executarSQL("SELECT nomeAutor FROM tblAutor WHERE idAutor=" + autor.getAutorID());
                    txtAutor.Text = dt.Rows[0]["nomeAutor"].ToString();
                }
            }
            
        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            FrmBuscaGenero bg = new FrmBuscaGenero();
            if(bg.ShowDialog() == DialogResult.OK)
            {
                if (genero.getGeneroID() > 0)
                {
                    dt = con.executarSQL("SELECT nomeGenero FROM tblGenero WHERE idGenero=" + genero.getGeneroID());
                    txtGenero.Text = dt.Rows[0]["nomeGenero"].ToString();
                }
            }
            
        }
    }
}
