using System;

namespace GenericPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            string c = "khayer";
            Swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");
            Console.ReadLine();

        }



        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
       
    }

   
}
