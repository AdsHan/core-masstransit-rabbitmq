using System;

namespace MessagingMassTransit.MessageBus.Commands
{
    public interface IOrderRegisterCommand
    {
        public Guid CustomerId { get; set; }
        public DateTime StartedIn { get; set; }
        public decimal Total { get; set; }
    }
}