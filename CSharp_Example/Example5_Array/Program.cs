using System;

namespace Example5_Array
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("---------------One Dimensional Array--------------");
                SingleDimensionalArray();
                Console.WriteLine();

                Console.WriteLine("---------------two dimensional  Array--------------");
                TwoDimensionalArray();
                Console.WriteLine();
            }

          

            // one dimensional array
            static void SingleDimensionalArray()
            {
                int[] arr;          // Declaration
                arr = new int[5];   // Instantiation
                arr[0] = 10;        // Initialization
                arr[1] = 20;
                arr[2] = 30;
                arr[3] = 40;
                arr[4] = 50;

                int[] arr2 = new int[5];
                int[] arr3 = new int[5] { 10, 20, 30, 40, 50 };
                int[] arr5 = { 10, 20, 30, 40, 50 };


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("===> Using the FOR Loop");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("===> Using the FOR EACH Loop");
                foreach (int i in arr)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }

        // two dimensional array
        static void TwoDimensionalArray()
        {
            int[,] arr;             // Declaration
            arr = new int[2, 3];    // Instantiation
            arr[0, 0] = 10;         // Initialization
            arr[0, 1] = 20;
            arr[0, 2] = 30;
            arr[1, 0] = 40;
            arr[1, 1] = 50;
            arr[1, 2] = 60;

            int[,] arr2 = new int[2, 3];
            int[,] arr3 = new int[2, 3]
            {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };
            int[,] arr4 = {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("======> Using the FOR LOOP");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }

           
            Console.WriteLine();
            Console.WriteLine("====>Using the FOR EACH LOOP");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }



    }
}
