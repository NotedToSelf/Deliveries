using System;
using System.CodeDom;
using System.IO;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Deliveries
{
    public class Graph
    {
        private Location [] cityList;
        private int mapSize;

        
        public Graph()
        {
            read();
        }

        //Reads graph data from external file
        private int read()
        {
            //exception handling needed here
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path = Path.Combine(path, "input.txt");
       
            if (!File.Exists(path))
            {
                Console.WriteLine("No input file exists! Exiting. . .");
                return 0;
            }

            StreamReader infile = new StreamReader(path);
            int index = 0;

            //Read number of cities
            string sizeData = infile.ReadLine();
            int size = Int32.Parse(sizeData);

            //Allocate array
            cityList = new Location[size];

            //Read all names and allocate locations
            string nameLine = infile.ReadLine();
            string[] names = nameLine.Split(';');
            for (int i = 0; i < names.Length; ++i)
            {
                cityList[i] = new Location(names[i]);
            }
            
            // Read in connections and set connections
           return 0;
        }
    }
}