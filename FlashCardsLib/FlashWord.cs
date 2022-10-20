using System.Text.Json;

namespace FlashCardsLib
{
    [Serializable]
    public class FlashWord
    {
        public string Language { get; }         // e.g German
        public string Profile { get; }          // e.g katze.json
        public string Appearance { get; }       // e.g Katze

        public List<LanguageLibrary> Relations = new List<LanguageLibrary>();

        // deprecated
        public FlashWord() { }

        public FlashWord (string profile, string appearance)
        {
            this.Profile = profile;
            this.Appearance = appearance;
        }

        public FlashWord (string profile, string appearance, List<LanguageLibrary> relations)
        {
            this.Profile = profile;
            this.Appearance = appearance;
            this.Relations = relations;
        }

        public class Serializer
        {
            public void Serialize()
            {

            }

            public FlashWord Deserialize()
            {
                


                return new FlashWord("hi", "hi");
            }

            public List<FlashWord> Deserialize(List<FlashWord> flashcards)
            { 
                return new List<FlashWord>(); 
            }

    
        }



    }
}