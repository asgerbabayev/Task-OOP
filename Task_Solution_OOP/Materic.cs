using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class Materic
    {
        public double Influence { get; set; }

        public double Area { get; set; }

        public virtual double GetPeoplePerKm()
        {
            return Area / Influence;
        }
    }
}
