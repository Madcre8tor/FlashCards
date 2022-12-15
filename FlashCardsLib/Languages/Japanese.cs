using System.Diagnostics.Contracts;

namespace FlashCardsLib
{
    public class Japanese : ILanguage
    {
        public Language LanguageEnum { get => LANGUAGE; }
        public const Language LANGUAGE = Language.Japanese;
        public string LanguageStringNative { get => "日本語"; }
        /*  alternatively:            
            にっぽんご
        */
        public enum Writing
        {
            Kanji = 1,
            Hiragana = 2,
            Katakana = 3,
            Romaji = 4,
        }

        public enum Verbtype
        {
            Godan = 1,      //class 1 verb
            Ichidan = 2,    //class 2 verb
            Irregular = 3   //class 3 verb      
        }

        //public enum Adjectivetype

        //public enum Perspective (What forms exist in Japanese?)

        

    }

    public class Noun : IWordtype, IJapaneseWriting
    {
        public string Typename => typeof(Noun).Name;
        public Language Language => Japanese.LANGUAGE;

        public string? Kanji { get; set; }
        public string? Hiragana { get; set; }
        public string? Katakana { get; set; }
        public Japanese.Writing? PreferredWriting { get; set; }

        // mizu, ringo, sushi
    }

    public class Verb : IWordtype, IJapaneseWriting
    {
        public string Typename => typeof(Verb).Name;
        public Language Language => Japanese.LANGUAGE;

        public string? Kanji { get; set; }
        public string? Hiragana { get; set; }
        public string? Katakana { get; set; }
        public Japanese.Writing? PreferredWriting { get; set; }
        // ageru, taberu, 
    }

    public class Adjective : IWordtype, IJapaneseWriting
    {
        public string Typename => typeof(Adjective).Name;
        public Language Language => Japanese.LANGUAGE;

        public string? Kanji { get; set; }
        public string? Hiragana { get; set; }
        public string? Katakana { get; set; }
        public Japanese.Writing? PreferredWriting { get; set; }
        // kawaii, aoi, 
    }

    public class Particle : IWordtype, IJapaneseWriting
    {
        public string Typename => typeof(Particle).Name;
        public Language Language => Japanese.LANGUAGE;

        public string? Kanji { get; set; }
        public string? Hiragana { get; set; }
        public string? Katakana { get; set; }
        public Japanese.Writing? PreferredWriting { get; set; }
        // ha, wo, ni, no
        // 
    }


}