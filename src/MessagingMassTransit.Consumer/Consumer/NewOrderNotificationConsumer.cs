using MassTransit;
using MessagingMassTransit.MessageBus.Events;
using System;
using System.Threading.Tasks;

namespace MessagingMassTransit.Consumer.Consumer
{
    class NewOrderNotificationConsumer : IConsumer<IOrderSubmittedEvent>
    {
        public async Task Consume(ConsumeContext<IOrderSubmittedEvent> context)
        {
            Console.WriteLine($"Notification Service - Order: id {context.Message.Id}, Time:{DateTime.Now}");
        }
    }
}
