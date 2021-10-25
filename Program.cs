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
                        string readtext1= File.ReadAllText("Tickets.csv");
                        Console.WriteLine(readtext1);
                        string readtext2= File.ReadAllText("Enhancements.csv");
                        Console.WriteLine(readtext2);
                        string readtext3= File.ReadAllText("Task.csv");
                        Console.WriteLine(readtext3);
                }
                else if (choice == "2")
                {
                    do
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

                        Console.WriteLine("What kind of ticket is it?");
                        Console.WriteLine("1) Bug Ticket.");
                        Console.WriteLine("2) Enhancement Ticket.");
                        Console.WriteLine("3) Task Ticket.");
                        Console.WriteLine("Enter any other key to exit.");
                        string choice2 = Console.ReadLine();

                        if (choice2 == "1")
                        {
                            Console.WriteLine("Enter severity.");
                            string severityTemp = Console.ReadLine();
                            newticketTemp = newticketTemp+", "+severityTemp;
                            Ticket Bug = new BugTicket
                                {
                                TicketID = TicketIDTemp,
                                summary = summaryTemp,
                                status = statusTemp, 
                                priority = priorityTemp,
                                submitter = submitterTemp,
                                assigned = assignedTemp,
                                watching = watchingTemp,
                                newticket = newticketTemp,
                                severity = severityTemp,
                                };
                                using (StreamWriter sw = File.AppendText(file)){
                                    sw.WriteLine();
                                    sw.WriteLine(newticketTemp);
                                }
                                break;
                        }
                        else if( choice2 == "2"){
                            Console.WriteLine("Enter software.");
                            string softwareTemp = Console.ReadLine();
                            Console.WriteLine("Enter cost.");
                            string costTemp = Console.ReadLine();
                            Console.WriteLine("Enter reason.");
                            string reasonTemp = Console.ReadLine();
                            Console.WriteLine("Enter estimate.");
                            string estimateTemp = Console.ReadLine();
                            newticketTemp = newticketTemp+", "+softwareTemp+", "+costTemp+", "+reasonTemp+", "+estimateTemp;
                            Ticket Enhancement = new Enhancements
                                {
                                TicketID = TicketIDTemp,
                                summary = summaryTemp,
                                status = statusTemp, 
                                priority = priorityTemp,
                                submitter = submitterTemp,
                                assigned = assignedTemp,
                                watching = watchingTemp,
                                newticket = newticketTemp,
                                software = softwareTemp,
                                cost = costTemp,
                                reason = reasonTemp,
                                estimate = estimateTemp,
                                };
                                using (StreamWriter sw = File.AppendText("Enhancements.csv")){
                                    sw.WriteLine();
                                    sw.WriteLine(newticketTemp);
                                }
                                break;
                        }
                        else if(choice2 == "3"){
                            Console.WriteLine("Enter project name.");
                            string projectNameTemp = Console.ReadLine();
                            Console.WriteLine("Enter due date.");
                            string dueDateTemp = Console.ReadLine();
                            newticketTemp = newticketTemp+", "+projectNameTemp+", "+dueDateTemp;
                            Ticket Task = new Task
                                {
                                TicketID = TicketIDTemp,
                                summary = summaryTemp,
                                status = statusTemp, 
                                priority = priorityTemp,
                                submitter = submitterTemp,
                                assigned = assignedTemp,
                                watching = watchingTemp,
                                newticket = newticketTemp,
                                projectName = projectNameTemp,
                                dueDate=dueDateTemp,
                                };
                                using (StreamWriter sw = File.AppendText("Task.csv")){
                                    sw.WriteLine();
                                    sw.WriteLine(newticketTemp);
                                }
                                break;
                        }
                    } while (choice == "1" || choice == "2" || choice =="3");
                }
            } while (choice == "1" || choice == "2");
        }
        
    }
}
