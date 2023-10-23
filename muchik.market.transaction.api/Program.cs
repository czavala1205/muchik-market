using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using muchik.market.infrastructure.bus.settings;
using muchik.market.transaction.application.interfaces;
using muchik.market.transaction.application.mappings;
using muchik.market.transaction.application.services;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;
using muchik.market.infrastructure.ioc;
using muchik.market.transaction.domain.interfaces;
using MongoDB.Driver;
using muchik.market.transaction.application.events;
using muchik.market.transaction.application.eventHandlers;
using muchik.market.domain.bus;
using MongoFramework;
using muchik.market.transaction.infraestructure.settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfigServer();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//AutoMapper
builder.Services.AddAutoMapper(typeof(EntityToDtoProfile), typeof(DtoToEntityProfile));

//Mongo DB Server

builder.Services.Configure<TransactionSettings>(builder.Configuration.GetSection(nameof(TransactionSettings)));
builder.Services.AddSingleton<ITransactionSettings>(sp => sp.GetRequiredService<IOptions<TransactionSettings>>().Value);
string conexion = builder.Configuration.GetValue<string>("TransactionSettings:TransactionConnectionString");
builder.Services.AddSingleton<IMongoClient>(sp => new MongoClient(builder.Configuration.GetValue<string>("TransactionSettings:TransactionConnectionString")));



//RabbitMQ Settings
builder.Services.Configure<RabbitMqSettings>(builder.Configuration.GetSection("rabbitMqSettings"));

//IoC
builder.Services.RegisterServices(builder.Configuration);

//Services
builder.Services.AddTransient<ITransactionService, TransactionService>();

////Commands & Events
builder.Services.AddTransient<IEventHandler<CreateTransactionEvent>, CreateTransactionEventHandler>();

//Subscriptions
builder.Services.AddTransient<CreateTransactionEventHandler>();

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
eventBus.Subscribe<CreateTransactionEvent, CreateTransactionEventHandler>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();