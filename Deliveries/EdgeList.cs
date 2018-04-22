using System;
using System.ComponentModel;

namespace Deliveries
{
    public class EdgeList
    {
        private Edge head;

        //Default constructor
        public EdgeList()
        {
            head = null;
        }
    
        public int insert(Edge toAdd)
        {
            //If empty list create first node
            if (head == null)
            {
                head = new Edge(toAdd);
                return 1;
            }
            //Else insert at head
            Edge temp = head;
            head = new Edge(toAdd, temp);
            return 1;
        }

        public int display()
        {
            return display(head);
        }

        private int display(Edge head)
        {
            if (head == null)
                return 0;
            head.display();
            return display(head.go_next());
        }
    }

    public class Edge
    {
        private Location adjacent;
        private Edge next;
        private int distance;
        private int mph;

        public Edge()
        {
            next = null;
            adjacent = null;
            distance = 0;
            mph = 0;
        }

        public Edge(Location adjacent, int distance, int mph)
        {
            this.adjacent = adjacent;
            this.distance = distance;
            this.mph = mph;
        }
        public Edge(Edge toCopy, Edge next)
        {
            adjacent = toCopy.adjacent;
            distance = toCopy.distance;
            mph = toCopy.mph;
            this.next = next;
        }
        public Edge(Edge toCopy)
        {
            adjacent = toCopy.adjacent;
            distance = toCopy.distance;
            mph = toCopy.mph;
            next = null;
        }

        public Edge go_next()
        {
            return next;
        }

        public void display()
        {
            adjacent.printName();
            Console.Write(":  " + distance + " miles, ");
            Console.Write(" " + mph + " mph speed limit\n");
        }
    }
}