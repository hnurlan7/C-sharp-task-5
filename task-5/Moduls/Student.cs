using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Moduls
{
    internal class Student:Person
    {
        public double average;

        public Student(string name, string surname, int age, int average):base(name, surname, age)
        {
            this.average = average;
        }
    }
}
