using Espadana.Domain;
using Microsoft.EntityFrameworkCore;



namespace Pap.WebPushManagement.Infrastructure.Persistence
{
    public class EspadanaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=Espadana;Trusted_Connection=True;");
        }
        public virtual DbSet<EspadanaUser> EspadanaUsers { get; set; }
    }
}
