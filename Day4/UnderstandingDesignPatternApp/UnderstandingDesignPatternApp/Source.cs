using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public class Source
    {
        IAdapter adapter;
        public Source()
        {
            adapter = new Adapter();
        }
        public void MakeCall()
        {
            adapter.CallTarget();
        }
    }
}
