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
            Worker worker = new Worker();
            worker.BirthDay = new DateTime(1999, 01, 11);

            Console.WriteLine(worker.Print());
            Console.ReadKey();
        }
    }
}
