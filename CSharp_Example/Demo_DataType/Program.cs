using System;

namespace Demo_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool b = true;
            string s = "hello world";
            char c = 'A';
            float f = 23.45f;
            double d = 23.45; // we can also write as 23.45d

            Console.WriteLine("float={0} and double={1}",f,d);
            int j = int.MaxValue;
            i = j + 1;

            long l = j;                 // implicit type-casting convert int value to long.

            l = long.MaxValue;
            // j = l;
            j = (int)l;                 // explicit type-casting convert long value to int

            Console.WriteLine("l (long) = {0}, j (int) = {1}", l, j);
        }
    }
}
