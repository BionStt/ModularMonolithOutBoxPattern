using Inventory.EventBus;
using Inventory.Infrastructure.Context;
using Inventory.Infrastructure.EventBus;
using Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInventoryModule(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<InventoryContext>(options => options.UseSqlServer(connectionString));
          services.AddMediatR(Assembly.GetExecutingAssembly());

          //  services.AddMediatR(typeof(CreateMasterBarangCommand));
      
            services.AddScoped<IInventoryEventBus, InventoryEventBus>();


            return services;


        }
        
    }
}
