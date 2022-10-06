using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    internal class DematAccount :Account
    {
        public override void OpenAccount()
        {
            Console.WriteLine("Open account with min balance of 10000 and can do trading");
        }
    }
}
