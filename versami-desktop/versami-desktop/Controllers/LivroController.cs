using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using versami_desktop.Entities;
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

        public bool insertLivro(Livro livro)
        {
            var result = false;
            var sql = "INSERT INTO tblLivro (nomeLivro, descLivro, imgCapa, idGenero, idAutor) " +
                "VALUES (@nome, @desc, @img, " +
                "(SELECT idGenero FROM tblGenero WHERE nomeGenero=@nomeGenero), " +
                "(SELECT idAutor FROM tblAutor WHERE nomeAutor=@nomeAutor));";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@nome", livro.getTitle());
                cmd.Parameters.AddWithValue("@desc", livro.getSummary());
                cmd.Parameters.AddWithValue("@img", livro.getCover());
                cmd.Parameters.AddWithValue("@nomeGenero", livro.getGenre());
                cmd.Parameters.AddWithValue("@nomeAutor", livro.getAutor());
                result = con.updateComParametros(cmd) > 0;
            }catch(Exception e)
            {
                Console.WriteLine("Erro no Insert - Cadastrar Livro: " + e.Message);
            }
            return result;
        }

        public void deleteLivro(string livro)
        {
            var sql = "DELETE FROM tblLivro WHERE idLivro = @id";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@id", livro);
                con.updateComParametros(cmd);
            }catch(Exception e)
            {
                Console.WriteLine("Erro no Delete - Deletar Livro: " + e.Message);
            }
        }

        public void updateLivro(Livro lv, int opc)
        {
            string sql = "";

            switch (opc)
            {
                case 1:
                    sql = "UPDATE tblLivro SET nomeLivro=@nome, descLivro=@desc, " +
                        "idGenero=(SELECT idGenero FROM tblGenero WHERE nomeGenero=@nomeGenero), " +
                        "idAutor=(SELECT idAutor FROM tblAutor WHERE nomeAutor=@nomeAutor) " +
                        "WHERE idLivro=@id";
                    break;
                case 2:
                    sql = "UPDATE tblLivro SET nomeLivro=@nome, descLivro=@desc, imgCapa=@capa, " +
                        "idGenero=(SELECT idGenero FROM tblGenero WHERE nomeGenero=@nomeGenero), " +
                        "idAutor=(SELECT idAutor FROM tblAutor WHERE nomeAutor=@nomeAutor) " +
                        "WHERE idLivro=@id";
                    break;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@nome", lv.getTitle());
                cmd.Parameters.AddWithValue("@desc", lv.getSummary());
                cmd.Parameters.AddWithValue("@nomeGenero", lv.getGenre());
                cmd.Parameters.AddWithValue("@nomeAutor", lv.getAutor());
                cmd.Parameters.AddWithValue("@id", lv.getBookID());

                if (opc == 2)
                    cmd.Parameters.AddWithValue("@capa", lv.getCover());

                con = new Conexao();
                con.updateComParametros(cmd);
            }catch(Exception e)
            {
                Console.WriteLine("Erro no Update - Atualizar Livro: " + e.Message);
            }
        }

        public DataTable carregarGrid()
        {
            String sql = "SELECT idLivro, nomeLivro, descLivro FROM tblLivro";
            try
            {
                con = new Conexao();
                dt = con.executarSQL(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Consulta SQL: " + e.Message);
            }

            return dt;
        }

        public DataTable buscaGenero(string nome)
        {
            var sql = "SELECT idGenero, nomeGenero FROM tblGenero WHERE nomeGenero LIKE @nome";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@nome", "%"+nome+"%");
                dt = con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL - Busca Genero: " + e.Message);
            }
            return dt;
        }

        public DataTable buscaAutor(string nome)
        {
            var sql = "SELECT idAutor, nomeAutor FROM tblAutor WHERE nomeAutor LIKE @nome";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                dt = con.queryComParametros(cmd);
            }catch(Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL - Busca Genero: " + e.Message);
            }
            return dt;
        }

        public DataTable buscaLivro(string nome)
        {
            var sql = "SELECT idLivro, nomeLivro FROM tblLivro WHERE nomeLivro LIKE @nome";

            try
            {
                con = new Conexao();
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                dt = con.queryComParametros(cmd);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL - Busca Livro: " + e.Message);
            }
            return dt;
        }
    }
}
