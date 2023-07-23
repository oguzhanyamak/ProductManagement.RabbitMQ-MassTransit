using ProductManagement.MessageContracts;
using MassTransit;
using ProductManagement.MessageContracts.Consumers;

var bus = BusConfigurator.ConfigureBus(factory =>
{
    factory.ReceiveEndpoint(RabbitMqConstants.FacebookServiceQueue, endpoint =>
    {
        endpoint.Consumer<ProductFacebookEventConsumer>();
    });
});

await bus.StartAsync();
await Task.Run(() => Console.ReadLine());
await bus.StopAsync();