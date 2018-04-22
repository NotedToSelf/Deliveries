using System;

namespace Deliveries
{
    public abstract class Delivery
    {
        protected int capacity;   //number of packages the delivery can hold
        protected float estimate; //estimated delivery time
        protected float payment;  //driver payment
        protected Location start; //starting position
        protected Location end; //ending position
        //package list
        //route list  
        
        //Constructors/Destructor
        protected Delivery()
        {
            estimate = 0.0f;
            payment = 0.0f;
            start = null;
            end = null;
        }

        ~Delivery()
        {
            start = null;
            end = null;
        }
        abstract public int deliver();
        abstract public string deliveryType();
        public void display()
        {
            Console.WriteLine("\tNumber of packages: " + capacity);
            Console.Write("\tStarting Location: ");
            start.printName();
            Console.Write("\n\tEnding Location: ");
            end.printName();
        }
    }

    //Standard delivery class
    //Max capacity: 20
    //Is not concerned with optimal route
    class Standard : Delivery
    {
        public Standard()
        {
            capacity = 20;
            start = null;
            end = null;
        }

        public Standard(int capacity, Location start, Location end)
        {
            this.capacity = capacity;
            this.start = start;
            this.end = end;
        }
        public override int deliver()
        {
            return 0;
        }

        public override string deliveryType()
        {
            return "standard";
        }

     
    }     
    
    //Express delivery class
    //Max capacity: 3
    //Must find optimal route
    class Express : Delivery
    {
        public Express()
        {
            capacity = 3;
            start = null;
            end = null;
        }

        public Express(int capacity, Location start, Location end)
        {
            this.capacity = capacity;
            this.start = start;
            this.end = end;
        }
        
        public override int deliver()
        {
            return 0;
        }

        public override string deliveryType()
        {
            return "express";
        }
    }
    
    //Drone delivery class
    //Max capacity: 1
    //Delivers straight from one location to another
    class Drone : Delivery
    {
        public Drone()
        {
            capacity = 1;
            start = null;
            end = null;
        }

        public Drone(Location start, Location end)
        {
            capacity = 1;
            this.start = start;
            this.end = end;
        }

        public override int deliver()
        {
            return 0;
        }

        public override string deliveryType()
        {
            return "drone";
        }
    }
}
