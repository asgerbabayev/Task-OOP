using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class B : A
    {
        public int c { get; set; }

        public int d { get; set; }

        public int Multiply()
        {
            return c * d;
        }

        public double Section()
        {
            return c / d;
        }
    }
}
