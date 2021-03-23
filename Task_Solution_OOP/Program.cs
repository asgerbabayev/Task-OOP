
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Solution_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region User classı yaradın və 3 field əlavə edin. Feldlərə dəyər set edin. Bunun üçün object initilazier istifadə edin.
            //User1 user1 = new User1()
            //{
            //    Username = "name",
            //    Email = "email",
            //    Password = "password"
            //};
            #endregion

            #region User classı yaradın və 3 property əlavə edin. Daha sonra constructorda propertylərə dəyər set edin.
            //User2 user2 = new User2();
            //Console.WriteLine(user2.Username);
            //Console.WriteLine(user2.Email);
            //Console.WriteLine(user2.Password);
            #endregion

            #region User classı yaradın və daxilində Username və password fieldləri olsun. Default olaraq username “testuser”, password isə “12345” təyin edilsin.
            //User3 user3 = new User3();
            //Console.Write("Enter username: ");
            //string username = Console.ReadLine();
            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();
            //if (username == user3.Username && password == user3.Password)
            //{
            //    Console.WriteLine("Logged in.");
            //}
            //else if (username != user3.Username && password != user3.Password)
            //{
            //    Console.WriteLine("Username and password is incorrect");
            //}
            //else if (username != user3.Username)
            //{
            //    Console.WriteLine("Username is incorrect");
            //}
            //else if (password != user3.Password)
            //{
            //    Console.WriteLine("Password is incorrect");
            //}

            #endregion

            #region User classı yaradın və name, surname, Score(int), age, isAdmin(bool) propertylərini təyin edin.  Class daxilində getScore adlı metod yaradın.
            //User4 user4 = new User4();
            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();
            //user4.Name = name;
            //Console.Write("Enter surname: ");
            //string surname = Console.ReadLine();
            //user4.Surname = surname;
            //Console.Write("Enter score: ");
            //int score = Convert.ToInt32(Console.ReadLine());
            //user4.Score = score;
            //Console.Write("Enter age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //user4.Age = age;
            //Console.Write("Admin. Enter true or false: ");
            //bool isadmin = Convert.ToBoolean(Console.ReadLine());
            //user4.isAdmin = isadmin;
            //Console.WriteLine(user4.getScore());
            #endregion

            #region A və B classları yaradın. B classı A classını extend etsin və sırf B classına aid 2 property və 2 metod yazın.
            //B classB = new B()
            //{
            //    name = "name",
            //    a = 2,
            //    b = 5,
            //    c = 10,
            //    d = 5
            //};
            //Console.WriteLine(classB.Sum());
            //Console.WriteLine(classB.Multiply());
            //Console.WriteLine(classB.Section());
            //Console.WriteLine(classB.Print());
            #endregion

            #region User classı yaradın və name, surname, age və isAdmin propertyləri əlavə edin.isAdmin true isə admin user created, false isə user created yazılsın.
            //Console.Write("Enter the name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter the surname: ");
            //string surname = Console.ReadLine();
            //Console.Write("Enter the age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter true if admin, false if not admin: ");
            //bool admin = Convert.ToBoolean(Console.ReadLine());
            //User5 user5 = new User5()
            //{
            //    Name = name,
            //    Surname = surname,
            //    Age = age,
            //    isAdmin = admin

            //};
            //if (admin == true)
            //{
            //    Console.WriteLine("Admin user created.");
            //}
            //else
            //{
            //    Console.WriteLine("User created");
            //}
            #endregion

            #region Class yaradın və daxilində 2 getUsers adlı metod olsun.
            //GetUserClass user = new GetUserClass();
            //foreach (var item in user.GetUsers())
            //{
            //    Console.WriteLine(item);
            //}
            //List<string> lst = new List<string>();
            //foreach (var item1 in user.GetUsers(lst))
            //{
            //    Console.WriteLine(item1);
            //}
            #endregion

            #region A1, B1 və C1 classları yaradın. A classı daxilində 3 fərqli return type-lı metod yazın.
            //B1 b1 = new B1();
            //C1 c1 = new C1();
            //b1.Print("", "");
            //b1.Sum(5, 4);
            //b1.Section(10, 2);
            //c1.Print("", "");
            //c1.Sum(4, 8);
            //c1.Section(15, 3);
            #endregion

            #region Abstract class yaradın və daxilində string return edən abstract method və 2 ədədi toplayıb geriyə dəyər qaytaran adi metod yazın.
            //GetAbstractClass abs = new GetAbstractClass();
            //Console.WriteLine(abs.GetType());
            //Console.WriteLine(abs.Sum());
            #endregion

            #region Materik adlı class yaradın və daxilində əhali sayı və ərazisini set edə bilmək üçün 2 property olsun.
            //Europe europe = new Europe()
            //{
            //    Influence = 743.000000,
            //    Area = 10.180000
            //};
            //Asia asia = new Asia()
            //{
            //    Influence = 3.879000000,
            //    Area = 44.580000
            //};
            //Console.WriteLine(europe.GetPeoplePerKm());
            //Console.WriteLine(asia.GetPeoplePerKm());
            #endregion

            Console.ReadKey();
        }
    }
}
