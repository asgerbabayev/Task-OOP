using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class GetUserClass
    {
        public List<string> GetUsers()
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            return list;
        }

        public List<string> GetUsers(List<string> list1)
        {
            list1.Add("D");
            return list1;
        }
    }
}
