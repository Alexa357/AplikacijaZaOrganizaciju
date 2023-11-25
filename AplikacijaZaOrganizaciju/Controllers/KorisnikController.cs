using AplikacijaZaOrganizaciju.Models;
using AplikacijaZaOrganizaciju.Repository.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace AplikacijaZaOrganizaciju.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : Controller
    {
        private readonly IKorisnikRepository _korisnikRepository;

        public KorisnikController(IKorisnikRepository korisnikRepository)
        {
            _korisnikRepository = korisnikRepository;
        }

        [HttpPost(Name = "NapraviKorisnika")]
        public async Task<ActionResult<bool>> NapraviKorisnika([FromBody] Korisnik korisnik)
        {
            await _korisnikRepository.NapraviKorisnika(korisnik);
            return Ok(true);
        }
    }
}
