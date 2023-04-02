using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raj
{
    
        public class Animal
        {
            public void WhatIEat()
            {
                Console.WriteLine("I eat grass");
            }
            public void WhatIEat(string food)
            {
                Console.WriteLine("I eat " + food);
            }
            public void WhatIEat(string food, string food2)
            {
                Console.WriteLine("I eat " + food + " and " + food2);
            }
        }
    
}
