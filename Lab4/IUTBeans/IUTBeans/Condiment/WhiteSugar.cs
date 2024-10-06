using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class WhiteSugar:ICondiment

    {
        public double _price = 15.00;

        public string Name()
        {
            return "White Sugar";
        }

        public double Price()
        {
            return _price;
        }
    }
}
