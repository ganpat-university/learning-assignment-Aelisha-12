using System;

namespace Demo_Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
            Console.WriteLine("another world");

            Console.Write("Your name please: ");
            string name = Console.ReadLine();

            Console.Write("Your age please: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hi {0}. You are {1} years young!", name, age);

            Console.ReadLine();
        }
    }
}
