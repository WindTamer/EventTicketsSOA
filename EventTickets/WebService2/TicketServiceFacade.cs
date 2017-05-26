using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventTickets.ServiceContracts;
using EventTicket.DataContracts;

namespace WebService2
{
    public class TicketServiceFacade
    {
        private IWebTicketService _webTicketService;

        public TicketServiceFacade(IWebTicketService webTicketService)
        {
            _webTicketService = webTicketService;
        }

        public TicketReservationPresentation ReserveTicketsFor(string EventId, int TicketAmount)
        {
            TicketReservationPresentation reservation = new TicketReservationPresentation();

            ReservationTicketResponse response = _webTicketService.ReserveTicket(EventId, TicketAmount);

            reservation.TicketWasReserved = true;
            reservation.EventId = response.EventId;
            reservation.AmountOfTickets = response.NoOfTickets;
            reservation.ReservationId = response.ReservationId;

            return reservation;
        }

        public TicketPresentation PurchaseReservedTicket(string eventId, string reservationId)
        {
            TicketPresentation ticket = new TicketPresentation();

            PurchaseTicketResponse response = new PurchaseTicketResponse();

            response = _webTicketService.PurchaseTicket(eventId, reservationId);

            ticket.EventId = response.EventId;
            ticket.TicketId = response.TicketId;
            ticket.WasAbleToPurchase = true;

            return ticket;
        }
    }
}