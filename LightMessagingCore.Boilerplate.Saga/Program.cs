using System;
using System.Configuration;
using Automatonymous;
using LightMessagingCore.Boilerplate.Common;
using MassTransit.Saga;

namespace LightMessagingCore.Boilerplate.Saga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Saga";
            var orderSaga = new OrderSaga();
            var repo = new InMemorySagaRepository<OrderSagaState>();

            var bus = BusConfigurator.Instance
                .ConfigureBus((cfg, host) =>
                {
                    cfg.ReceiveEndpoint(host, ConfigurationManager.AppSettings["SagaQueueName"], e =>
                    {
                        e.StateMachineSaga(orderSaga, repo);
                    });
                });

            bus.StartAsync();

            Console.WriteLine("Order saga started..");
            Console.ReadLine();
        }
    }
}