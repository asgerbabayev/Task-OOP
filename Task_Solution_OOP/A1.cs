using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class A1
    {
        public virtual string Print(string a, string b)
        {
            return a + b;
        }

        public virtual int Sum(int a, int b)
        {
            return a + b;
        }

        public virtual double Section(double a, double b)
        {
            return a / b;
        }
    }
}
