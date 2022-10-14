using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace BackEnd.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Tr_Bpkb> Tr_Bpkbs { get; set; }
        public virtual DbSet<Ms_Storage_Location> Ms_Storage_Locations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tr_Bpkb>()
               .HasOne<Ms_Storage_Location>()
               .WithMany()
               .HasForeignKey(p => p.location_id);

            modelBuilder.Entity<Ms_Storage_Location>().HasData(
        new Ms_Storage_Location { location_id = "3201210001", location_name = "Karadenan" },
        new Ms_Storage_Location { location_id = "3201210002", location_name = "Nanggewer" },
        new Ms_Storage_Location { location_id = "3201210003", location_name = "Nanggewer Mekar" },
        new Ms_Storage_Location { location_id = "3201210004", location_name = "Cibinong" },
        new Ms_Storage_Location { location_id = "3201210005", location_name = "Pakansari" }
        );
        }
    }
}
