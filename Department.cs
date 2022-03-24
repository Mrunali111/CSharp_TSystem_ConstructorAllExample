using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day1_14_03_2022_
{
    internal class Department
    {
        private int id;
        private string name, location;


        public Department()
        {
            Console.WriteLine("==========Non Parameterized Constructor============");
            id = 1;
            name = "Admin";
            location = "Pune";

        }
        //public void AssignData()
        //{
        //    id = 1;
        //    name = "Admin";
        //    location = "Pune";
        //}

        public Department(int did, string dname, string loca)
        {
            Console.WriteLine("=================Parameterized Constructor============");
            id = did;
            name = dname;
            location = loca;

        }

        public int GetDeptId()
        {
            Console.WriteLine("=========ID==========");
            return id;
        }

        public string GetData()
        {
            return ("Department Id: " + id + "\nDepartment Name: " + name + "\nlocation: " + location);
        }
    }
}
