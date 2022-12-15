using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;
using FlashCardsLib;
using FlashCardsLib.Database;
using FlashCardsGUI.ViewModels;
using System.Security.Principal;

namespace FlashCardsGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel MainWindowViewModel;
        private DatabaseHandler dataBaseHandler = new DatabaseHandler();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Application.Current;

            MainWindowViewModel = new MainWindowViewModel();

            //
            // CONNECT TO DATABASE
            // 

            StringBuilder sb = new StringBuilder();

            dataBaseHandler.Connection.Open();
            var state = dataBaseHandler.Connection.State;
            sb.Append(state);
            dataBaseHandler.Connection.Close();

            //
            // READ LOCAL LANGUAGE LIBS
            // 

            // !!

            // Initialize Language Options

            foreach (var language in App.Languages)
            {
                LanguageDropDown.Items.Add(language.ToString());
            }

            Array.ForEach(App.Languages, language => LanguageDropDown.Items.Add(language.ToString()));

        }

        private void DebugField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewVocabularyEntry_Click(object sender, RoutedEventArgs e)
        {
            VocabularyEntryDisplay.Items.Add(new VocabularySet());

        }

        private void VocabularyEntryDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VocabularyEntryDisplay.SelectedItems.Count == 0)
                VocabularyEntryBox.IsEnabled = false;
            else 
                VocabularyEntryDisplay.IsEnabled = true;
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rename_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
