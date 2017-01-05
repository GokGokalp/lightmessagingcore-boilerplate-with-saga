using Automatonymous;
using System;

namespace LightMessagingCore.Boilerplate.Saga
{
    public class OrderSagaState : SagaStateMachineInstance
    {
        public Guid CorrelationId { get; set; }
        public State CurrentState { get; set; }

        public int OrderId { get; set; }
        public string OrderCode { get; set; }
    }
}