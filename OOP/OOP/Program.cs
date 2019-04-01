using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.ReadLine();



            

        }
    }

    public class WaterBottle
    {
    

        public WaterBottle(string color) 
        {
            this.color = color;
            

        }

        public WaterBottle()
        {
            this.color = "blue";
            this.capacity = 20;
            this.height = 5;
            this.radius = 6;
            this.weight = 5;
            this.logo = "devskill";
            this.CurrentWaterAmount = 0;

        }


        public string Color
        {
            get
            {
                return color;
            }
          
        }

   

    public void InsertWater(double AmountWater)
    {
           
    }
    public double ReleaseWater(double AmountWater)
    {
        throw new NotImplementedException();
    }
            
   }

}
