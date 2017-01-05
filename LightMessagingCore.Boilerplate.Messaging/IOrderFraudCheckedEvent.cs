using System;

namespace LightMessagingCore.Boilerplate.Messaging
{
    public interface IOrderFraudCheckedEvent
    {
        Guid CorrelationId { get; set; }
        int OrderId { get; set; }
    }
}