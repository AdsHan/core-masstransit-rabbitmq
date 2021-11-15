using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace NotificationManagement.MessageBus
{
    public static class BusFactory
    {
        public const string RabbitMQCs = "rabbitmq://localhost/";
        public const string UserName = "admin";
        public const string Password = "admin";

        public const string OrderServiceQueue = "order-service";
        public const string RewardsServiceQueue = "rewards-service";
        public const string NotificationServiceQueue = "notification-service";

        public static IBusControl ConfigureRabbitMQ(Action<IRabbitMqBusFactoryConfigurator> action = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(RabbitMQCs), hst =>
                {
                    hst.Username(UserName);
                    hst.Password(Password);
                });

                action?.Invoke(cfg);
            });
        }
    }

}
