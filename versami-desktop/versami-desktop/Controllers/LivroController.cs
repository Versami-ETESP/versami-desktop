using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Util;

namespace versami_desktop.Controllers
{
    class LivroController
    {
        private Conexao con;
        private DataTable dt;

        public DataTable obtemLivroGrid(string id)
        {
            string sql = "SELECT l.idLivro, l.nomeLivro, l.descLivro, l.imgCapa, a.nomeAutor, g.nomeGenero " +
                "FROM tblLivro AS l " +
                "JOIN tblAutor AS a ON l.idAutor = a.idAutor " +
                "JOIN tblGenero AS g ON l.idGenero = g.idGenero " +
                "WHERE l.idLivro = @id"; 
            try
            {
                con = new Conexao();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);
                dt = con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Console.WriteLine("Erro Na Consulta - Obter Livros: " + e.Message);
            }

            return dt;
        }
    }
}
