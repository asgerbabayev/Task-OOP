using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class C1 : A1
    {
        public override string Print(string a, string b)
        {
            return base.Print(a, b);
        }

        public override int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }

        public override double Section(double a, double b)
        {
            return base.Section(a, b);
        }
    }
}
