using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
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
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application
            services.AddTransient<IAccountService, AccountService>();

            //Repository
            services.AddTransient<IAccountRepository, AccountRepository>();

            //Data
            services.AddTransient<BankingDbContext>();


        }
    }
}
