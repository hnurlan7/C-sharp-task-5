using System;
using task_5.Moduls;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person("Nurlan", "Hamidov", 25);
            per1.PersonAbout();
            Student stu1 = new Student("Nurlan", "Hamidov", 25, 70);
            Console.WriteLine(stu1.average);
        }
    }
}
