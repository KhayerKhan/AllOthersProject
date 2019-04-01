using System;

namespace Fiter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Select your Fiter plane");
            Console.WriteLine("1 for B2");
            
            Console.WriteLine("2 for Mirage-5");
            Console.WriteLine("3 for F-16");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Select your primary wipon");
            Console.WriteLine("1 bomb");
            Console.WriteLine("2 for machine gun");
            Console.WriteLine("3 for missile");
            int n2 = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Selected  secondary wipon");
            Console.WriteLine("1 bomb");
            Console.WriteLine("2 for machine gun");
            Console.WriteLine("3 for missile");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Selected Fiter plane");
            Console.WriteLine("Selected  primary wipon");
            Console.WriteLine("Selected  secondary wipon");
            Console.WriteLine(" preparing for firing wipon: ");
            int n6 = int.Parse(Console.ReadLine());
            while (n6 !=3)
            {
                if (n6 == 1)
                {
                    Console.WriteLine("firing the primary wipon");
                    int n4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("exit for 3");
                    n6 = n4;
                    
                }
               else if (n6 == 2)
                {
                    Console.WriteLine("Firing firing the secodary wipon");
                    int n4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("exit for 3");
                    n6 = n4;
                   
                }
             
                    
               
                else
                {
                    Console.WriteLine("exit");
                    break;
                }

            }




        }
    }
}
