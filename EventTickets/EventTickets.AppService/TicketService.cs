using EventTickets.AppService.Messages;
using EventTickets.Model;
using EventTickets.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.AppService
{
    public class TicketService : ITicketService
    {
        private IEventRepository _eventRepository;

        public TicketService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public TicketService():this(new EventRepository())
        {
            
        }

        public PurchaseTicketResponse PurchaseTicket(string eventId, string reservationId)
        {
            var @event = _eventRepository.FindEvent(new Guid(eventId));
            var ticketPurchase = @event.PurchaseTicket(new Guid(reservationId));
            _eventRepository.SaveEvent(@event);

            return new PurchaseTicketResponse
            {
                TicketId = ticketPurchase.Id.ToString(),
                EventId = ticketPurchase.Event.Id.ToString(),
                NoOfTickets = ticketPurchase.TicketQuantity
            };
        }

        public ReservationTicketResponse ReserveTicket(string eventId, int quantity)
        {
            var @event = _eventRepository.FindEvent(new Guid(eventId));

            var reservation = @event.ReserveTicket(quantity);

            _eventRepository.SaveEvent(@event);

            return new ReservationTicketResponse
            {
                TicketId = reservation.Id.ToString(),
                EventId = reservation.Event.Id.ToString(),
                NoOfTickets = reservation.TicketQuantity,
                ReservationId = reservation.Id
            };
        }
    }
}
