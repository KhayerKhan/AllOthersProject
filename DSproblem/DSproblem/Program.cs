using System;

namespace DSproblem
{
    class Program
    {
        static void Main(string[] args)
        {



            int n;
            string n1;
            n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                n1 = Console.ReadLine();
                var k = n1.Split(' ');
                var v = Convert.ToString(k[0]);
                if (v == "ac") { Console.WriteLine("Accepted"); }
                else if (v == "wa")
                {
                    Console.WriteLine("Wrong Answer");
                }
                else if(v== "rte")
                {
                    Console.WriteLine("Run Time Error");

                }
                else if(v== "tle")
                {

                    Console.WriteLine("Time Limit Exceeded");
                }
            }
           // Console.WriteLine(n);




            //int n1 = 1;
            //while (n1 < 20)
            //{



            //    int  n;
            //    n = int.Parse(Console.ReadLine());
            //    n = n * n;
            //    Console.WriteLine(n);
            //    n1++;
            //}
        }
    }
}
