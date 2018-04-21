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

  
    
}