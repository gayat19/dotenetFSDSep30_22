using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public class Ticket : IBook
    {
        public void PrintTicket()
        {
            Console.WriteLine("Normal Ticket");
        }
    }
}
