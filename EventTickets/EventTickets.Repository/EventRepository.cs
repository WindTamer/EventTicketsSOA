using EventTickets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.Repository
{
    public class EventRepository : IEventRepository
    {
        public Event FindEvent(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveEvent(Event @event)
        {
            throw new NotImplementedException();
        }
    }
}
