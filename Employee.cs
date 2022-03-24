using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day1_14_03_2022_
{
    public class Employee
    {
        private int empID;
        private string empName;
        private double empSalary, hra, da, pf, grosssalary;


        public Employee()
        {
            empID = 0;
            empName = "";
            empSalary = 0.00;
        }

        public Employee(int empID, string empName, double empSalary)
        {
            this.empID = empID;
            this.empName = empName;
            this.empSalary = empSalary;
        }

        public override string ToString()
        {
            return "Employee ID : " + empID + "\nEmployee Name : " + empName + "\nEmployee Salary : " + grosssalary;
        }

        public void CalculateSalary()
        {
            hra = empSalary * 0.40;
            da = empSalary * 0.20;
            pf = empSalary * 0.30;
            grosssalary = (hra + da + empSalary) - pf;
        }

    }
}
