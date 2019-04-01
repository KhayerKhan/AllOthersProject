using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class OOP2
    {
        static void main(string[] args)
        {
            


        }
    }
    public abstract class vehicles
    {
        public double speed;
        public string color;
        public string model;
        public string seats;

        public abstract void start();

        public abstract void stop();
        
    }

    public abstract class PrivateCar :vehicles
    {
        public int door;
        public int wheets;
    }
    public class toyota :PrivateCar
    {
        public override void start()
        {
            throw new NotImplementedException();
        }
        public override void stop()
        {
            throw new NotImplementedException();
        }
    }


    public class Ship : vehicles
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
    public class Airoplan : vehicles
    {
        public string wings;

        public override void start()
        {
            throw new NotImplementedException();
        }

        public override void stop()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class user{
     public double Id;
    public string Name;
    public string photo;
    public string UserName;
    public string Password;

    public void Login(string Username, string password)
    {


    }
    public void LogOut()
    {


    }

        public abstract bool ValidateIdFormat(string id);

}

    public class Student :user
    {
       

        public override bool ValidateIdFormat(string id)
        {
            throw new NotImplementedException();
        }
    }
    public class Teacher :user
    {
    
        public override bool ValidateIdFormat(string id)
        {
            throw new NotImplementedException();
        }
    }

}
