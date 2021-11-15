using MassTransit;
using MessagingMassTransit.MessageBus.Commands;
using MessagingMassTransit.MessageBus.Events;
using System;
using System.Threading.Tasks;

namespace MessagingMassTransit.Consumer.Consumer
{
    class OrderRegisterConsumer : IConsumer<IOrderRegisterCommand>
    {
        public async Task Consume(ConsumeContext<IOrderRegisterCommand> context)
        {
            var id = Guid.NewGuid();

            Console.WriteLine($"Register Service - Id:{id}, Time:{DateTime.Now}");

            await context.Publish<IOrderSubmittedEvent>(new
            {
                Id = id
            });
        }
    }
}
