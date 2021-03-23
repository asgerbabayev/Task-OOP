using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class Europe : Materic
    {
        public override double GetPeoplePerKm()
        {
            return Area / Influence - 4;
        }
    }
}
