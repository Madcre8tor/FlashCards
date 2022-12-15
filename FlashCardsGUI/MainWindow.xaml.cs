using System.Text;
using System.Windows;
using System.Windows.Controls;

using FlashCardsLib;
using FlashCardsLib.Database;
using FlashCardsGUI.ViewModels;

using WordLanguage = FlashCardsLib.Language;


namespace FlashCardsGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel? mainWindowViewModel = new MainWindowViewModel();
        private DatabaseHandler dataBaseHandler = new DatabaseHandler();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = (MainWindowViewModel)mainWindowViewModel;
            
            //
            // CONNECT TO DATABASE
            // 

            StringBuilder sb = new StringBuilder();

            dataBaseHandler.Connection.Open();
            var state = dataBaseHandler.Connection.State;
            sb.Append(state);
            dataBaseHandler.Connection.Close();

            DebugField.Text = sb.ToString();

            //
            // READ LOCAL LANGUAGE LIBS
            // 

        }

        private void DebugField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewVocabularyEntry_Click(object sender, RoutedEventArgs e)
        {
            TranslationListDisplay.Items.Add(new VocabularySet());

        }

        private void VocabularySetDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TranslationListDisplay.SelectedItems.Count == 0)
                VocabularyEntryBox.IsEnabled = false;
            else
                TranslationListDisplay.IsEnabled = true;
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rename_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
