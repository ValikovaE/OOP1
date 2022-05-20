using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_4._1___OOP
{
    class Worker_
    {
        private string name;
        private int age;
        private int salary;

        public Worker_(string Name, int Age, int Salary)
        {
        }

        public string Name //myObj.Name
        {
            get { return name; }
            set { name = Name; }
        }
        public int Age
        {
            get { return age; }
            set { age = Age; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = Salary; }
        }
    }
}
