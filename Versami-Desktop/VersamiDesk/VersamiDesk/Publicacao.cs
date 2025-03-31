using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersamiDesk;

namespace VersamiDesk
{
    [Table("tblPublicacao")]
    public class Publicacao
    {
        [Key]
        public int IdPublicacao { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Conteudo { get; set; }

        [Required]
        [MaxLength(80)]
        public string Titulo { get; set; }

        [Column("dataPublic")]
        public DateTime DataPublic { get; set; }

        public int Nota { get; set; }

        // Alterar a propriedade de navegação para o tipo correto (Usuario)
        public int IdUsuario { get; set; }

        // Propriedade de navegação com o tipo correto (Usuario)
        public Usuario Usuario { get; set; }  // Aqui o tipo é Usuario, não 'object'

        public int? IdLivro { get; set; }
    }
}

