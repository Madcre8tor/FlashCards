using MySql.Data.MySqlClient;

namespace FlashCardsLib.Database
{
    public class DatabaseHandler
    {
        static readonly string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}",
            Environment.GetEnvironmentVariable("FLASHCARDS_HOST", EnvironmentVariableTarget.User),
            Environment.GetEnvironmentVariable("FLASHCARDS_DATABASE", EnvironmentVariableTarget.User),
            Environment.GetEnvironmentVariable("FLASHCARDS_USER", EnvironmentVariableTarget.User),
            Environment.GetEnvironmentVariable("FLASHCARDS_PASSWORD", EnvironmentVariableTarget.User));

        public MySqlConnection Connection { get; }

        public DatabaseHandler()
        {
            Connection = new MySqlConnection(connectionString);
        }
    }
}
