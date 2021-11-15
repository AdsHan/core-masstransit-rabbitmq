using MessagingMassTransit.MessageBus.Commands;
using NotificationManagement.MessageBus;
using System;
using System.Threading.Tasks;

namespace NotificationManagement.Generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var busControl = BusFactory.ConfigureRabbitMQ();

            Console.WriteLine("Press any key to send message (or quit to exit)");
            while (true)
            {
                Console.Write("> ");
                string action = Console.ReadLine();

                if ("quit".Equals(action, StringComparison.OrdinalIgnoreCase)) break;

                var sendToUri = new Uri($"{BusFactory.RabbitMQCs}{BusFactory.OrderServiceQueue}");
                var endPoint = await busControl.GetSendEndpoint(sendToUri);

                await endPoint.Send<IOrderRegisterCommand>(new
                {
                    CustomerId = Guid.NewGuid(),
                    StartedIn = DateTime.Now,
                    Total = 1500.00,
                });

            }
        }
    }
}
