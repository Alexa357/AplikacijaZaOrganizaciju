using AplikacijaZaOrganizaciju.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AplikacijaZaOrganizaciju.Configuration
{
    public class KorisnikConfiguration : IEntityTypeConfiguration<Korisnik>
    {
        public void Configure(EntityTypeBuilder<Korisnik> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.KorisnickoIme).HasColumnType("NVARCHAR(30)");
            builder.Property(u => u.Lozinka).HasColumnType("NVARCHAR(30)");
            builder.Property(u => u.JMBG).HasColumnType("NVARCHAR(13)").HasMaxLength(13);
            builder.Property(u => u.Ime).HasColumnType("NVARCHAR(20)");
            builder.Property(u => u.Prezime).HasColumnType("NVARCHAR(20)");

            builder.ToTable("Korisnik");
        }
    }
}
