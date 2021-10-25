using System;
using System.Collections.Generic;

namespace TicketMachine
{
    public abstract class Ticket
    {
        public string TicketID { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public string watching { get; set; }
        public string newticket{get; set; }

        public Ticket()
        {
            // TicketID;
            // summary;
            // status;
            // priority;
            // submitter;
            // assigned;
            // watching;

        }

    }
    public class BugTicket:Ticket{
        public string severity{get; set;}
    }
    public class Enhancements:Ticket{
        public string software{get; set;}
        public string cost{get; set;}
        public string reason{get; set;}
        public string estimate{get; set;}
    }
    public class Task:Ticket{
        public string projectName{get; set;}
        public string dueDate{get; set;}
    }
}