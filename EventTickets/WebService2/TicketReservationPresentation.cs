using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2
{
    public class TicketReservationPresentation
    {
        public string EventId { get; set; }
        public bool TicketWasReserved { get; set; }
        public int AmountOfTickets { get; set; }
        public string ReservationId { get; set; }
    }
}