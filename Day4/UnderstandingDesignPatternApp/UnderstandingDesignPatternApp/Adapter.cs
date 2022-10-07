﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingDesignPatternApp
{
    public class Adapter : Target, IAdapter   
    {
        public void CallTarget()
        {
            FromTarget();
        }
    }
}