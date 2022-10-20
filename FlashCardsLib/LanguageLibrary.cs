namespace FlashCardsLib
{
    public class LanguageLibrary
    {
        public string Language;
        public Dictionary<string, string> Vocabulary;

        public LanguageLibrary(string language)
        {
            this.Language = language;
            this.Vocabulary = LoadVocabulary();
        }

        private Dictionary<string, string> LoadVocabulary()
        {
            Dictionary<string, string> vocabulary = new Dictionary<string, string>();

            string[] files = Directory.GetFiles(Path.Combine("LanguageLib", this.Language));

            foreach (string file in files)
            {
                using StreamReader sr = new StreamReader(file);
                {



                }

            }


            return vocabulary;
        }


    }

}

