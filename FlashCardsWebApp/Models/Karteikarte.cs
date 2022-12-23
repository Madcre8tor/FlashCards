namespace FlashCardsWebApp.Models
{
    public class Karteikarte
    {
        public int Id { get; set; } 
        public string Frage { get; set; } = null!; //<-- Frag Frank mal hier
        public string Antwort { get; set; } = null!;
    }
}