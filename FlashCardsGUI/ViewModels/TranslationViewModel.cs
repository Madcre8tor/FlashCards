using FlashCardsLib;

namespace FlashCardsGUI.ViewModels
{
    public class TranslationViewModel : Translation
    {
        public Language[]? LanguageForeignValid { get; set; } = null!;

        public TranslationViewModel() { }
    }


}
