using FlashCardsLib;
using FlashCardsLib.English;
using FlashCardsLib.German;
using FlashCardsLib.Japanese;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FlashCardsGUI
{
    public class WordtypeDTS : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement? element = container as FrameworkElement;

            if (element != null && item != null && item is IWordtype)
            {
                IWordtype? wordtype = item as IWordtype;
                if (wordtype == null)
                    return null!;

                if (wordtype.Language == Language.English)
                    return SelectedEnglishDataTemplate(wordtype, element);
                if (wordtype.Language == Language.German)
                    return SelectGermanDataTemplate(wordtype, element);
                if (wordtype.Language == Language.Spanish)
                    return SelectSpanishDataTemplate(wordtype, element);
                if (wordtype.Language == Language.French)
                    return SelectFrenchDataTemplate(wordtype, element);
                if (wordtype.Language == Language.Italian)
                    return SelectItalianDataTemplate(wordtype, element);
                if (wordtype.Language == Language.Japanese)
                    return SelectJapaneseDataTemplate(wordtype, element);
            }

            return null!;
        }

        public DataTemplate SelectedEnglishDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun) {
                template = element.FindResource("EnglishNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb) {
                template = element.FindResource("EnglishVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective) {
                template = element.FindResource("EnglishAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article) {
                template = element.FindResource("EnglishArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun) {
                template = element.FindResource("EnglishPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner) {
                template = element.FindResource("EnglishDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb) {
                template = element.FindResource("EnglishAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition) {
                template = element.FindResource("EnglishPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction) {
                template = element.FindResource("EnglishConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;                
        }

        public DataTemplate SelectGermanDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun) {
                template = element.FindResource("GermanNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb) {
                template = element.FindResource("GermanVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective) {
                template = element.FindResource("GermanAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article) {
                template = element.FindResource("GermanArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun) {
                template = element.FindResource("GermanPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner) {
                template = element.FindResource("GermanDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb) {
                template = element.FindResource("GermanAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition) {
                template = element.FindResource("GermanPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction) {
                template = element.FindResource("GermanConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;
        }

        public DataTemplate SelectSpanishDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun)
            {
                template = element.FindResource("GermanNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb)
            {
                template = element.FindResource("GermanVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective)
            {
                template = element.FindResource("GermanAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article)
            {
                template = element.FindResource("GermanArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun)
            {
                template = element.FindResource("GermanPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner)
            {
                template = element.FindResource("GermanDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb)
            {
                template = element.FindResource("GermanAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition)
            {
                template = element.FindResource("GermanPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction)
            {
                template = element.FindResource("GermanConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;

        }

        public DataTemplate SelectFrenchDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun)
            {
                template = element.FindResource("GermanNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb)
            {
                template = element.FindResource("GermanVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective)
            {
                template = element.FindResource("GermanAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article)
            {
                template = element.FindResource("GermanArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun)
            {
                template = element.FindResource("GermanPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner)
            {
                template = element.FindResource("GermanDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb)
            {
                template = element.FindResource("GermanAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition)
            {
                template = element.FindResource("GermanPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction)
            {
                template = element.FindResource("GermanConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;

        }

        public DataTemplate SelectItalianDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun)
            {
                template = element.FindResource("GermanNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb)
            {
                template = element.FindResource("GermanVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective)
            {
                template = element.FindResource("GermanAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article)
            {
                template = element.FindResource("GermanArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun)
            {
                template = element.FindResource("GermanPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner)
            {
                template = element.FindResource("GermanDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb)
            {
                template = element.FindResource("GermanAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition)
            {
                template = element.FindResource("GermanPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction)
            {
                template = element.FindResource("GermanConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;

        }

        public DataTemplate SelectJapaneseDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            DataTemplate? template = null!;

            if (wordtype is FlashCardsLib.English.Noun)
            {
                template = element.FindResource("GermanNounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Verb)
            {
                template = element.FindResource("GermanVerbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adjective)
            {
                template = element.FindResource("GermanAdjectiveTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Article)
            {
                template = element.FindResource("GermanArticleTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Pronoun)
            {
                template = element.FindResource("GermanPronounTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Determiner)
            {
                template = element.FindResource("GermanDeterminerTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Adverb)
            {
                template = element.FindResource("GermanAdverbTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Preposition)
            {
                template = element.FindResource("GermanPrepositionTemplate") as DataTemplate;
                return template!;
            }
            if (wordtype is FlashCardsLib.English.Conjunction)
            {
                template = element.FindResource("GermanConjunctionTemplate") as DataTemplate;
                return template!;
            }

            return template!;
        }



    }
}
