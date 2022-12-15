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

                if (wordtype.Priority == 1)
                    return
                        element.FindResource("importantTaskTemplate") as DataTemplate;
                else
                    return
                        element.FindResource("myTaskTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
