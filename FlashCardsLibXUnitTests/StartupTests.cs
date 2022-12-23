namespace FlashCardsLibXUnitTests
{
    public class StartupTests
    {
        [Fact]
        public void LoadAllAssemblies()
        {
            var lang = AppConstants.SUPPORTED_LANGUAGES;
            Assert.Equal(6, lang.Length);
        }

        [Fact]
        public void LoadAllTypesImplementingIWordtype()
        {

        }

        [Fact]
        public void LoadAllTypesImplementingILanguage()
        {

        }








        [Fact]
        public void CheckRightPairComparison()
        {

        }

        [Fact]
        public void TestLoadLanguageLibs()
        {
            //Language language = new Language("test", "test");

            //language.LoadLanguageLibs();


        }
    }
}