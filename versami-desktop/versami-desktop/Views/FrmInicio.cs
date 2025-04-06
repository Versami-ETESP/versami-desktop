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
    public partial class FrmInicio: Form
    {
        Conexao con;
        DataTable dt; 
        public FrmInicio()
        {
            InitializeComponent();
        }


        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblTotUsers.Text = contarInfos("SELECT COUNT(*) FROM tblUsuario");
            lblTotPost.Text = contarInfos("SELECT COUNT(*) FROM tblPublicacao");
            lblTotComentarios.Text = contarInfos("SELECT COUNT(*) FROM tblComentario");
            lblTopUser.Text = "@" + topUser();
        }

        private string contarInfos(string sql)
        {
            string total = "";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
                total = dt.Rows[0][0].ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro Consulta SQL: " + e.Message);
            }

            return total;
        }

        private string topUser()
        {
            string sql = "SELECT TOP 1 arroba_usuario FROM tblUsuario";
            string resultado = "";

            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
                resultado = dt.Rows[0][0].ToString();
            }catch(Exception e)
            {
                Console.WriteLine("Erro Consulta SQL: " + e.Message);
            }
            return resultado;
        }

    }
}
