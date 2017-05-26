using EventTicket.DataContracts;
using EventTickets.AppService;
using EventTickets.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventTickets.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TicketService" in both code and config file together.
    public class WebTicketService : IWebTicketService
    {
        private ITicketService _ticketService;

        public WebTicketService(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public WebTicketService(): this(new TicketService()) // Poor mans DI
        { }

        public PurchaseTicketResponse PurchaseTicket(string eventId, string reservationId)
        {
            var response = _ticketService.PurchaseTicket(eventId, reservationId);

            return new PurchaseTicketResponse
            {
                EventId = response.EventId,
                NoOfTickets = response.NoOfTickets,
                TicketId = response.TicketId
            };
        }

        public ReservationTicketResponse ReserveTicket(string eventId, int quantity)
        {
            var response = _ticketService.ReserveTicket(eventId, quantity);

            return new ReservationTicketResponse
            {
                EventId = response.EventId,
                NoOfTickets = response.NoOfTickets,
                TicketId = response.TicketId
            };
        }
    }
}
