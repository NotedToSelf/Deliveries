namespace Deliveries
{
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