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
using versami_desktop.Views;

namespace versami_desktop
{
    public partial class FrmPrincipal: Form
    {
        private Form frmAtivo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void formShow(Form frm)
        {
            activeFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        public void activeFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        public void activeButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Turquoise;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activeButton(btnInicio);
            formShow(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            Admin adm = new Admin();
            lblNomeAdmin.Text = adm.getNome();
            lblPermissao.Text = tipoAdmin(adm.getPermissao());
            activeButton(btnInicio);
            formShow(new FrmInicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activeButton(btnUsuarios);
            formShow(new FrmUsuarios());
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            activeButton(btnLivros);
            formShow(new FrmLivros());
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            activeButton(btnPosts);
            formShow(new FrmPosts());
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            activeButton(btnBlog);
            formShow(new FrmBlog());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBugs_Click(object sender, EventArgs e)
        {
            activeButton(btnBugs);
            formShow(new FrmBugs());
        }

        public string tipoAdmin(int permissao)
        {
            switch (permissao)
            {
                case 1:
                    return "ADM Master";
                case 2:
                    return "ADM de Livros";
                case 3:
                    return "ADM Moderador";
                case 4:
                    return "ADM de Usuários";
                case 5:
                    return "ADM do Blog";
                default:
                    return "Administrador";
            }
        }
    }
}
