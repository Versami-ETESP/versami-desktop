using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersamiDesk
{
    class Admin
    {
        [Key] public int Id { get; set; }
        public int IdAdmin { get; set; }  
        public string Nome { get; set; } 
        public DateTime DataNasc { get; set; }  
        public string Email { get; set; }  
        public string Senha { get; set; } 
        public string ArrobaUsuario { get; set; }  
        public bool PermissaoAdmin { get; set; }
    }
}
