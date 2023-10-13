using System;
using System.Runtime.InteropServices;

namespace StudentManagement
{
    class Program
    {
        static void Main()
        {
           
           Console.Clear();
           while(true)
           {
                Console.WriteLine("Welcome to our Student Course Enrollement System!\n");
                Console.WriteLine("________******** Menu *********__________\n");
                Console.WriteLine("1. Enroll Course \n2. Withdraw the course \n3. View enrolled course\n4. Exit\n");
                
                Console.Write("Enter your choice: ");
               string choice = Console.ReadLine();
                    
                switch(choice)
                {
                   case "1": Console.WriteLine("Coming soon !"); break;
                   case "2": Console.WriteLine("Coming soon !"); break;
                   case "3": Console.WriteLine("Coming soon !"); break;
                    case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                }
           }
        }
    }
}
