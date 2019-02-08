using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary
{
    public class HR_Developer : Employee
    {
        public override void DrawHR()
        {
            Id = 1;
            Name = "Ms. Olivia Gomez";
            Designation = "HR";
            BasicSalary = 8000;
            JoiningDate = 07 / 01 / 2019;   
        }
        public override int CalculationHR()
        {
            return AnnualSalary = BasicSalary + 1000 * ExperienceHR;
        }
        public override void DrawDev()
        {
            Id = 5;
            Name = "Mr. Twuan Manuk";
            Designation = "Developer";
            BasicSalary = 8000;
            JoiningDate = 01 / 01 / 2017;
        }
        public override int CalculationDev()
        {
            return AnnualSalary = BasicSalary + (2000 * this.ExperienceDev);
        }
    }
}
