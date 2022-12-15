using CommunityToolkit.Mvvm.Input;
using FlashCardsGUI.ViewModels;
using FlashCardsLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;


namespace FlashCardsGUI
{

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public MainWindowViewModel MainWindowViewModel { get; private set; } = new MainWindowViewModel();         // Reference to MainWindow?
        public static readonly Language[] LanguageEnums = (Language[])Enum.GetValues(typeof(Language));             // All available AppLanguages?
        public static readonly string[] Languages = (string[])Enum.GetValues(typeof(Language));                     // All available ToolLanguages?

        public static readonly List<IWordtype> Wordtypes = GetWordtypes();

        private static List<IWordtype> GetWordtypes()
        {
            List<IWordtype> allWordtypes = new List<IWordtype>();

            string[] languages = (string[])Enum.GetValues(typeof(Language));

            Type[] languageTypes = new Type[] {
                typeof(German),
                typeof(English),
                typeof(Japanese)
                };

            foreach (Type languageType in languageTypes)
            {
                var wordtypesFromCurrentLanguage = languageType.GetNestedTypes();
                foreach (IWordtype wordtype in wordtypesFromCurrentLanguage)
                { 
                    allWordtypes.Add(wordtype);             // Frag mal Frank hier, was hat es mit type auf sich.
                }

                 
            }

            return allWordtypes;
        }

        public App()
        {
            this.InitializeComponent();
            //this.Resources.Add("Languages", Languages);       //Adding languages through code
            //this.TryFindResource(Languages);
        }

    }
}
