using System;

namespace Deliveries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            bool running = true; //Program runs until user input to stop
            welcome();
            //Create map. Default constructor reads map data and constructs map
            Graph map = new Graph();
            Delivery carrier = null; 
       
            //continue until user input to exit
            while (running)
            {
                int response = menu();
                switch (response)
                {
                    //1: List availible Cities
                    case 1:
                        map.displayNames();
                        break;
                    //2: create new delivery plan
                    case 2:
                        createDelivery(ref carrier, map);
                        map.findRoute(carrier);             
                        break;
                    //3: quit
                    case 3:
                        running = false;
                        break;
                    //invalid response: show error
                    default:
                        Console.WriteLine("Invalid menu response. Try again with a number.");
                        break;
                }
            }
            
            Console.WriteLine("\nThank you for using Deliveries! Exiting. . .");
        }
    
        //Display welcome message
        private static void welcome()
        {
            Console.WriteLine("\nWelcome to Delivieries! Schedule deliveries to some of the west coast's biggest cities.");
        }
        //Prompt user to create a Delivrey
        private static void createDelivery(ref Delivery toCreate, Graph map)
        {
            //For the scope of this program, one delivery exists at a time
            toCreate = null;
            bool correct = false;
            int numPackages =  0;
 
            while (!correct)
            {
                Console.WriteLine("\nChoose your delivery type:");
                Console.WriteLine("\t1. Standard (max 10 packages. Slowest service");
                Console.WriteLine("\t2. Express  (max 3 packages.  Optimized route");
                Console.WriteLine("\t3. Drone    (max 1 packagse.  Fastest service");
                Console.Write("\nEnter your response: -> ");
                int response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.Write("How many packages are you delivering? (max 10)\n\t -> ");
                        numPackages = Convert.ToInt32(Console.ReadLine());
                        Location startS = map.promptStart();
                        Location endS = map.promptEnd();
                        toCreate = new Standard(numPackages, startS, endS);
                        correct = true;
                        break;
                    case 2:
                        Console.Write("How many packages are you delivering? (max 3)\n\t -> ");
                        numPackages = Convert.ToInt32(Console.ReadLine());
                        Location startE = map.promptStart();
                        Location endE = map.promptEnd();
                        toCreate = new Express(numPackages, startE, endE);                  
                        correct = true;
                        break;
                    case 3:
                        Console.Write("Creating Drone. Drones can only deliver one package.");
                        Location startD = map.promptStart();
                        Location endD = map.promptEnd();
                        toCreate = new Drone(startD, endD);
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("Invalied response. Try again with a number");
                        break; 
                }
                Console.WriteLine("\nSuccessfully created Delivery service with the following info:");
                toCreate.display();
                Console.WriteLine();
            }
        }
        //Prompt user to enter a menu choice
        private static int menu()
        {
           Console.WriteLine("\nMenu:");
           Console.WriteLine("\t1. Display supported cities.");
           Console.WriteLine("\t2. Create a new delivery plan.");
           Console.WriteLine("\t3. Exit program");
           Console.Write("\nEnter your response: -> ");
           return Convert.ToInt32(Console.ReadLine());
        }
    }
}