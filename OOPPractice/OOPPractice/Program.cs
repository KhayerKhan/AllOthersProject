using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            WaterBottle bottle1 = new WaterBottle("red");
            WaterBottle bottle2 = new WaterBottle();
            double bottle = bottle1.CurrentAmountWater;
            Console.WriteLine(bottle);

            //bottle1.color = "Red";
            Console.WriteLine(bottle1.Color);
            Console.WriteLine(bottle2.Color);

            string color = bottle1.Color;
           // bottle1.color = "red";
               
            Console.ReadLine();

        }
    }
    public class WaterBottle
    {
        private readonly string color;
        public double capacity;
        public string logo;
        public double height;
        public double radius;
        public double CurrentAmountWater;

        public WaterBottle(string color) : this()
            {

            this.color = color;
            }
        public WaterBottle()
        {
            this.color = "blue";
            this.capacity = 5;
            this.height = 6;
            this.logo = "Devskill";
            
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
            this.CurrentAmountWater += AmountWater;

        }

        public double ReleaseWater(double AmountWater)
        {
            if (this.CurrentAmountWater >= AmountWater)
            {
                this.CurrentAmountWater -= AmountWater;
                return AmountWater;
            }
            else
            {
                var amount = this.CurrentAmountWater;
                this.CurrentAmountWater = 0;
                return amount;

            }
        }

        public double MeasereWater()
        {
            return this.CurrentAmountWater;
        }

    }




}
