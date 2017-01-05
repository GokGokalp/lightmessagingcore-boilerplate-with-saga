using System;

namespace LightMessagingCore.Boilerplate.Messaging
{
    public interface IOrderReceivedEvent
    {
        Guid CorrelationId { get; }
        int OrderId { get; }
        string OrderCode { get; }
    }
}