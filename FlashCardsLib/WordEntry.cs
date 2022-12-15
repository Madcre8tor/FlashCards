using System.Xml.Serialization;

namespace FlashCardsLib
{
    [Serializable]
    [XmlInclude(typeof(WordEntry))]
    public class WordEntry
    {
        public string Word { get; set; }
        public IWordtype Wordtype { get; set; }

        public WordEntry(string word, IWordtype wordtype)
        { 
            Word = word;
            Wordtype = wordtype;
        }
    }
}