using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersamiDesk
{
    class Livro
    {

        [Key]
        public int idLivro { get; set; }

        [Required]
        [StringLength(200)]
        public string titulo { get; set; }
    }
}
