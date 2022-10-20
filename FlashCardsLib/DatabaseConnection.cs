using System.Data.SqlClient;

namespace FlashCardsLib
{
    public class DatabaseConnection
    {
        static string connectionString =
            @"Data Source=212.87.212.70;Initial Catalog=FlashCards; User ID=FlashCards; Password=";

        public SqlConnection Connection { get; }

        public DatabaseConnection()
        {
            Connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            Connection.Open();
        }

        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
