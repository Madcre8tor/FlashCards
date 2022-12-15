using CommunityToolkit.Mvvm.Input;
using FlashCardsGUI.ViewModels;
using FlashCardsLib;
using System;
using System.Windows;

namespace FlashCardsGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MainWindowViewModel MainWindowViewModel { get; private set; } = new MainWindowViewModel();

        public static readonly Language[] Languages = (Language[])Enum.GetValues(typeof(Language));



    }
}
