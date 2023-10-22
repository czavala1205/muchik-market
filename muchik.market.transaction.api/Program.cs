using IoTSharp.EntityFrameworkCore.MongoDB.Extensions;
using muchik.market.infrastructure.bus.settings;
using muchik.market.transaction.application.interfaces;
using muchik.market.transaction.application.mappings;
using muchik.market.transaction.application.services;
using muchik.market.transaction.infrastructure.context;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.ConfigServer;
using muchik.market.infrastructure.ioc;
using muchik.market.transaction.domain.interfaces;
using muchik.market.transaction.infrastructure.repositories;
using MongoDB.Driver;
using MediatR;
using muchik.market.transaction.application.events;
using muchik.market.transaction.application.eventHandlers;
using muchik.market.domain.bus;
using MongoFramework;

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
builder.Services.AddDbContext<TransactionContext>(config =>
{
    config.UseMongoDB(
        builder.Configuration["mongoDBSettings:muchikConnection"],
        databaseName: builder.Configuration["mongoDBSettings:database"]);
});

builder.Services.AddTransient<IMongoDbConnection>(
    s => MongoDbConnection.FromUrl(MongoUrl.Create(builder.Configuration.GetValue<string>("mongoDBSettings:muchikConnection")))
);



//RabbitMQ Settings
builder.Services.Configure<RabbitMqSettings>(builder.Configuration.GetSection("rabbitMqSettings"));

//IoC
builder.Services.RegisterServices(builder.Configuration);

//Services
builder.Services.AddTransient<ITransactionService, TransactionService>();

////Repositories
builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();

//builder.Services.AddTransient<ITransactionRepository2, TransactionRepository>();

//Context
builder.Services.AddTransient<TransactionContext>();


builder.Services.AddTransient<TransactionContext2>();

//builder.Services.AddTransient<TransactionContext3>();

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