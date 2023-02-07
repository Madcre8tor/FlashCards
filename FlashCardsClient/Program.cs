using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FlashCardsClient
{
    internal class Program
    {
        private static readonly string defaultIPString = "108.143.200.32";
        private static readonly int defaultPort = 5000;

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the IP-Address to connect to");
            Console.WriteLine("Or press Enter with no input to use default IP-Address of VM Server: ");
            string ipString = Console.ReadLine();
            if (string.IsNullOrEmpty(ipString)) {
                ipString = defaultIPString;
            }
            IPAddress ipAddress = IPAddress.Parse(ipString);

            Console.WriteLine("defaultPort is 5000");
            IPEndPoint ipEndPoint = new(ipAddress, defaultPort);

            Console.WriteLine("Establishing connection...");

            using TcpClient client = new();
            await client.ConnectAsync(ipEndPoint);
            await using NetworkStream stream = client.GetStream();

            var buffer = new byte[1_024];
            int received = await stream.ReadAsync(buffer);

            var message = Encoding.UTF8.GetString(buffer, 0, received);
            Console.WriteLine($"Message received: \"{message}\"");



        }
    }
}