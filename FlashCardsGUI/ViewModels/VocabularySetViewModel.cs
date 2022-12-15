using FlashCardsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlashCardsGUI.ViewModels
{
    public class VocabularySetViewModel
    {
        public string VocabularySetName { get; private set; } = "New VocabularySet";

        public List<List<(Language, WordEntry)>> Translations = new List<List<(Language, WordEntry)>>();

        public VocabularySetViewModel()
        {

        }

        public VocabularySetViewModel(WordEntry wordEntry)
        {

        }

        public VocabularySetViewModel(int vocabularyEntry_ID, WordEntry wordEntry)
        {
            this.VocabularySet_ID = vocabularyEntry_ID;
        }

    }
}
