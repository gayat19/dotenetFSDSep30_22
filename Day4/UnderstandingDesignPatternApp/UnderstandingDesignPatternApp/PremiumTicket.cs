using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public class PremiumTicket : IBook
    {
        public void PrintTicket()
        {
            Console.WriteLine("Ticket with food and transfer");
        }
    }
}
