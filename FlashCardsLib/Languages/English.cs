namespace FlashCardsLib
{
    public class English : ILanguage
    {
        public Language LanguageEnum { get => LANGUAGE; }
        public string LanguageStringNative { get => "English"; }

        public const Language LANGUAGE = Language.English;
        public enum Perspective
        {
            Infinite = 0,
            First = 1,
            Second = 2,
            Third = 3
        }
        public enum Numerus
        {
            None = 0,
            Singular = 1,
            Plural = 2
        }

        public class Noun : IWordtype
        {
            public string Typename => typeof(English.Noun).Name;
            public Language Language => LANGUAGE;

            public string? Article;                             //an apple, a banana    | null for non-countables and Plural (information, apples)
            public Numerus Numerus;

            public Noun(string? article, Numerus numerus)
            {
                this.Article = article;
                this.Numerus = numerus;
            }
        }

        public class Verb : IWordtype
        {
            public string Typename => typeof(English.Verb).Name;
            public Language Language => LANGUAGE;

            public English.Perspective Perspective;             // First Person, Second Person, Third Person
            public English.Numerus Numerus;                     // Singular, Plural

            public string? Infinite;         // go
            public string? Present;          // go, goes
            public string? Progressive;      // going
            public string? Past;             // went
            public string? Perfect;          // gone

            public Verb(
                Perspective perspective,
                Numerus numerus,
                string? infinite,
                string? present,
                string? progressive,
                string? past,
                string? perfect)
            {
                Perspective = perspective;
                Numerus = numerus;
                Infinite = infinite;
                Present = present;
                Progressive = progressive;
                Past = past;
                Perfect = perfect;
            }
        }

        public class Adjective : IWordtype
        {
            public string Typename => typeof(English.Adjective).Name;
            public Language Language => LANGUAGE;

            public bool IsIrregular;                    // wether the adjective has irregular comparison forms (good better best, bad worse worst, few, many, ...).
            public bool IsPeriphrasisRequired;          // whether the use of "more" or "most" is required when creating Comparative and Superlative form of the adjective.
            public string? Comparative;                 // lazier, more comfortable, better         | if IsPeriphrasisRequired is true this can be left open.
            public string? Superlative;                 // laziest, most comfortable, best          | if IsPeriphrasisRequired is true this can be left open.

            public bool HasAdverb;                    // whether the adjective has an adverb form.
            public string? Adverb;                      // <!hotly>, comfortably, easily
        }

        public class Article : IWordtype
        {
            public string Typename => typeof(English.Article).Name;
            public Language Language => LANGUAGE;
            // a, an, the
        }

        public class Pronoun : IWordtype
        {
            public string Typename => typeof(English.Pronoun).Name;
            public Language Language => LANGUAGE;
        }             // it, they, those, mine, his

        public class Determiner : IWordtype
        {
            public string Typename => typeof(English.Determiner).Name;
            public Language Language => LANGUAGE;
            //
        }

        public class Adverb : IWordtype
        {
            public string Typename => typeof(English.Adverb).Name;
            public Language Language => LANGUAGE;
            // soon, slowly,
        }

        public class Preposition : IWordtype
        {
            public string Typename => typeof(English.Preposition).Name;
            public Language Language => LANGUAGE;
        }

        public class Conjunction : IWordtype
        {
            public string Typename => typeof(English.Conjunction).Name;
            public Language Language => LANGUAGE;
            // because, therefore
        }

        //public class Interjection : Wordtype { }      // Oops! Ouch! Wow
    }


}