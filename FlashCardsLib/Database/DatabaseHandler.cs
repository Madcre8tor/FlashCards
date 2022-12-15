using System.Data.SqlClient;

namespace FlashCardsLib.Database
{
    public class DatabaseHandler
    {
        static readonly string connectionString = 
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FlashWordsDB;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;
            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";

        public SqlConnection Connection { get; }

        public DatabaseHandler()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}
