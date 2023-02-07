using System.Net;

namespace FlashCardsClient
{
    internal class Program
    {
        private static readonly string defaultIPString = "108.143.200.32";
        private static readonly int defaultPort = 5000;

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the IP-Address to connect to");
            Console.WriteLine("Or press Enter with no input to default to IP-Address of VM Server: ");
            string ipString = Console.ReadLine();
            if (string.IsNullOrEmpty(ipString)) {
                ipString = defaultIPString;
            }
            IPAddress ipAddress = IPAddress.Parse(ipString);

            Console.WriteLine("defaultPort is 5000");
            var ipEndPoint = new IPEndPoint(ipAddress, 5000);



        }
    }
}