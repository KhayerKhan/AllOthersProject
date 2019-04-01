using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPractice
{

    //public class pairInt
    //{
    //    public int X;
    //    public int Y;

    //}

    //public class PairFloat
    //{
    //    public float X;
    //    public float Y;


    //}

    //class pair<TX ,TY>
    //{
    //    public TX X;
    //    public TY Y;
    //}

    public class classA
    {
      
      public  int testA()
        {
            return 5;

        }
    }
    public class classB :classA
    {
        public int testB()
        {
            return 5;

        }

    }
    public class classC : classB
    {

        public int testC()
        {
            return 5;

        }

    }

    interface Isomething
    {


    }

    class GenericClass<T,U> where T: classB
    {

        public void DoSomething<X>(X x,X y,T z) where X : struct
        {
            
            z.testA
            //Console.WriteLine(z);
            //Console.WriteLine(x.ToString());
            //Console.WriteLine(y.ToString());

        }
    }

    class Generic
    {
        public static void Main(string[] args)
        {

            var p = new GenericClass<classA,double>();
            p.DoSomething(2, 3,new classA());
            
        
            



          Console.ReadLine();
        }
    }
}
