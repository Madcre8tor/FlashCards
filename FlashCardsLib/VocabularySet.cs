using System.Collections.ObjectModel;
using System.Xml;
using System.Xml.Serialization;

namespace FlashCardsLib
{
    [Serializable]
    [XmlInclude(typeof(VocabularySet))]
    public class VocabularySet
    {
        public string VocabularySetName { get; set; } = "New VocabularySet";
        public Language NativeLanguage { get; set; }
        public Language ForeignLanguage { get; set; }        
        public ObservableCollection<Translation> Translations { get; set; } = new ObservableCollection<Translation>(); 

        public VocabularySet ()
        {

        }

        public VocabularySet (WordEntry wordEntry)
        {

        }

    }
}