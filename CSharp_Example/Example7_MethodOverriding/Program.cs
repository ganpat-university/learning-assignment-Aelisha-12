using System;

namespace Example7_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 objDemo = new Class1();
            objDemo.DoSomthing();
            Console.WriteLine();

            AnotherClass2 objAnotherDemo = new AnotherClass2();
            objAnotherDemo.DoSomthing();
            Console.WriteLine();


            // Object of the Base Type, with behaviours coming from the Derived Type
            Class1 objDemo2 = new AnotherClass2();
            objDemo2.DoSomthing();
        }
    }
}
