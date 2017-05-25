using EventTicket.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventTickets.ServiceContracts
{
    [ServiceContract]
    public interface IWebTicketService
    {
        [OperationContract]
        PurchaseTicketResponse PurchaseTicket(string eventId, string reservationId);

        [OperationContract]
        ReservationTicketResponse ReserveTicket(string eventId, int quantity);
    }
}
