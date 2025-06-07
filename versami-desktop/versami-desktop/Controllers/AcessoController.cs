using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public bool logar(string login, string senha)
        {
            bool resultado = false;

            try
            {
                this.con = new Conexao();
                SqlCommand cmd = new SqlCommand("usp_loginAdministrador");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@arroba", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                this.dt = con.queryComParametros(cmd);

                if(this.dt != null && this.dt.Rows.Count > 0)
                {
                    Admin adm = new Admin();
                    adm.setId(Convert.ToInt32(dt.Rows[0]["idAdmin"].ToString()));
                    adm.setArroba(dt.Rows[0]["arroba_usuario"].ToString());
                    adm.setNome(dt.Rows[0]["nome"].ToString());
                    adm.setPermissao(Convert.ToInt32(dt.Rows[0]["permissao"].ToString()));
                    resultado = true;
                }
            }catch(Exception e)
            {
                Debug.WriteLine("Erro ao consultar Login: " + e.Message);
            }
            return resultado;
        }

        public bool cadastrar(Admin adm)
        {
            bool resultado = false;
            string sql = "INSERT INTO tblAdmin (nome,data_nasc,email,senha,arroba_usuario,permissao,pergunta,resposta) " +
                "VALUES (@nome,@data,@email,@senha,@arroba,@permissao,@pergunta,@resposta)";
            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.AddWithValue("@nome", adm.getNome());
            cmd.Parameters.AddWithValue("@data", adm.getNasc());
            cmd.Parameters.AddWithValue("@email", adm.getEmail());
            cmd.Parameters.AddWithValue("@senha", adm.getSenha());
            cmd.Parameters.AddWithValue("@arroba", adm.getArroba());
            cmd.Parameters.AddWithValue("@permissao", adm.getPermissao());
            cmd.Parameters.AddWithValue("@pergunta", adm.getIdPergunta());
            cmd.Parameters.AddWithValue("@resposta", adm.getResposta());

            try
            {
                con = new Conexao();
                resultado = con.updateComParametros(cmd) > 0;

            }catch(Exception e)
            {
                Debug.WriteLine("Erro no Insert SQL Cadastro: " + e.Message);
            }

            return resultado;
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
                Debug.WriteLine("Erro na Consulta SQL Lista de Permissoes: " + e.Message);
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
                Debug.WriteLine("Erro na Consulta SQL Lista de Perguntas: " + e.Message);
            }
            return dt;
        }

        public DataTable buscaUsuario(string usuario)
        {
            string sql = "SELECT a.resposta, p.pergunta " +
                " FROM tblAdmin AS a JOIN tblPerguntaSecreta AS p " +
                "ON a.pergunta = p.idPergunta " +
                "WHERE a.arroba_usuario=@user";

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@user", usuario);
                con = new Conexao();
                dt = con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Debug.WriteLine("Erro na Consulta SQL - Busca Usuário: " + e.Message);
            }
            return dt;
        }

        public bool alteraSenha(Admin adm)
        {
            bool resultado = false;
            string sql = "UPDATE tblAdmin SET senha=@senha WHERE arroba_usuario=@user";

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@senha", adm.getSenha());
                cmd.Parameters.AddWithValue("@user", adm.getArroba());
                con = new Conexao();

                resultado = con.updateComParametros(cmd) > 0;
            }catch(Exception e)
            {
                Debug.WriteLine("Erro no Update - Altera Senha: " + e.Message);
            }

            return resultado;
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
