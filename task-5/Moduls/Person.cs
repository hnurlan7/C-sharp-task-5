using System;
using System.Collections.Generic;
using System.Text;

namespace task_5.Moduls
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public void PersonAbout()
        {
            Console.WriteLine($"Ad: {name} Soyad: {surname} Yas: {age}");
        }
    }
}
