using System;

namespace MicrosoftVirtualAcamedy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your first name: ");
            string Firstname = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string Lastname = Console.ReadLine();


            ReverseString(Firstname);
            ReverseString(Lastname);
            */

            //bool dispaly = true;
            //while (dispaly==true)
            //{
            //    dispaly= mainMenu();
            //}

            string Mystring = "";
            for (int i = 0; i < 1; i++)
            {
                string newstring = Console.ReadLine();
                newstring +=newstring;
               // Mystring += i.ToString();
                Console.WriteLine(newstring);
            }

          


        }

      /*public static string ReverseString(string message)
        {
            //string message = Console.ReadLine() ;

            char[] messageArry = message.ToCharArray();
            Array.Reverse(messageArry);
            return String.Concat(messageArry);
            //foreach(char item in messageArry)
            //{
            //    Console.Write(item);
          

         // Console.Write(" ");

        } */


       /* private static bool mainMenu()
        {
            Console.WriteLine("choose an option");
            Console.WriteLine("1) option 1");
            Console.WriteLine("2) option 2");
            Console.WriteLine("3) option exit");

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                PrintNumber();
                return true;
            }
            else if (n == 2)
            {
                CriketGame();
                return true;
            }
            else if (n == 3)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        private static void PrintNumber()
        {
            Console.WriteLine("Print number");
            Console.WriteLine("Type a number");
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter<=n)

            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

        }

        private static void CriketGame()
        {
            Console.WriteLine("Playing criket game");

        } */
    }
}
