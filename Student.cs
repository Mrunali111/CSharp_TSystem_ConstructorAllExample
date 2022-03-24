using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day1_14_03_2022_
{
    internal class Student
    {
        private int id;
        private string name;


        public Student()
        {
            Console.WriteLine("=========================");
            id = 1;
            name = "Mrunali";
        }

        public Student(int sid, string sname)
        {
            Console.WriteLine("=========================");
            id = sid;
            name = sname;
        }

        public string GetData()
        {
            return "Student ID : " + id + "\nStudent Name : " + name;
        }

    }
}