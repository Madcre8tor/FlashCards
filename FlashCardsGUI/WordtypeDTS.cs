using FlashCardsLib;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FlashCardsGUI
{
    public class WordtypeDTS : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is IWordtype)
            {
                IWordtype wordtype = item as IWordtype;

                if (wordtype.Language == )
                    return
                        element.FindResource("importantTaskTemplate") as DataTemplate;
                else
                    return
                        element.FindResource("myTaskTemplate") as DataTemplate;
            }

            return null;
        }



        public DataTemplate SelectedEnglishDataTemplate(IWordtype wordtype, FrameworkElement element)
        {
            if (wordtype is English.Noun)

                var template = element.FindResource("English+Noun") as DataTemplate;
            return template;
        }

        public DataTemplate SelectGermanDataTemplate(IWordtype wordtype)
        {


        }



    }
}
