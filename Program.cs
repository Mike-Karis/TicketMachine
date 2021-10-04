using System;
using System.IO;
using System.Collections.Generic;
namespace TicketMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            string choice;
            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Add data to file.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                        string readtext= File.ReadAllText("Tickets.csv");
                        Console.WriteLine(readtext);
                }
                else if (choice == "2")
                {

                     Console.WriteLine("Enter TicketID.");
                        string TicketIDTemp = Console.ReadLine();

                        Console.WriteLine("Enter summary.");
                        string summaryTemp = Console.ReadLine();

                        Console.WriteLine("Enter status.");
                        string statusTemp = Console.ReadLine();
                        
                        Console.WriteLine("Enter priority.");
                        string priorityTemp = Console.ReadLine();

                        Console.WriteLine("Enter submitter.");
                        string submitterTemp = Console.ReadLine();

                        Console.WriteLine("Enter assigned empoyees.");
                        string assignedTemp = Console.ReadLine();

                        Console.WriteLine("Enter employees watching.");
                        string watchingTemp = Console.ReadLine();
                        string newticketTemp = TicketIDTemp+", "+summaryTemp+", "+statusTemp+", "+priorityTemp+", "+submitterTemp+", "+assignedTemp+", "+watchingTemp;

                    Ticket ticket = new Ticket
                        {
                        TicketID = TicketIDTemp,
                        summary = summaryTemp,
                        status = statusTemp, 
                        priority = priorityTemp,
                        submitter = submitterTemp,
                        assigned = assignedTemp,
                        watching = watchingTemp,
                        newticket = newticketTemp,
                        };

                        using (StreamWriter sw = File.AppendText(file)){
                            sw.WriteLine();
                            sw.WriteLine(newticketTemp);
                        }
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
