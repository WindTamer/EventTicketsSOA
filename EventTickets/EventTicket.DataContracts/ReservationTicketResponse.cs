using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EventTicket.DataContracts
{
    [DataContract]
    public class ReservationTicketResponse
    {
        [DataMember]
        public string TicketId { get; set; }

        [DataMember]
        public String EventId { get; set; }

        [DataMember]
        public int NoOfTickets { get; set; }
    }
}
