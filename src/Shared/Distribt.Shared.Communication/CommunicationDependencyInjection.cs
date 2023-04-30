﻿using Distribt.Shared.Communication.Consumers.Host;
using Distribt.Shared.Communication.Consumers.Manager;
using Distribt.Shared.Communication.Messages;
using Distribt.Shared.Communication.Publishers.Domain;
using Distribt.Shared.Communication.Publishers.Integration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Distribt.Shared.Communication
{
    public static class CommunicationDependencyInjection
    {
        public static void AddConsumer<TMessage>(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IConsumerManager<TMessage>, ConsumerManager<TMessage>>();
            serviceCollection.AddSingleton<IHostedService, ConsumerHostedService<TMessage>>();
        }

        public static void AddPublisher<TMessage>(this IServiceCollection serviceCollection)
        {
            if (typeof(TMessage) == typeof(IntegrationMessage))
            {
                serviceCollection.AddIntegrationBusPublisher();
            }

            else if (typeof(TMessage) == typeof(DomainMessage))
            {
                serviceCollection.AddDomainBusPublisher();
            }
        }

        private static void AddIntegrationBusPublisher(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IIntegrationMessagePublisher, DefaultIntegrationMessagePublisher>();
        }


        private static void AddDomainBusPublisher(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDomainMessagePublisher, DefaultDomainMessagePublisher>();
        }
    }
}
