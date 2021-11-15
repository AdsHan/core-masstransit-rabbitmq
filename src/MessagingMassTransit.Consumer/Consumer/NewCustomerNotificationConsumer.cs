using MassTransit;
using MessagingMassTransit.MessageBus.Events;
using System;
using System.Threading.Tasks;

namespace MessagingMassTransit.Consumer.Consumer
{
    class NewCustomerNotificationConsumer : IConsumer<ICustomerSubmittedEvent>
    {
        public async Task Consume(ConsumeContext<ICustomerSubmittedEvent> context)
        {
            Console.WriteLine($"Notification Service - Customer: id {context.Message.Id}, Time:{DateTime.Now}");
        }
    }
}
