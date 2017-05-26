using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTickets.Model
{
    public interface IEventRepository
    {
        Event FindEvent(Guid id);
        void SaveEvent(Event @event);
    }
}
