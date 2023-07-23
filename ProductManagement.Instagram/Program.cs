using MassTransit;
using ProductManagement.MessageContracts;
using ProductManagement.MessageContracts.Consumers;

var bus = BusConfigurator.ConfigureBus(factory =>
{
    factory.ReceiveEndpoint(RabbitMqConstants.InstagramServiceQueue, endpoint =>
    {
        endpoint.Consumer<ProductInstagramEventConsumer>();
    });
});

await bus.StartAsync();
await Task.Run(() => Console.ReadLine());
await bus.StopAsync();