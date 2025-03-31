using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Emit;


namespace VersamiDesk
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Publicacao> Publicacao { get; set; }

        // Construtor que define a string de conexão (referência do App.config)
        public ApplicationDbContext()
            : base("name=conectando")  // Nome da string de conexão no App.config
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração de relacionamento entre Publicacao e Usuario
            modelBuilder.Entity<Publicacao>()
                .HasRequired(p => p.Usuario)  // Relacionamento obrigatório com Usuario
                .WithMany()  // Um Usuario pode ter várias Publicações
                .HasForeignKey(p => p.IdUsuario)  // Define a chave estrangeira
                .WillCascadeOnDelete(true);  // Exclusão em cascata (opcional)
        }
    }
}