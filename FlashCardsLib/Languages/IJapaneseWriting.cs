namespace FlashCardsLib
{
    public interface IJapaneseWriting
    {
        string? Kanji { get; set; }
        string? Hiragana { get; set; }
        string? Katakana { get; set; }

        public FlashCardsLib.Japanese.Japanese.Writing? PreferredWriting { get; set; }
    }
}