using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IBook> tickets = new List<IBook>();
            tickets.Add(new PremiumTicket());
            tickets.Add(new Ticket());
            foreach (var booking in tickets)
            {
                booking.PrintTicket();
            }
            Console.ReadKey();
        }
    }
}
