using System;
using System.Threading.Tasks;
using LightMessagingCore.Boilerplate.Messaging;
using MassTransit;

namespace LightMessagingCore.Boilerplate.BillingService
{
    public class OrderProcessedConsumer : IConsumer<IOrderProcessedEvent>
    {
        public async Task Consume(ConsumeContext<IOrderProcessedEvent> context)
        {
            var orderCommand = context.Message;

            await Console.Out.WriteLineAsync($"Order id: {orderCommand.OrderId} is being billed.");
        }
    }
}