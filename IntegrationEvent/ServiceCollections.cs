using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DDD.Event;
using EventBus;

namespace IntegrationEvent
{
    public static class ServiceCollections
    {
        public static IServiceCollection AddIntegrationEventModule(this IServiceCollection services)
        {
            //services.AddScoped<IEventBus, InMemoryEventBus>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
