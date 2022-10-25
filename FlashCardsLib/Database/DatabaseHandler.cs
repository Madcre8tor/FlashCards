using System.Data.SqlClient;

namespace FlashCardsLib.Database
{
    public class DatabaseHandler
    {
        static readonly string connectionString =
            @$"Data Source={Environment.GetEnvironmentVariable("FLASHCARDS_HOST", EnvironmentVariableTarget.User)};
            Initial Catalog={Environment.GetEnvironmentVariable("FLASHCARDS_DATABASE", EnvironmentVariableTarget.User)};
            User ID={Environment.GetEnvironmentVariable("FLASHCARDS_USER", EnvironmentVariableTarget.User)};
            Password={Environment.GetEnvironmentVariable("FLASHCARDS_PASSWORD", EnvironmentVariableTarget.User)}";

        public SqlConnection Connection { get; }

        public DatabaseHandler()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
