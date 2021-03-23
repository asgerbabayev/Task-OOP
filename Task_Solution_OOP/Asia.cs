using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class Asia : Materic
    {
        public override double GetPeoplePerKm()
        {
            return Influence / Area + 2;
        }
    }
}
