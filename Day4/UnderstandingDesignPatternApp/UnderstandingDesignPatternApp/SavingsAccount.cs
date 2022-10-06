using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public class SavingsAccount:Account
    {
        public override void OpenAccount()
        {
            Console.WriteLine("Open account with min balance of 5000 and has a debit card");
        }
    }
}
