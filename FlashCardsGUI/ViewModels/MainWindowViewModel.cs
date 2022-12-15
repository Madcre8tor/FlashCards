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
using FlashCardsGUI;

namespace FlashCardsGUI.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<VocabularySet>? vocabularySetList;
        [ObservableProperty]
        private VocabularySet? vocabularySetSelected;

        //[ObservableProperty]
        //private ObservableCollection<Translation>? translationList;
        [ObservableProperty]
        private Translation? translationSelected;

        public MainWindowViewModel()
        {
            var coll = new ObservableCollection<VocabularySet>();
            VocabularySetList = coll;
            VocabularySetList.Add(
                new VocabularySet()
                {
                    VocabularySetName = "New VocabularySet",
                    NativeLanguage = Language.English,
                    ForeignLanguage = Language.German,
                    Translations = new ObservableCollection<Translation> {
                        new Translation {
                            LanguageNative = Language.English,
                            LanguageForeign = Language.German,
                            WordNative = new WordEntry("butterfly",
                                new English.Noun("a", English.Numerus.Singular)),
                            WordForeign = new WordEntry("schmetterling",
                                new German.Noun("der", German.Numerus.Singular)),
                        },
                        new Translation {
                            LanguageNative = Language.English,
                            LanguageForeign = Language.German,
                            WordNative = new WordEntry("cup",
                                new English.Noun("a", English.Numerus.Singular)),
                            WordForeign = new WordEntry("tasse",
                                new German.Noun("die", German.Numerus.Singular)),
                        },
                        new Translation {
                            LanguageNative = Language.English,
                            LanguageForeign = Language.German,
                            WordNative = new WordEntry("honor",
                                new English.Noun("an", English.Numerus.Singular)),
                            WordForeign = new WordEntry("ehre",
                                new English.Noun("die", English.Numerus.Singular)),
                        },
                    }
                });
            VocabularySetList.Add(
                new VocabularySet()
                {
                    VocabularySetName = "New VocabularySet",
                    NativeLanguage = Language.English,
                    ForeignLanguage = Language.German,
                    Translations = new ObservableCollection<Translation> {
                        new Translation {
                            LanguageNative = Language.German,
                            LanguageForeign = Language.English,
                            WordNative = new WordEntry("schwimmen",
                                new German.Verb(
                                    German.Perspective.Infinite,
                                    German.Numerus.None,
                                    "schwimmen", "schwimmen", "schwamm", "geschwommen")),
                            WordForeign = new WordEntry("swim",
                                new English.Verb(
                                    English.Perspective.Infinite,
                                    English.Numerus.None,
                                    "swim", "swim", "swimming", "swam", "swum"))
                        },
                        new Translation {
                            LanguageNative = Language.German,
                            LanguageForeign = Language.English,
                            WordNative = new WordEntry("diskutieren",
                                new German.Verb(
                                    German.Perspective.Infinite,
                                    German.Numerus.None,
                                    "diskutieren", "diskutieren", "diskutierte", "diskutiert")),
                            WordForeign = new WordEntry("discuss",
                                new English.Verb(
                                    English.Perspective.Infinite,
                                    English.Numerus.None,
                                    "discuss", "discuss", "discussing", "discussed", "discussed"))
                        },
                        new Translation {
                            LanguageNative = Language.German,
                            LanguageForeign = Language.English,
                            WordNative = new WordEntry("versprechen",
                                new German.Verb(
                                    German.Perspective.Infinite,
                                    German.Numerus.None,
                                    "versprechen", "versprechen", "versprach", "versprochen")),
                            WordForeign = new WordEntry("promise",
                                new English.Verb(
                                    English.Perspective.Infinite,
                                    English.Numerus.None,
                                    "promise", "promise", "promising", "promised", "promised"))
                        }
                    }
                });

            //Rest of Constructor
        }

        [RelayCommand]
        private void VocabularySet_Add()
        {
            var set = new VocabularySet();
            if (VocabularySetList != null)
            {
                VocabularySetList.Add(set);
            }
        }

        [RelayCommand]
        private void VocabularySet_Remove()
        {

        }

        [RelayCommand]
        private void VocabularySet_Rename()
        {

        }

        [RelayCommand]
        private void VocabularySet_Options()
        {

        }

        [RelayCommand]
        private void VocabularySet_Upload()
        {

        }

        [RelayCommand]
        private void Translation_Add()
        {
            
        }

        [RelayCommand]
        private void Translation_Remove()
        {

        }


    }

    
}
