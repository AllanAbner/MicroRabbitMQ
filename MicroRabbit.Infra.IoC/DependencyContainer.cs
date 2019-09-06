using MicroRabbit.Domain.Core.Bus;
using MicroRabit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void Register(IServiceCollection services)
        {
            //Domain bus

            services.AddTransient<IEventBus,RabbitMQBus>
        }
    }
}
