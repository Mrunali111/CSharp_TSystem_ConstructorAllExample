using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day1_14_03_2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Department dept=new Department();
            //Console.WriteLine(dept.GetData());

            //Department dept2 = new Department(2, "HR", "Pune");
            //Console.WriteLine(dept2.GetData());
            //Console.WriteLine(dept2.GetDeptId());

            //Student objstu = new Student();
            //Console.WriteLine(objstu.GetData());

            //Student objstu2 = new Student(11, "Atul");
            //Console.WriteLine(objstu2.GetData());

            Employee employee = new Employee(1, "Mrunali", 35000);
            employee.CalculateSalary();
            Console.WriteLine(employee);
            Console.ReadLine();

        }
    }
}
