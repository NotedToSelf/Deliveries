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
            
            //Get path to text file
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
            mapSize = Int32.Parse(sizeData);
            
            //Allocate array
            cityList = new Location[mapSize];

            //Read all names and allocate locations
            string nameLine = infile.ReadLine();
            string[] names = nameLine.Split(';');
            for (int i = 0; i < names.Length; ++i)
            {
                cityList[i] = new Location(names[i]);
            }
            
            // Read in connections and set connections
            string line;
            while ((line = infile.ReadLine()) != null)
            {
                string [] connections = line.Split(';');

                //ind is the source index
                int ind = search(connections[0]);
                int numConnect = Int32.Parse(connections[1]);
                for (int i = 2; i < numConnect+2; ++i)
                {
                    //data for one edge
                    string[] edgeData = connections[i].Split('-');
                    int toConnect = search(edgeData[0]);

                    if (toConnect == -1)
                    {
                        Console.WriteLine("Connection from " + connections[0] + " to " + edgeData[0] + "unsuccessful");
                    }

                    cityList[ind].insertEdge(new Edge(cityList[toConnect], Int32.Parse(edgeData[1]), Int32.Parse(edgeData[2])));
                }
            }
           return 0;
        }

        //Returns index of cityList Location with matching name
        private int search(string name)
        {
            for (int i = 0; i < mapSize; ++i)
            {
                if (cityList[i].compareName(name))
                {
                    return i;
                }
            }
            //return -1 if no match is found
            return -1;
        }
        
        //Display all connections
        public void displayAll()
        {
            for (int i = 0; i < mapSize; ++i)
            {
                cityList[i].displayConnections();
            }
        }
    }
}