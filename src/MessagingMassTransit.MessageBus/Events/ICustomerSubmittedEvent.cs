using System;

namespace MessagingMassTransit.MessageBus.Events
{
    public interface ICustomerSubmittedEvent
    {
        public Guid Id { get; set; }
    }
}