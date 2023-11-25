namespace AplikacijaZaOrganizaciju.Repository.Models
{
    public interface NapraviKorisnikaCommand
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
