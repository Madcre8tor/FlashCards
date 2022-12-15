namespace FlashCardsLib
{
    public class LanguageProfile
    {
        public readonly string LanguageLibPath = "LanguageLib";

        // Currently loaded LanguageLibraries. Any folder in LanguageLib directory is considered a LanguageLibrary
        public readonly List<LanguageLibrary> LanguageLibs = new List<LanguageLibrary>();
        public string Native { get; }
        public string Learning { get; }

        public LanguageProfile(string native, string learning)
        {

            Native = native;
            Learning = learning;
        }

        private List<string> ReadLanguageLibDirectory()
        {
            string[] libPaths = Directory.GetDirectories(LanguageLibPath);

            List<DirectoryInfo> dirinfos = new List<DirectoryInfo>();
            Array.ForEach(libPaths, x => dirinfos.Add(new DirectoryInfo(x)));

            List<string> languageLibs = new List<string>();
            dirinfos.ForEach(x => languageLibs.Add(x.Name));

            return languageLibs;
        }

        public void LoadLanguageLibs()
        {
            List<string> libs = ReadLanguageLibDirectory();
            libs.ForEach(x => new LanguageLibrary("blabla"));




        }

    }

}

