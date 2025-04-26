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

        public string logar(string nome)
        {

            string sql = "SELECT idAdmin, nome, arroba_usuario, permissao, senha FROM " + tabela + " WHERE arroba_usuario='" + nome + "';";
            string hash = "";

            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);

                if(dt.Rows.Count > 0 && dt != null)
                {
                    Admin adm = new Admin();
                    adm.setId(Convert.ToInt32(dt.Rows[0]["idAdmin"].ToString()));
                    adm.setArroba(dt.Rows[0]["arroba_usuario"].ToString());
                    adm.setNome(dt.Rows[0]["nome"].ToString());
                    adm.setPermissao(Convert.ToInt32(dt.Rows[0]["permissao"].ToString()));
                    hash = dt.Rows[0]["senha"].ToString();
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hash;
        }

        public bool cadastrar(Admin adm)
        {
            string sql = "INSERT INTO " + tabela + " VALUES ('" + adm.getNome() + "','" + adm.getNasc() + "','" + adm.getEmail() + "','" + adm.getSenha() + "','" + adm.getArroba() + "'," + adm.getPermissao() + ","+adm.getIdPergunta() + ",'"+adm.getResposta() + "');";
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

        public DataTable listaPermissoes()
        {
            string sql = "SELECT * FROM tblPermissao ORDER BY idPermissao";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);

            }catch(Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL: " + e.Message);
            }

            return dt;
        }

        public DataTable listaPerguntas()
        {
            string sql = "SELECT * FROM tblPerguntaSecreta ORDER BY idPergunta";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL: " + e.Message);
            }
            return dt;
        }

        public String getHash(String input)
        {
            System.Security.Cryptography.SHA256 sha = System.Security.Cryptography.SHA256.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
