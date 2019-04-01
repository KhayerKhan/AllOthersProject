using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //list<int> items = new list<int>();
            //while (true)
            //{
            //    var line = Console.ReadLine();
            //    if (line == null) break;

            //    var numbers = line.Split(' ');
            //    var x = Convert.ToInt32(numbers[0]);
            //    var y = Convert.ToInt32(numbers[1]);

            //    Console.WriteLine($"x: {x}\ny: {y}");
            //    Console.WriteLine("x: {0} \ny: {1}", x, y);

            // int n,adding=2018;
            //n = int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     string s = Console.ReadLine();
            //     var v = s.Split(' ');
            //     var k = Convert.ToString(v[0]);
            //    // int t = s.Length;
            //     //Console.WriteLine(t);
            //     for (int j = 12; j < k.Length; j++)
            //     {

            //         adding++;


            //     }
            //     Console.WriteLine($"Happy New Year-{adding}");

            //     adding = 2018;
            // }
            while (true)
            {
                
                string s = Console.ReadLine();
                var s1 = s.Split(' ');
                var s2 = Convert.ToString(s1[0]);
                if (s == null) break;
                if (s == "never")
                {
                    Console.WriteLine("YES");
                }
                else if (s == "ever")
                {
                    Console.WriteLine("NO");
                }

                else if (s == "so")
                {
                    Console.WriteLine("YES");
                }

                else if (s == "clever")
                {
                    Console.WriteLine("NO");

                }

                else if (s == "happy")
                {
                    Console.WriteLine("YES");

                }
                else if (s == "sad")
                {
                    Console.WriteLine("YES");

                }

                else Console.WriteLine("NO");

            }

            Console.ReadKey();


        }
    }
}
