using Assignment2;
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
        Employee emp = new HR();
        Employee emp1 = new Developer();

        Console.WriteLine("HR Salary :" + emp.CalculateSalary());
        Console.WriteLine("Developer salary :"+ emp1.CalculateSalary());

        Console.ReadKey();
        }
    }
}
