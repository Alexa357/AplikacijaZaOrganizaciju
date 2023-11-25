using AplikacijaZaOrganizaciju.Models;
using AplikacijaZaOrganizaciju.Repository.Models;

namespace AplikacijaZaOrganizaciju.Repository.Abstraction
{
    public interface IKorisnikRepository
    {
        Task NapraviKorisnika(Korisnik korisnik);
    }
}
