using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example7_MethodOverriding
{
    //parent Class or base class
    class Class1
    {
        virtual public void DoSomthing()
        {
            Console.WriteLine("DoSomething() in Class1 called successfully!");
        }
    }
}
