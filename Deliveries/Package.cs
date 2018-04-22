namespace Deliveries
{
    public class Package
    {
        private float weight; //weight in lbs
        private float size;   //size in square inches
        private Location destination;

        public Package()
        {
            weight = 0.0f;
            size = 0.0f;
            destination = null;
        }

        public Package(float weight, float size, Location destination)
        {
            this.weight = weight;
            this.size = size;
            this.destination = destination;
        }
    }
}