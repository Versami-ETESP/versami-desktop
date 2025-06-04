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
    public partial class FrmPosts : Form
    {
        private DenunciaController dc = new DenunciaController();
        private Post publicacao;
        private Denuncia denuncia;
        private Usuario usuarioDenunciado;
        private Usuario usuarioDenunciante;

        public FrmPosts()
        {
            InitializeComponent();
        }

        private void FrmPosts_Load(object sender, EventArgs e)
        {
            panelDenuncia.Visible = false;
            gridDenuncias.DataSource = dc.listarDenunciasPendentes();
            comboSituacao.Items.Clear();
            comboSituacao.DataSource = dc.listarStatusDenuncia();
            comboSituacao.ValueMember = "idStatusDenuncia";
            comboSituacao.DisplayMember = "descStatus";
            comboSituacao.SelectedIndex = 0;
        }

        private void gridDenuncias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string idDenuncia = gridDenuncias.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.denuncia = dc.obterDenuncia(idDenuncia);

                if (denuncia == null) return;

                this.publicacao = this.denuncia.GetPost();
                this.usuarioDenunciante = this.denuncia.getUser();
                this.usuarioDenunciado = this.publicacao.GetUsuario();

                txtID.Text = this.publicacao.getIdPublicacao().ToString();
                panelDenuncia.Visible = true;
                panelDenuncia.Enabled = true;
               
            }
        }
    }

}
