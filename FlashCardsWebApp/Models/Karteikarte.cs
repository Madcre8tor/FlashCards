namespace FlashCardsWebApp.Models
{
    public class Karteikarte
    {
        public int Id { get; set; }
        public string Frage { get; set; }
        public string Antwort { get; set; }

        public Karteikarte(int id, string frage, string antwort)
        {
            Id = id;
            Frage = frage;
            Antwort = antwort;
        }
    }
}