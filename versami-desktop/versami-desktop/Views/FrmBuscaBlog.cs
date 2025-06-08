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
    public partial class FrmBuscaBlog: Form
    {
        public FrmBuscaBlog()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var titulo = txtTitulo.Text;

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Digite algo para pesquisar");
                return;
            }

            var bc = new BlogController();
            var dt = bc.BuscarPorTitulo(titulo);

            if(dt == null || dt.Rows.Count <= 0)
            {
                MessageBox.Show("Publicação não localizada");
                return;
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                BlogPost bp = new BlogPost();
                bp.setIdPost(id);
                CompartilhaDados.setBlog(bp);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
