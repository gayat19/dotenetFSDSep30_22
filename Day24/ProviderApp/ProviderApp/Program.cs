using System;
using Microsoft.Azure.ServiceBus;
using System.Text;

namespace ProviderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://samplebusg3.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=ucYs5Ff/UN1hPQaw9WNkbbNMflK43SKcQqcYXClCAY0=";
            var queueName = "messenger";

            var client = new QueueClient(connectionString, queueName);
            Console.WriteLine("Enter you message");
            string userMessage = Console.ReadLine();

            client.SendAsync(new Message(UTF8Encoding.Unicode.GetBytes(userMessage)));

            Console.WriteLine("Message sent!");
            Console.ReadKey();
        }
    }
}
