﻿using System.Reflection;

namespace FlashCardsLib
{
    public static class AppConstants
    {
        public readonly static Language[] SupportedLanguages = DetermineSupportedLanguages();
        public readonly static IWordtype[] SupportedWordtypes = DetermineSupportedWordtypes();

        public readonly static string PrimaryDefaultLangauge = "English";
        public readonly static Language SecondaryDefaultLanguage = Language.German;

        private static void DetermineSupportedLanguagesInculdingOtherAssemblies()
        {
            // Assembly languageAssembly = typeof(ILanguage).Assembly;
            // potentially check ALL assemblies for language?
            // languageAssembly.GetTypes();
        }

        private static Language[] DetermineSupportedLanguages()
        {
            var allLanguageTypes = NonAbstractTypesImplementingInterface(typeof(ILanguage));
            List<Language> languageList = new List<Language>();

            foreach (Type langType in allLanguageTypes) {

            }

            var languages = languageList.ToArray();
            return languages;
        }

        private static IWordtype[] DetermineSupportedWordtypes()
        {
            var enumerable = (IEnumerable<IWordtype>)NonAbstractTypesImplementingInterface(typeof(IWordtype));
            return enumerable.ToArray();
        }

        public static IWordtype[] GetWordTypesOfLanguage(Language language)
        {
            List<IWordtype> matching = new List<IWordtype>();
            var alltypes = (IWordtype[])NonAbstractTypesImplementingInterface(typeof(IWordtype));
            foreach (IWordtype wordtype in alltypes)
            {
                if (wordtype.Language == language)
                    matching.Add(wordtype);
            }
            return matching.ToArray();
        }


        //Check if this conversion works!!
        public static Language DetermineLanguageEnumType(IWordtype type)
        {
            if (type.Typename == Enum.GetName(Language.English)) {
                return Language.English;
            }
            if (type.Typename == Enum.GetName(Language.German)) {
                return Language.German;
            }
            if (type.Typename == Enum.GetName(Language.Spanish)) {
                return Language.Spanish;
            }
            if (type.Typename == Enum.GetName(Language.French)) {
                return Language.French;
            }
            if (type.Typename == Enum.GetName(Language.Italian)) {
                return Language.Italian;
            }
            if (type.Typename == Enum.GetName(Language.Japanese)) {
                return Language.Japanese;
            }
            else
            {
                throw new NotImplementedException();
            }
        }


        public static bool DoesTypeSupportInterface(Type type, Type @interface)
        {
            if (@interface.IsAssignableFrom(type))
                return true;
            if (type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == @interface))
                return true;
            return false;
        }

        public static IEnumerable<Assembly> GetReferencingAssemblies(Assembly assembly)
        {
            return AppDomain
                .CurrentDomain
                .GetAssemblies().Where(asm => asm.GetReferencedAssemblies()
                .Any(asmName => AssemblyName.ReferenceMatchesDefinition(asmName, assembly.GetName())));
        }

        public static IEnumerable<Type> TypesImplementingInterface(Type desiredType)
        {
            var assembliesToSearch = new Assembly[] { desiredType.Assembly }
                .Concat(GetReferencingAssemblies(desiredType.Assembly));
            return assembliesToSearch.SelectMany(assembly => assembly.GetTypes())
                .Where(type => DoesTypeSupportInterface(type, desiredType));
        }

        public static IEnumerable<Type> NonAbstractTypesImplementingInterface(Type interfaceType)
        {
            return TypesImplementingInterface(interfaceType).Where(t => !t.IsAbstract);
        }
    }
}