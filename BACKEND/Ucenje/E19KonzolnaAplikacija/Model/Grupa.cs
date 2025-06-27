namespace Ucenje.E19KonzolnaAplikacija.Model
{
    public class Grupa:Entitet
    {
        public string? Naziv { get; set; }
        public Smjer? Smjer { get; set; }
        public string? Predavac { get; set; }
        public List<Polaznik>? Polaznici { get; set; }

    }
}
