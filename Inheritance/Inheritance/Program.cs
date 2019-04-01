using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota toyota = new Toyota();
            toyota.LoadFuel(600);
            


            Console.WriteLine(toyota.fuel);

           // Console.WriteLine("Hello World!");
        }
    }

    public class user
    {
        public string name;
        public string photo;
       public string username;
       public string password;

        public void Login(string username, string password)
        {

        }
        public void logout()
        {

        }
    }
    

    public abstract class vehicle
    {
        public double speed;
        public string model;
        public string color;
        public int seats;

        public abstract void start();


        public abstract void stop();
       
    }

    public abstract class PrivateCar : vehicle
    {
        public int door;
        public int wheets;
        public int fuel;
        public virtual void LoadFuel(int fuel)
            {

            this.fuel = fuel;
            }
       
       
    }

    public class Toyota : PrivateCar
    {
        public override void start()
        {
            throw new NotImplementedException();
        }

        public override void stop()
        {
            throw new NotImplementedException();
        }

        public override void LoadFuel(int fuel)
        {
            if (fuel > 500)
            
               throw new Exception("fuel overflow");
            
               this.fuel = fuel;
        }
    }


    public class ship :vehicle
    {
        public string anchor;

        public override void start()
        {
            throw new NotImplementedException();
        }

        public override void stop()
        {
            throw new NotImplementedException();
        }
    }

    public class AirPlane : vehicle
    {
        public double wings;

        public override void start()
        {
            throw new NotImplementedException();
        }

        public override void stop()
        {
            throw new NotImplementedException();
        }
    }
}
