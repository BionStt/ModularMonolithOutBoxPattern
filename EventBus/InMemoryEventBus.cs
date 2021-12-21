using DDD.Event;
using Outbox.Domain;
using Outbox.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly OutboxDbContext _dbContext;
        public InMemoryEventBus(OutboxDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Publish(IIntegrationEvent @event)
        {
            await PersistIntegrationEvent(@event);
        }

        private async Task PersistIntegrationEvent(IIntegrationEvent @event)
        {
            var outBoxMessage = OutBoxMessage.New(@event);
            await _dbContext.OutBoxMessages.AddAsync(outBoxMessage);
            await _dbContext.SaveChangesAsync();

        }
        public async Task PublishMany(IEnumerable<IIntegrationEvent> @events)

        {
            foreach (var @event in @events)
            {
                await PersistIntegrationEvent(@event);
            }

            await _dbContext.SaveChangesAsync(CancellationToken.None);
        }
    }
}
