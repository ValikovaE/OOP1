using System;

namespace C_Sharp_Lesson_4._1___OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.name = "John";
            worker1.age = 25;
            worker1.salary = 1000;
            Worker worker2 = new Worker();
            worker2.name = "John";
            worker2.age = 26;
            worker2.salary = 2000;
            Console.WriteLine("The sum of John's and Sam's salaries: " + (worker1.salary + worker2.salary));
            Console.WriteLine("The sum of John's and Sam's ages: " + (worker1.age + worker2.age));
        }
    }
}
