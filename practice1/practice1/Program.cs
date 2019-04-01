using System;
using System.Collections.Generic;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i=0; i<10; i++)
            {


                numbers.Add(int.Parse(Console.ReadLine()));



            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(numbers[j]);

            }
                //int testCase;
                //testCase = Int32.Parse(Console.ReadLine());
                //for(int i=0; i<testCase; i++)
                //{
                //string phrase = "The quick brown fox jumps over the lazy dog.";
                //string[] words = phrase.Split(' ');

                //foreach (var word in words)
                //{
                //    System.Console.WriteLine($"<{word}>");
                //}


                //string phrase = "The quick brown    fox     jumps over the lazy dog.";
                //string[] words = phrase.Split(' ');

                //foreach (var word in words)
                //{
                //    System.Console.WriteLine($"<{word}>");
                //}

                ////}



                Console.ReadKey();
        }
    }
}
