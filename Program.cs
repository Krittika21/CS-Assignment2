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
           
            HR_Developer hr_dev = new HR_Developer();

            int h = emp.ExperienceHR;
            int d = emp.ExperienceDev;

            Console.WriteLine("\nEnter the year(s) of experience of the HR : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nHR have 8000/-RS as basic salary and have {h} year(s) of experience.\n Therefore the Annual Salary of HR is:  " + hr_dev.CalculationHR(h));

            emp.DrawDev();
            hr_dev.DrawDev();
            Console.WriteLine("\nEnter the year(s) of experience of the Developer : ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nDeveloper have 8000/-RS as basic salary and have {d} year(s) of experience.\n Therefore the Annual Salary of Developer is:  " + hr_dev.CalculationDev(d));

            emp.DrawHR();
            hr_dev.DrawHR();
        }
    }
}
