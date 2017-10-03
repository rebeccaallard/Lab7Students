using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Students
{
    class Student
    {
        string name;
        int number;
        string hometown;
        string food;

        public Student(string n, int nbr, string ht, string f)
        {
            name = n;
            number = nbr;
            hometown = ht;
            food = f;
        }
        public int GetStudentNumber()
        {
            return number;
        }
        public string GetStudentName()
        {
            return name;
        }
        public string GetStudentHometown()
        {
            return hometown;
        }
        public string GetStudentFood()
        {
            return food;
        }
    }
}
