using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Event
{
    public interface IEventBus
    {
        public Task Publish(IIntegrationEvent @event);
        Task PublishMany(IEnumerable<IIntegrationEvent> @events);
    }
}
