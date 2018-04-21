using System.Runtime.InteropServices;

namespace Deliveries
{
    abstract class Delivery
    {
        protected int capacity;   //number of packages the delivery can hold
        protected float estimate; //estimated delivery time
        protected float payment;  //driver payment
        //package list
        //route list  
        
        abstract public int deliver();
        
    }

    //Standard delivery class
    //Max capacity: 20
    //Is not concerned with optimal route
    class Standard : Delivery
    {
        public Standard()
        {
            capacity = 20;
            estimate = 0.0f;
            payment = 0.0f;
        }
        
        public override int deliver()
        {
            return 0;
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
            estimate = 0.0f;
            payment = 0.0f;
        }
        
        public override int deliver()
        {
            return 0;
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
            estimate = 0.0f;
            payment = 0.0f;
        }

        public override int deliver()
        {
            return 0;
        }
    }
}