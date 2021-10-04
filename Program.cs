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
                    Ticket ticket = new Ticket
                        {
                        Console.WriteLine("Enter TicketID."),
                        TicketID = Console.ReadLine(),

                        Console.WriteLine("Enter summary."),
                        summary = Console.ReadLine(),

                        Console.WriteLine("Enter status."),
                        status = Console.ReadLine(),
                        
                        Console.WriteLine("Enter priority."),
                        priority = Console.ReadLine(),

                        Console.WriteLine("Enter submitter."),
                        submitter = Console.ReadLine(),

                        Console.WriteLine("Enter assigned empoyees."),
                        assigned = Console.ReadLine(),

                        Console.WriteLine("Enter employees watching."),
                        watching = Console.ReadLine(),

                        newticket = TicketID+", "+summary+", "+status+", "+priority+", "+submitter+", "+assigned+", "+watching,
                        };
                        using (StreamWriter sw = File.AppendText(file)){
                            sw.WriteLine();
                            sw.WriteLine(newticket);
                        }
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
