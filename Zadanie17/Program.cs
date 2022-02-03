using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> employee1 = new Employee<int>();
            employee1.Input();
            Console.WriteLine(employee1.GetInfo());

            Employee<string> employee2 = new Employee<string>();
            employee2.Input();
            Console.WriteLine(employee2.GetInfo());

            Console.ReadKey();
        }
    }
}