using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example19_ExtensionMethod
{
    /// <remarks>
    ///     "sealed" classes cannot be inherited.
    ///     "static" classes cannot be instantiated.
    /// </remarks>
    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
         
        // The Extension version of this method would execute only if Divide() does not exist in the Class.
        public int Divide(int a, int b)
        {
            Console.WriteLine("Divide() in the Calculator Class executed successfully");
            return a / b;
        }

    }
}
