namespace FlashCardsWebApp.Models
{
    public class Karteikarte
    {
        public int Id { get; set; }
        public string Frage { get; set; } = null!;
        public string Antwort { get; set; } = null!;
    }
}