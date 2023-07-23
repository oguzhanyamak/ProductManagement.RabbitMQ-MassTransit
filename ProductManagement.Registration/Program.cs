using MassTransit;
using ProductManagement.MessageContracts;
using ProductManagement.Registration.Consumers;

var bus = BusConfigurator.ConfigureBus(factory =>
{
    factory.ReceiveEndpoint(RabbitMqConstants.RegistrationServiceQueue, endpoint =>
    {
        endpoint.Consumer<ProductRegistrationCommandConsumer>();
    });
});

await bus.StartAsync();
await Task.Run(() => Console.ReadLine());
await bus.StopAsync();