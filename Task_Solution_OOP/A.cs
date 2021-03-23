using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class A
    {
        public string name { get; set; }

        public int a { get; set; }

        public int b { get; set; }

        public int Sum()
        {
            return a + b;
        }

        public string Print()
        {
            return name;
        }
    }
}
