using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Outbox.Infrastructure.Context;
using Outbox.WorkerProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outbox
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddOutBoxModule(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OutboxDbContext>(options => options.UseSqlServer(connectionString));
            services.AddHostedService<OutBoxWorker>();

            return services;
        }
    }
}
