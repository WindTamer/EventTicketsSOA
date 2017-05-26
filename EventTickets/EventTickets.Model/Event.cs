using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.Model
{
    public class Event
    {
        public Guid Id { get; set; }

        public List<TicketReservation> ReservedTickets { get; set; }
        public List<TicketPurchase> PurchasedTickets { get; set; }

        public Event()
        {
            ReservedTickets = new List<TicketReservation>();
            PurchasedTickets = new List<TicketPurchase>();
        }

        public TicketReservation ReserveTicket(int quantity)
        {
            var reservation = new TicketReservation
            {
                Id = Guid.NewGuid(),
                Event = this,
                TicketQuantity = quantity
            };

            ReservedTickets.Add(reservation);

            return reservation;
        }

        public TicketPurchase PurchaseTicket(Guid reservationId)
        {
            var reservation = ReservedTickets.FirstOrDefault(a => a.Id == reservationId);

            if (reservation == null)
            {
                throw new ApplicationException("no reservation");
            }

            var ticketPurchase = new TicketPurchase()
            {
                Id = Guid.NewGuid(),
                Event = this,
                TicketQuantity = reservation.TicketQuantity
            };

            PurchasedTickets.Add(ticketPurchase);

            return ticketPurchase;
        }

    }
}
