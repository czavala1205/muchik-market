using Microsoft.EntityFrameworkCore;
using muchik.market.invoice.application.interfaces;
using muchik.market.invoice.application.mappings;
using muchik.market.invoice.application.services;
using muchik.market.invoice.domain.interfaces;
using muchik.market.invoice.infrastructure.context;
using muchik.market.invoice.infrastructure.repositories;
using muchik.market.infrastructure.bus.settings;
using muchik.market.infrastructure.ioc;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;
using muchik.market.domain.bus;
using muchik.market.invoice.application.events;
using muchik.market.invoice.application.eventHandlers;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfigServer();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//AutoMapper
builder.Services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(DtoToEntityProfile));

//SQL Server
builder.Services.AddDbContext<InvoiceContext>(config =>
{
    config.UseNpgsql(builder.Configuration.GetValue<string>("connectionStrings:muchikConnection"));
});

//RabbitMQ Settings
builder.Services.Configure<RabbitMqSettings>(builder.Configuration.GetSection("RabbitMqSettings"));

//IoC
builder.Services.RegisterServices(builder.Configuration);

//Services
builder.Services.AddTransient<IInvoiceService, InvoiceService>();

//Repositories
builder.Services.AddTransient<IInvoiceRepository, InvoiceRepository>();

//Context
builder.Services.AddTransient<InvoiceContext>();

//Commands & Events
builder.Services.AddTransient<IEventHandler<UpdateInvoiceEvent>, UpdateInvoiceEventHandler>();

//Subscriptions
builder.Services.AddTransient<UpdateInvoiceEventHandler>();

//CORS
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", b => b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

//Consul
builder.Services.AddDiscoveryClient();

var app = builder.Build();

//Subscriptions
var eventBus = app.Services.GetRequiredService<IEventBus>();
eventBus.Subscribe<UpdateInvoiceEvent, UpdateInvoiceEventHandler>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
