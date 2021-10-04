using System;
using System.Collections.Generic;

namespace TicketMachine
{
    public class Ticket
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
}