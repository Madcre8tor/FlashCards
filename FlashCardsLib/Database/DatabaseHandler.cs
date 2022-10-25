using System.Data.SqlClient;

namespace FlashCardsLib.Database
{
    public class DatabaseHandler
    {
        static readonly string connectionString =
            new SqlConnectionStringBuilder()
            {
                DataSource = Environment.GetEnvironmentVariable("FLASHCARDS_HOST", EnvironmentVariableTarget.User),
                InitialCatalog = Environment.GetEnvironmentVariable("FLASHCARDS_DATABASE", EnvironmentVariableTarget.User),
                UserID = Environment.GetEnvironmentVariable("FLASHCARDS_USER", EnvironmentVariableTarget.User),
                Password = Environment.GetEnvironmentVariable("FLASHCARDS_PASSWORD", EnvironmentVariableTarget.User)
            }.ConnectionString;

        public SqlConnection Connection { get; }

        public DatabaseHandler()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
