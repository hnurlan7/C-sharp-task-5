using System;
using task_5._1.Moduls;

namespace task_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book kitab = new Book("Kitab", 65, 100, "Stefan Zweig", 178, 10);
            //Console.WriteLine(kitab.authorName);
            //kitab.AllAbout();

            Console.WriteLine(kitab.GetDiscountedPrice());


        }
    }
}
