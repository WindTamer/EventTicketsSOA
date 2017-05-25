using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService2
{
    public class TicketPresentation
    {
        public string TicketId { get; set; }
        public string EventId { get; set; }
        public string Description { get; set; }
        public bool WasAbleToPurchase { get; set; }
    }
}