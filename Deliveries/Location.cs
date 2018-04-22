using System;
using System.Runtime.InteropServices;

namespace Deliveries
{
    public class Location
    {
        private string name;
        private EdgeList adjacent;

        public Location()
        {
            name = null;
            adjacent = new EdgeList();
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
            Console.Write("\t" + name);
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