namespace FlashCardsLib
{
    public class Translation
    {
        public Language LanguagePrimary { get; set; }
        public Language LanguageSecondary { get; set; }


    }

    public class TranslationViewModel
    {
        public Language LanguageWordEntry { get; set; } = Language.English;
        public Language LanguageTranslation { get; set; } = Language.English;

        public string? Word_WordEntry { get; set; } = null!;
        public string? Word_Translation { get; set; } = null!;

        public TranslationViewModel() { }
    }

    public class TranslationSet
    {
        public Language LanguagePrimary { get; set; }
        public Language LanguageSecondary { get; set; }

        public List<(string, string)> Translations { get; private set; } = new List<(string, string)>();

    }


}
