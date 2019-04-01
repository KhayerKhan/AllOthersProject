using System;
using System.Text;

namespace ProblemPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            n = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0; i<n; i++)
            {



                 int  velocity = Convert.ToInt32(Console.ReadLine());
                 int  second = Convert.ToInt32(Console.ReadLine());

              
                float  result =-((float)velocity / (float)second);
                Console.WriteLine("{0:N2}", result);

                // Console.WriteLine(result);
                //Console.WriteLine(result.ToString("F"));



                //Math.Round(result, 2);
                //double k = 2.3456;

                // int a = 1, b = 2;
                // float re = (float)a /(float) b;
                //Console.WriteLine(re);
                // //Console.WriteLine(re.GetType().ToString());

                //  Console.WriteLine(re.ToString("F"));

                //Console.WriteLine(Math.Round(result, 2));
                // Console.WriteLine(k.ToString("#.##"));
                // Console.WriteLine(string.Format("{0:0.00}", k));


            }
            Console.ReadKey();
        }
    }
}
