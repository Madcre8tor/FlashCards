using FlashCardsLib.Database;
using System.Data;

namespace FlashCardsLibXUnitTests
{
    public class DatabaseTests
    {
        [Fact]
        public void ConnectToDatabase()
        {
            DatabaseHandler handler = new DatabaseHandler();
            handler.Connection.Open();

            Assert.Equal(ConnectionState.Open, handler.Connection.State);

            handler.Connection.Close();
        }
    }
}
