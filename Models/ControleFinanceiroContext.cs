using Microsoft.EntityFrameworkCore;

namespace controleFinanceiro.Models
{
    public class ControleFinanceiroContext : DbContext
    {
        public ControleFinanceiroContext(DbContextOptions<ControleFinanceiroContext> options) : base(options){
        }
        public DbSet<Financa> Financa {get;set;}

        public DbSet<Categoria> Categoria {get;set;}
        public DbSet<Modalidade> Modalidade {get;set;}
        public DbSet<Tipo> Tipo {get;set;}
        public DbSet<Usuario> Usuario {get;set;}

    }
}