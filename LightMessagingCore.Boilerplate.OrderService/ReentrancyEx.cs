using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;

namespace LightMessagingCore.Boilerplate.OrderService
{
    public static class ReentrancyEx
    {
        public static ConsumeContext<T> Reentrancy<T>(this ConsumeContext<T> context, Enums.ReentrancyFlow reentrancyFlow = Enums.ReentrancyFlow.Ignore) where T : class
        {
            switch (reentrancyFlow)
            {
                case Enums.ReentrancyFlow.Ignore:
                    break;
                case Enums.ReentrancyFlow.ThrowException:
                    break;
                default:
                    break;
            }

            return context;
        }
    }
}
