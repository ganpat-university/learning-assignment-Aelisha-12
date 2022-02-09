using System;

namespace Assignment_1
{
    public class program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.Write("Enter your name:");
            obj.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your age :");
            obj.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("hii {0} , your age is {1}", obj.Name, obj.Age);
            


        }
    }
}
