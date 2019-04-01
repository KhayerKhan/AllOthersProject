using System;

namespace MVA1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myvalue = DateTime.Now;
            //Console.WriteLine(myvalue.ToString());
           // Console.WriteLine(myvalue.ToLongDateString());
            Console.WriteLine(myvalue.AddDays(3).ToString());
            Console.ReadLine();
        }
    }
}
