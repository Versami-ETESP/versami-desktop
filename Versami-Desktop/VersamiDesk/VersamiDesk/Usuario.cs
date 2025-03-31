using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersamiDesk
{
    public class Usuario
    {
        [Key] // Define a propriedade como chave primária
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public DateTime data_nasc { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string arroba_usuario { get; set; }
        public byte[] fotoUsuario { get; set; }
        public byte[] fotoCapa { get; set; }
        public string bio_usuario { get; set; }
    }
}
