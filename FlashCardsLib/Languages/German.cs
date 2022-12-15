using System.Runtime.CompilerServices;

namespace FlashCardsLib.German
{
    public class German : ILanguage
    {
        public Language LanguageEnum { get => LANGUAGE; }
        public const Language LANGUAGE = Language.German;
        public string LanguageStringNative { get => "Deutsch"; }

        public enum Perspective
        {
            Infinite = 0,
            First = 1,
            Second = 2,
            Third = 3
        }
        public enum Numerus
        {
            None = 0,               // for non-countable e.g. water, or verbs in infinite form
            Singular = 1,           // book, switch, sheep, goose
            Plural = 2              // cats, switches, sheep, geese
        }

    }

    public class Noun : IWordtype
    {
        public string Typename => typeof(Noun).Name;
        public Language Language => LANGUAGE;

        public string Article;
        public Numerus Numerus;

        public Noun(string article, German.Numerus numerus)
        {
            this.Numerus = numerus;
            this.Article = article;
        }
    }

    public class Verb : IWordtype
    {
        public string Typename => typeof(Verb).Name;
        public Language Language => LANGUAGE;

        public German.Perspective Perspective;          // Infinitiv, Erste Person, Zweite Person, Dritte Person
        public German.Numerus Numerus;                  // Menge(Unzählbar), Singular, Plural

        public string? Infinite;         // gehen
        public string? Present;          // gehe, gehst, geht, gehen, geht, gehen
        public string? Past;             // ging
        public string? Perfect;          // gegangen

        public Verb(
            Perspective perspective,
            Numerus numerus,
            string? infinite,
            string? present,
            string? past,
            string? perfect)
        {
            Perspective = perspective;
            Numerus = numerus;
            Infinite = infinite;
            Present = present;
            Past = past;
            Perfect = perfect;
        }
    }

    public class Adjective : IWordtype
    {
        public string Typename => typeof(Adjective).Name;
        public Language Language => German.LANGUAGE;

        public bool IsIrregular;                    // wether the adjective has irregular comparison forms (gut besser am besten, schlecht schlechter am schlechtesten, ...).

        public string? Comparative;                 // schneller, höher
        public string? Superlative;                 // (am) schnellsten, (am) höchsten

        public bool IsAdverb;                       // whether the adjective can be used as adverb "Er eilte <schnell> die Treppe hinauf"
                                                    // "Sie arbeitet <konzentriert> an ihren Hausaufgaben".
    }

    public class Article : IWordtype
    {
        public string Typename => typeof(Article).Name;
        public Language Language => German.LANGUAGE;
        // der, die, das
        // ein, eine, sein, den
    }

    public class Pronoun : IWordtype
    {
        public string Typename => typeof(Pronoun).Name;
        public Language Language => German.LANGUAGE;
        //er, sie, es
    }

    public class Determiner : IWordtype
    {
        public string Typename => typeof(Determiner).Name;
        public Language Language => German.LANGUAGE;
    }

    public class Adverb : IWordtype
    {
        public string Typename => typeof(Adverb).Name;
        public Language Language => German.LANGUAGE;
    }

    public class Preposition : IWordtype
    {
        public string Typename => typeof(Preposition).Name;
        public Language Language => German.LANGUAGE;
    }

    public class Conjunction : IWordtype
    {
        public string Typename => typeof(Conjunction).Name;
        public Language Language => German.LANGUAGE;
        //weil, sondern, wegen
    }

    //Noun = 0,
    //Verb = 1,
    //Adjective = 2,
    //Article = 3,        //der, die, das, ein, eine
    //Pronoun = 4,        //er, wir, du, den, dem, des, dich, mich, sich 
    //Determiner = 5,     //viele, einige, alle
    //Adverb = 6,         //dort, deinetwegen, so, gestern
    //Preposition = 7,    //unter, gegenüber, auf
    //Conjunction = 8,    //weil, oder, sondern
}