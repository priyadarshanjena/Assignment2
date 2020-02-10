using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();

            Developer dev = new Developer();



            Console.WriteLine("Salary of Hr is " + hr.CalculateSalary());

            Console.WriteLine("Salary of Developer is " + dev.CalculateSalary());



            Console.ReadKey();
        }
    }
}
