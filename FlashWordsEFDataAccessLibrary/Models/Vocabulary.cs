namespace FlashWordsEFDataAccessLibrary.Models
{
    public class Vocabulary
    {
        public int ID { get; set; }
        public string Word { get; set; }
        public int Wordtype_ID { get; set; }
        public int Language_ID { get; set; }
    }
}