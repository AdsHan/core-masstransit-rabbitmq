using MassTransit;
using MessagingMassTransit.MessageBus.Events;
using System;
using System.Threading.Tasks;

namespace MessagingMassTransit.Consumer.Consumer
{
    class OrderCalculateRewardsConsumer : IConsumer<IOrderSubmittedEvent>
    {
        public async Task Consume(ConsumeContext<IOrderSubmittedEvent> context)
        {
            Console.WriteLine($"Rewards Service - id {context.Message.Id}, Time:{DateTime.Now}");
        }
    }
}
