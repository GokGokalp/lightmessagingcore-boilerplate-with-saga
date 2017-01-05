using System;
using System.Configuration;
using LightMessagingCore.Boilerplate.Common;
using MassTransit;

namespace LightMessagingCore.Boilerplate.BillingService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BillingService";

            var bus = BusConfigurator.Instance
                .ConfigureBus((cfg, host) =>
                {
                    cfg.ReceiveEndpoint(host, ConfigurationManager.AppSettings["OrderQueueName"], e =>
                    {
                        e.Consumer<OrderProcessedConsumer>();
                    });
                });

            bus.StartAsync();

            Console.WriteLine("Listening order processed event..");
            Console.ReadLine();
        }
    }
}