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

namespace versami_desktop.Views
{
    public partial class FrmBuscaLivro: Form
    {
        Livro livro = new Livro();
        LivroController lc = new LivroController();
        public FrmBuscaLivro()
        {
            InitializeComponent();
        }

        public void formataGrid()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.AllowUserToAddRows = false; //ESCONDE A NOVA LINHA DO GRID
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false; //ESCONDE O PONTEIRO DO GRID
            dataGridView1.ReadOnly = true;
            //permite personalizar o grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(26, 42, 65);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            dataGridView1.ForeColor = Color.White;
            //altera o cabecalho
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 77, 108);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //altera o nome das colunas
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOME DO LIVRO";
            //altera o tamanho das colunas
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 210;
            //não permite seleção de multiplas linhas    
            dataGridView1.MultiSelect = false;
            //ao clicar, seleciona a linha inteira
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Expande a célula automáticamente
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lc.buscaLivro(txtNome.Text);
            formataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                livro.setBookID(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));           
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
