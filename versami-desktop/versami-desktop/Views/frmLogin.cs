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
    public partial class frmLogin: Form
    {
        AcessoController lc = new AcessoController();
        bool correctLogin = false;
    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string arroba = txtArroba.Text, senha = txtSenha.Text;

            if(lc.logar(arroba, senha))
            {
                correctLogin = true;
                this.Close();
            }
            else
            {
                lblMensagem.Text = "Usuário ou senha incorreto";
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (!correctLogin)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastro fc = new FrmCadastro();
            fc.ShowDialog();
        }
    }
}
