namespace Deliveries
{
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
}