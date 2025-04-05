using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versami_desktop.Util
{
    class ValidaDados
    {
        public static bool nameIsValid(String nome)
        {
            return nome.Length >= 3;
        }

        public static bool passIsValid(String senha)
        {
            return senha.Length >= 8;
        }

        public static bool confirmIsValid(String senha, String confirma)
        {
            return senha.Equals(confirma);
        }

        public static bool emailIsvalid(String email)
        {
            String regex = "^[a-zA-Z0-9_+&*-]+(?:\\.[a-zA-Z0-9_+&*-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,7}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, regex);
        }

        public static bool birthIsValid(DateTime birth)
        {    
            DateTime today = DateTime.Now;
            int age = today.Year - birth.Year;

            if (today.Month < birth.Month || (today.Month == birth.Month && today.Day < birth.Day))
                age--;

            return age >= 18;
        }

        public static bool userExist(String user)
        {
            Conexao con = new Conexao();
            String sql = "SELECT arroba_usuario FROM tblAdmin WHERE arroba_usuario='" + user + "';";
            DataTable dt;
            try
            {
                dt = con.executarSQL(sql);
                
            }catch(Exception e)
            {
                Console.WriteLine("Erro na Consulta SQL: " + e.Message);
                return false;
            }

            return dt.Rows.Count <= 0 || dt == null;
        }
    }
}
