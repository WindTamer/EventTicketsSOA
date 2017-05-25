using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace EventTicket.DataContracts
{
    [DataContract]
    public class PurchaseTicketResponse
    {
        [DataMember]
        public string TicketId { get; set; }

        [DataMember]
        public String EventId { get; set; }

        [DataMember]
        public int NoOfTickets { get; set; }
    }
}
