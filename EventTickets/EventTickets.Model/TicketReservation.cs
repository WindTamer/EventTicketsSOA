using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventTickets.Model
{
    public class TicketReservation
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }
        public int TicketQuantity { get; set; }
    }
}
