using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightMessagingCore.Boilerplate.OrderService
{
    public static class Enums
    {
        public enum ReentrancyFlow
        {
            Ignore,
            ThrowException
        }
    }
}
