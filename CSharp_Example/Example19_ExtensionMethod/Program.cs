using System;

namespace Example19_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;

            result = objCalc.Add(10, 20);
            Console.WriteLine("Sum of 10 and 20 = {0}", result);
            Console.WriteLine();

            Console.WriteLine("--- Calling the method directly from the Static Singleton class");
            result = MyExtensions.Multiply(objCalc, 20, 30);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            Console.WriteLine("---- Calling using the Extension Method");
            result = objCalc.Multiply(20, 30);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            result = objCalc.Divide(10, 2);
            Console.WriteLine("Result = {0}", result);

            int i = 10;
            i.AuthorName();

        }
    }
}
