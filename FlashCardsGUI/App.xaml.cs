using CommunityToolkit.Mvvm.Input;
using FlashCardsGUI.ViewModels;
using FlashCardsLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using FlashCardsLib.English;
using FlashCardsLib.German;
using FlashCardsLib.Japanese;


namespace FlashCardsGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static readonly Language[] LanguageEnums = (Language[])Enum.GetValues(typeof(Language));             // All available AppLanguages?
        public static readonly string[] Languages = (string[])Enum.GetValues(typeof(Language));                     // All available ToolLanguages?

        //public static readonly IWordtype[] Wordtypes = AppConstants.SUPPORTED_WORDTYPES;

        public App()
        {
            this.InitializeComponent();
            //this.Resources.Add("Languages", Languages);       //Adding languages through code
            //this.TryFindResource(Languages);
        }

    }
}
