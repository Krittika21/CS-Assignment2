using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary
{
    public abstract class Employee
    {
        public abstract void DrawHR();
        public abstract int CalculationHR();

        public abstract void DrawDev();
        public abstract int CalculationDev();

        protected int Id { get; set; }
        protected int BasicSalary { get; set; } 
        protected string Name { get; set; }
        protected string Designation { get; set; }
        protected int AnnualSalary { get; set; }
        protected int JoiningDate { get; set; }

        public int ExperienceHR { get; set; }
        public int ExperienceDev { get; set; }
        
    }

}
