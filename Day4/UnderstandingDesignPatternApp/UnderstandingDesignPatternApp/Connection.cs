using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public sealed class Connection
    {
        private static Connection instance = null;
        public string name = "";
        private Connection()
        {
        }
        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }
        }
    }
}
