using System;
namespace EventTickets.AppService
{
    public interface ITicketService
    {
        EventTickets.AppService.Messages.PurchaseTicketResponse PurchaseTicket(string eventId, string reservationId);
        EventTickets.AppService.Messages.ReservationTicketResponse ReserveTicket(string eventId, int quantity);
    }
}
