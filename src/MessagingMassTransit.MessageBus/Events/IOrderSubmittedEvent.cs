using System;

namespace MessagingMassTransit.MessageBus.Events
{
    public interface IOrderSubmittedEvent
    {
        public Guid Id { get; set; }
    }
}