﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class Milk:ICondiment
    {
        public double _price = 20.00;

        public string Name()
        {
            return "Milk";
        }

        public double Price()
        {
            return _price;
        }
    }
}
