using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7_MethodOverriding
{
    class AnotherClass2 : Class1
    {
        public override void DoSomthing()
        {
            Console.WriteLine("DoSomething() called successfully in AnotherClass2");
        }
    }
}
