using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace FlashCardsLib
{

    public class Wordtype : IWordtype
    {
        public string Typename { get => typeof(Wordtype).ToString(); }

        public Wordtype() { }
    }

    public interface IWordtype
    {
        public string Typename { get; }
        public Language Language { get; }



    }

    // --- ENGLISH ---

    /*

    Noun = 0
    Verb = 1
    Adjective = 2
    Article = 3         //a, an, the
    Pronoun = 4         //Personal: I, him, his, yourself Indefinite: any, some, everybody, this, that, such, who
    Determiner = 5      //many, some, all
    Adverb = 6          //dort, deinetwegen, so, gestern
    Preposition = 7     //unter, gegenüber, auf
    Conjunction = 8     //weil, oder, sondern

    */


    // --- GERMAN ---

    //Noun = 0
    //Verb = 1
    //Adjective = 2
    //Article = 3       //der, die, das, ein, eine
    //Pronoun = 4       //er, wir, du, den, dem, des, dich, mich, sich 
    //Determiner = 5    //viele, einige, alle
    //Adverb = 6        //dort, deinetwegen, so, gestern
    //Preposition = 7   //unter, gegenüber, auf
    //Conjunction = 8   //weil, oder, sondern

}