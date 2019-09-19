using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace casas.Modelos
{
    public class ImoveisDBContext : DbContext
    {
        public DbSet<Imovel> Imoveis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=c:/sqlite/imoveis.db");
        }

    }
}