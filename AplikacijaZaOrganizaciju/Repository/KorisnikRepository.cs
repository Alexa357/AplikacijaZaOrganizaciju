using AplikacijaZaOrganizaciju.Models;
using AplikacijaZaOrganizaciju.OrganizacijaContext;
using AplikacijaZaOrganizaciju.Repository.Abstraction;
using AplikacijaZaOrganizaciju.Repository.Models;

namespace AplikacijaZaOrganizaciju.Repository
{
    public class KorisnikRepository : IKorisnikRepository
    {
        private readonly OrganizacijaDbContext _context;

        public KorisnikRepository(OrganizacijaDbContext context)
        {
            _context = context;
        }
        public async Task NapraviKorisnika(Korisnik korisnik)
        {
            _context.Korisnik.Add(korisnik);
            await _context.SaveChangesAsync();
        }
    }
}
