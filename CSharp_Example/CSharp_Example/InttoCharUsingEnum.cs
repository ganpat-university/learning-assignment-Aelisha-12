using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example
{
     class InttoCharUsingEnum
    {
        public static void  Main(String[] args)
        {
            int rem, rev=0,r;
            Console.WriteLine("Enter Number want to be in words");
            int x=int.Parse(Console.ReadLine());

            
            while (x> 0)
            {
                rem= x % 10;
                rev = rev * 10 + rem;
                x = x / 10;
            }
            x = rev;

            while(x> 0)
            {
                r=x% 10;
                MyEnum myEnum = (MyEnum)r;
                x = x / 10;
                Console.Write(myEnum +" ");

            }
            

        } 
    }
    enum MyEnum
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine

    }
}
