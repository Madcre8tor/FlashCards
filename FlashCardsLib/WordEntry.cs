using System.Xml.Serialization;

namespace FlashCardsLib
{
    [Serializable]
    [XmlInclude(typeof(WordEntry))]
    public class WordEntry
    {
        //vocabulary_id is assigned by database
        public int Dictionary_ID { get; private set; }
        public string Word { get; private set; }
        public int Wordtype_ID { get; private set; }
        public int Language_ID { get; private set; }

        public WordEntry(int dictionary_ID, string word, int wordtype_ID, int language_ID)
        {
            Dictionary_ID = dictionary_ID;
            Word = word;
            Wordtype_ID = wordtype_ID;
            Language_ID = language_ID;
        }

        public WordEntry (string word)
        {
            Word = word;
        }
    }
}