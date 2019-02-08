using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary
{
    public class HR_Developer : Employee
    {
        //HR
        public override void DrawHR()
        {
            Id = 1;
            Name = "Ms. Olivia Gomez";
            Designation = "HR";
            BasicSalary = 8000;
            JoiningDate = 07 / 01 / 2019;   
        }
        public override int CalculationHR(int val)
        {
            return AnnualSalary = 8000 + 1000 * val;
        }

        //Developer
        public override void DrawDev()
        {
            Id = 5;
            Name = "Mr. Twuan Manuk";
            Designation = "Developer";
            BasicSalary = 8000;
            JoiningDate = 01 / 01 / 2017;
        }
        public override int CalculationDev(int value)
        {
            return AnnualSalary = 8000 + 2000 * value;
        }
    }
}
