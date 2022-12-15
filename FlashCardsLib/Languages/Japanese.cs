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



        public enum Verbtype
        {
            Godan = 1,      //class 1 verb
            Ichidan = 2,    //class 2 verb
            Irregular = 3   //class 3 verb      
        }

        //public enum Adjectivetype

        //public enum Perspective (What forms exist in Japanese?)

        public class Noun
        {

        }

        public class Verb
        {

        }

        public class Adjective
        {

        }

        public class Particle
        {

        }

    }


}