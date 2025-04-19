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
    public partial class FrmBuscaGenero: Form
    {
        Conexao con;
        DataTable dt;
        Genero gen = new Genero();
        public FrmBuscaGenero()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeGen = txtNome.Text;
            try
            {
                con = new Conexao();
                dt = con.executarSQL("SELECT idGenero, nomeGenero FROM tblGenero WHERE nomeGenero LIKE '%" + nomeGen + "%'");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro de consulta SQL: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                gen.setGeneroID(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
