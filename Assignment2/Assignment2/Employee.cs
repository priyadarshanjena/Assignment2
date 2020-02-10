using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
     public abstract class Employee
    {
        public int EmpId;
        public string EmpName;
        public string Designation;
        public int Experience;
        public double AnnualSalary;
        public DateTime JoiningDate;

        public abstract double CalculateSalary();
    }

    public class HR : Employee
    {
        double hrBasicsalary;


        public override double CalculateSalary()
        {
            double hrBasicsalary = 8000;
            this.Experience= 4;
            return hrBasicsalary +( 1000 *Experience );
        }


    }
    public class Developer : Employee
    {
        double devBasicsalary;

        public override double CalculateSalary()
        {


            double devBasicsalary = 8000;
            this.Experience = 5;
            return devBasicsalary +(2000 * Experience);

        }


    }
}
