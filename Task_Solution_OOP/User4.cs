using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class User4
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Score { get; set; }

        public int Age { get; set; }

        public bool isAdmin { get; set; }

        public int getScore()
        {
            if (isAdmin == false)
            {
                return Score;
            }
            return 2 * Score;
        }
    }
}
