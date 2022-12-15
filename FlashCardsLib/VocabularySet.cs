using System.Xml;
using System.Xml.Serialization;

namespace FlashCardsLib
{
    [Serializable]
    [XmlInclude(typeof(VocabularySet))]
    public class VocabularySet
    {
        public string VocabularySetName { get; private set; } = "New VocabularySet";

        public List<List<(Language, WordEntry)>> Translations = new List<List<(Language, WordEntry)>>();

        public VocabularySet ()
        {

        }

        public VocabularySet (WordEntry wordEntry)
        {

        }

    }
}