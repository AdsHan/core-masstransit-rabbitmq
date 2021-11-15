using GreenPipes;
using MassTransit;
using MessagingMassTransit.Consumer.Consumer;
using Microsoft.Extensions.Hosting;
using NotificationManagement.MessageBus;
using System.Threading;
using System.Threading.Tasks;

namespace NotificationManagement.Worker
{
    public class Worker : BackgroundService
    {
        IBusControl busControl;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            var busControl = BusFactory.ConfigureRabbitMQ((config) =>
            {

                config.ReceiveEndpoint(BusFactory.OrderServiceQueue, endPoint =>
                {
                    endPoint.Consumer<OrderRegisterConsumer>();
                    endPoint.UseMessageRetry(r => r.Immediate(5));
                });

                config.ReceiveEndpoint(BusFactory.RewardsServiceQueue, endPoint =>
                {
                    endPoint.Consumer<OrderCalculateRewardsConsumer>();
                    endPoint.UseMessageRetry(r => r.Immediate(5));
                });

                config.ReceiveEndpoint(BusFactory.NotificationServiceQueue, endPoint =>
                {
                    endPoint.Consumer<NewOrderNotificationConsumer>();
                    endPoint.Consumer<NewCustomerNotificationConsumer>();
                    endPoint.UseMessageRetry(r => r.Immediate(5));
                });

            });

            busControl.StartAsync();
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            busControl.StopAsync();

            return base.StopAsync(cancellationToken);
        }
    }
}
