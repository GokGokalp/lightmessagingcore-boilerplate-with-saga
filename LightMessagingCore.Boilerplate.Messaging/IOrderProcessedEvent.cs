using System;

namespace LightMessagingCore.Boilerplate.Messaging
{
    public interface IOrderProcessedEvent
    {
        Guid CorrelationId { get; set; }
        int OrderId { get; set; }
    }
}