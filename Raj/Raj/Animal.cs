using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raj
{
    public class Animal
    {
        public void WhatIeat()
        {
            Console.WriteLine("I eat grass");
        }
        public void WhatIeat(string food)
        {
            Console.WriteLine("I eat "+food);
        }
    }
}
