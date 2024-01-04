using Microsoft.EntityFrameworkCore;

namespace ORMdoga.Models {
    public class ZeneDBContext : DbContext {

        public ZeneDBContext(DbContextOptions options) : base(options) {
            
        }

        public ZeneDBContext() { 

        }

        public DbSet<Eloado> Eloado { get; set; } = null;
        public DbSet<Szam> Szam { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                string conn = "server=localhost; database=Zene; user=root; password=";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }
    }
}
