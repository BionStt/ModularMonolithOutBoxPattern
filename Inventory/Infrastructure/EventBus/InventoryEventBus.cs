using EventBus;
using Inventory.EventBus;
using Outbox.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.EventBus
{
    public class InventoryEventBus : InMemoryEventBus, IInventoryEventBus
    {
        public InventoryEventBus(OutboxDbContext dbContext) : base(dbContext)
        {
        }
    }
}
