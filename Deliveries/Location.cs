using System;

namespace Deliveries
{
    public class Location
    {
        private string name;
        private EdgeList adjacent;

        //Constructors/Destructor
        public Location()
        {
            name = null;
            adjacent = new EdgeList();
        }

        ~Location()
        {
            name = null;
            adjacent = null;
        }
        public Location(string name)
        {
            this.name = name;
            adjacent = new EdgeList();
        }

        public bool compareName(string name)
        {
            if (this.name == name)
                return true;
            return false;
        }
        public void printName()
        {
            Console.Write(name);
        }

        public int insertEdge(Edge toAdd)
        {
            return adjacent.insert(toAdd);
        }

        public int displayConnections()
        {
            Console.WriteLine("\nStarting Location: " + name);
            Console.WriteLine("Connections: ");
            return adjacent.display();
        }
    }
}