using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using versami_desktop.Entities;
using versami_desktop.Util;

namespace versami_desktop.Controllers
{
    class AcessoController
    {
        private Conexao con;
        private DataTable dt;
        private String tabela = "tblAdmin";

        public bool logar(string nome, string senha)
        {

            string sql = "SELECT idAdmin, nome, arroba_usuario, permissao FROM " + tabela + " WHERE arroba_usuario='" + nome + "' AND senha='" + senha + "';";

            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);

                if(dt.Rows.Count <= 0 || dt == null)
                {
                    return false;
                }
                else
                {
                    Admin adm = new Admin();
                    adm.setId(Convert.ToInt32(dt.Rows[0]["idAdmin"].ToString()));
                    adm.setArroba(dt.Rows[0]["arroba_usuario"].ToString());
                    adm.setNome(dt.Rows[0]["nome"].ToString());
                    adm.setPermissao(Convert.ToInt32(dt.Rows[0]["permissao"].ToString()));
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool cadastrar(Admin adm)
        {
            string sql = "INSERT INTO " + tabela + " VALUES ('" + adm.getNome() + "','" + adm.getNasc() + "','" + adm.getEmail() + "','" + adm.getSenha() + "','" + adm.getArroba() + "'," + adm.getPermissao().ToString() + ");";
            //MessageBox.Show(sql);
            try
            {
                con = new Conexao();
                con.executarSQL(sql);

            }catch(Exception e)
            {
                Console.WriteLine("Erro no Insert SQL: " + e.Message);
                return false;
            }

            return true;
        }
    }
}
