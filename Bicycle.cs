﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{    
    public class Bicycle: Car
    {
        public override string Run() 
        {
            return "時速可達30公里";
        }
    }
}
