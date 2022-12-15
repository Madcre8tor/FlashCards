namespace FlashCardsLib
{
    public class Translation
    {
        public Language LanguageNative { get; set; } = Language.English;
        public Language LanguageForeign { get; set; } = Language.English;

        public WordEntry? WordNative { get; set; } = null;
        public WordEntry? WordForeign { get; set; } = null;

        public Translation() { }
    }


}
