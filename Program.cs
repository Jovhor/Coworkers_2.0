using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworkers_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.ID = 15;
            worker1.FIO = "Зубенко Михаил Петрович";
            worker1.Age = 20;
            worker1.Height = 190;
            worker1.BirthDay = "11.02.1999";
            worker1.PlaceOfBirth = "мамка твоя";


            Console.WriteLine(worker1.Print());
            Console.ReadKey();
        }
    }
}
