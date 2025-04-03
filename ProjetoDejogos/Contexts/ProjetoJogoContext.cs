using Microsoft.EntityFrameworkCore;
using ProjetoDejogos.Domains;

namespace ProjetoDejogos.Contexts
{
    public class ProjetoJogoContext : DbContext
    {
        public ProjetoJogoContext()
        {
        }
        public ProjetoJogoContext(DbContextOptions<ProjetoJogoContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-ALUUT85\\SQLEXPRESS; Database = ProjetoDejogo; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
    

    
