using AplikacijaZaOrganizaciju.Models;
using Microsoft.EntityFrameworkCore;

namespace AplikacijaZaOrganizaciju.OrganizacijaContext
{
    public class OrganizacijaDbContext : DbContext
    {
        public OrganizacijaDbContext(DbContextOptions<OrganizacijaDbContext> options) : base(options)
        {

        }

        public DbSet<Korisnik> Korisnik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrganizacijaDbContext).Assembly);
        }
    }
}
