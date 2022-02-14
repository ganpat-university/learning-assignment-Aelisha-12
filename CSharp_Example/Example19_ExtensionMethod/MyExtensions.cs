using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example19_ExtensionMethod
{
    /// <summary>
    ///     An example of the Singleton Pattern.
    ///     Only one instance of the class will ever be loaded in the application (only one copy of code will exist)
    /// </summary>
    static class MyExtensions
    {
        // How to prepare an extension method:
        // 1. The class is a singleton.
        // 2. Ensure that the object to be extended is the FIRST PARAMETER.
        // 3. Ensure that the first parameter is decorated with the "this" keyword.
        public static int Multiply(this Calculator objCalc, int a, int b)
        {
            return a * b;
        }

        public static int Divide(this Calculator objCalc, int a, int b)
        {
            Console.WriteLine("Divide() in the extension method to the Calculator object executed successfully");
            return a / b;
        }

        public static void AuthorName(this object o)
        {
            Console.WriteLine("Manoj Kumar Sharma");
        }

    }
}
