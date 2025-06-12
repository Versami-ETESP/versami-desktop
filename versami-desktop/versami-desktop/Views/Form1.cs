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
        Admin adm = new Admin();
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
            lblNomeAdmin.Text = this.adm.getNome();
            lblPermissao.Text = tipoAdmin(this.adm.getPermissao());
            activeButton(btnInicio);
            formShow(new FrmInicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if(adm.getPermissao() == Admin.PERMISSAO_MASTER)
            {
                activeButton(btnUsuarios);
                formShow(new FrmCadastro());
            }
            else
            {
                MessageBox.Show("Você não tem a permissão necessária para acessar essa tela.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            if (adm.getPermissao() == Admin.PERMISSAO_MASTER || adm.getPermissao() == Admin.PERMISSAO_LIVROS)
            {
                activeButton(btnLivros);
                formShow(new FrmLivros());
            }
            else
            {
                MessageBox.Show("Você não tem a permissão necessária para acessar essa tela.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            if (adm.getPermissao() == Admin.PERMISSAO_MASTER || adm.getPermissao() == Admin.PERMISSAO_MODERAR)
            {
                activeButton(btnPosts);
                formShow(new FrmPosts());
            }
            else
            {
                MessageBox.Show("Você não tem a permissão necessária para acessar essa tela.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            if (adm.getPermissao() == Admin.PERMISSAO_MASTER || adm.getPermissao() == Admin.PERMISSAO_BLOG)
            {
                activeButton(btnBlog);
                formShow(new FrmBlog());
            }
            else
            {
                MessageBox.Show("Você não tem a permissão necessária para acessar essa tela.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
        public string tipoAdmin(int permissao)
        {
            switch (permissao)
            {
                case Admin.PERMISSAO_MASTER:
                    return "ADM Master";
                case Admin.PERMISSAO_LIVROS:
                    return "ADM de Livros";
                case Admin.PERMISSAO_MODERAR:
                    return "ADM Moderador";
                case Admin.PERMISSAO_BLOG:
                    return "ADM do Blog";
                default:
                    return "ADMINISTRADOR";
            }
        }
    }
}
