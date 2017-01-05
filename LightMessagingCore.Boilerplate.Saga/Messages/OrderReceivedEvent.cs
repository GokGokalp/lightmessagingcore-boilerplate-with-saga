using System;
using LightMessagingCore.Boilerplate.Messaging;

namespace LightMessagingCore.Boilerplate.Saga.Messages
{
    public class OrderReceivedEvent : IOrderReceivedEvent
    {
        private readonly OrderSagaState _orderSagaState;

        public OrderReceivedEvent(OrderSagaState orderSagaState)
        {
            _orderSagaState = orderSagaState;
        }

        public Guid CorrelationId => _orderSagaState.CorrelationId;

        public string OrderCode => _orderSagaState.OrderCode;

        public int OrderId => _orderSagaState.OrderId;
    }
}