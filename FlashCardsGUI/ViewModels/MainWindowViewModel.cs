using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.Input;
using FlashCardsLib;
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;

namespace FlashCardsGUI.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        App App = (FlashCardsGUI.App)System.Windows.Application.Current;

        //[ObservableProperty]
        //private VocabularySet curSel_VocabularySet;

        //[ObservableProperty]
        //private Language curSel_VocabularySetLanguage;


        [ObservableProperty]
        private ObservableCollection<VocabularySet> vocabularySets = new ObservableCollection<VocabularySet>();

        //[ObservableProperty]
        //NextProp

        public MainWindowViewModel()
        {
            //Empty Constructor?
        }

          



        public void DoSomething() 
        {
           
        }

        [RelayCommand]
        private void VocabularyEntry_Add()
        {

        }

        [RelayCommand]
        private void VocabularyEntry_Remove()
        {

        }

        [RelayCommand]
        private void VocabularyEntry_Rename()
        {

        }

        [RelayCommand]
        private void VocabularyEntry_Options()
        {

        }

        [RelayCommand]
        private void VocabularyEntry_Upload()
        {

        }


    }

    
}
