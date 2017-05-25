using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.AppService.Messages
{
    public class PurchaseTicketResponse
    {
        public string TicketId { get; set; }
        public String EventId { get; set; }
        public int NoOfTickets { get; set; }
    }
}
