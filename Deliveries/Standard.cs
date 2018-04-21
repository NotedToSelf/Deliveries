namespace Deliveries
{
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
}