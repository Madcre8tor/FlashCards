using Newtonsoft.Json;
using System.Data.SqlClient;

namespace FlashCardsLib.Database
{
    public class DatabaseHandler
    {
        static readonly string connectionString;

        static DatabaseHandler()
        {
            string jsonString = File.ReadAllText("database.json");
            DatabaseInfo? dbInfo = JsonConvert.DeserializeObject<DatabaseInfo>(jsonString);

            if (dbInfo == null) throw new NullReferenceException("Could not deserialize database.json file");

            connectionString = $"Data Source={dbInfo.Host};Initial Catalog={dbInfo.Database}; User ID={dbInfo.User}; Password={dbInfo.Password}";
        }

        public SqlConnection Connection { get; }

        public DatabaseHandler()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
