using DDD.Event;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddInMemoryEventBus(this IServiceCollection services)
        {
            services.AddScoped<IEventBus, InMemoryEventBus>();

            return services;
        }
    }
}
