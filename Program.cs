using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new HR_Developer();
            emp.DrawHR();

            HR_Developer hr_dev = new HR_Developer();
            hr_dev.DrawHR();

            Console.WriteLine("\nEnter the year(s) of experience of the HR : ");
            emp.ExperienceHR = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe Annual Salary of HR is:  " + hr_dev.CalculationHR());

            emp.DrawDev();
            hr_dev.DrawDev();
            Console.WriteLine("\nEnter the year(s) of experience of the Developer : ");
            emp.ExperienceDev = int.Parse(Console.ReadLine());
            Console.WriteLine("\n The Annual Salary of Developer is:  " + hr_dev.CalculationDev());
        }
    }
}
