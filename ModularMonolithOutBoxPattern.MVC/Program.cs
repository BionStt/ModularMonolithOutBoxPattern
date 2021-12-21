using Inventory;
using Outbox;
using SalesMarketing;
using Newtonsoft.Json.Serialization;
using IntegrationEvent;
using EventBus;
using Outbox.WorkerProcess;
using DDD.Event;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddInMemoryEventBus();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



builder.Services.AddInventoryModule(builder.Configuration.GetConnectionString("InventoryConnection"));

builder.Services.AddSalesMarketingModule(builder.Configuration.GetConnectionString("SalesMarketingConnection"));

builder.Services.AddOutBoxModule(builder.Configuration.GetConnectionString("OutBoxConnection"));

builder.Services.AddIntegrationEventModule();



builder.Services.AddHostedService<OutBoxWorker>();


builder.Services.AddControllersWithViews().AddNewtonsoftJson(x =>
{
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    x.SerializerSettings.ContractResolver = new DefaultContractResolver();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
