using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesMarketing.EventBus;
using SalesMarketing.Infrastructure.Context;
using SalesMarketing.Infrastructure.EventBus;
using SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SalesMarketing
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSalesMarketingModule(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SalesMarketingContext>(options => options.UseSqlServer(connectionString));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddMediatR(typeof(CreateMasterBarangCommand));

       
           
            services.AddScoped<ISalesMarketingEventBus, SalesMarketingEventBus>();

            return services;


        }
    }
}
