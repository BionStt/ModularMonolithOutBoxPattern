using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Event
{
    public class IntegrationEventViaMediaTR : INotification
    {
        public Guid Id { get; }

        public DateTime OccurredOn { get; }

        protected IntegrationEventViaMediaTR(Guid id, DateTime occurredOn)
        {
            this.Id = id;
            this.OccurredOn = occurredOn;
        }
    }
}
