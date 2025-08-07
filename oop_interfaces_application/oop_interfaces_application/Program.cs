using System;

namespace MovableExample 
{

    interface IMovable
    {
        void Move();
    }
    //Car implements IMovable 
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
     //Bicycle implements IMovable
    class Bicycle : IMovable
            {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
        
        }
    
            
    class Program {
        static void Main(string[] args) 
        {
            //Create instances 
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            //Call Move method
            myCar.Move();
            myBicycle.Move();
        }
    }

}