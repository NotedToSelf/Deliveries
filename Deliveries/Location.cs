using System;
using System.Runtime.InteropServices;

namespace Deliveries
{
    public class Location
    {
        private string name;

        public Location(string name)
        {
            this.name = name;
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
        
    }
}