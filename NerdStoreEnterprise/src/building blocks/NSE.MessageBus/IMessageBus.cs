﻿using NSE.Core.Messages.Integration;
using System;
using System.Threading.Tasks;

namespace NSE.MessageBus
{
    public interface IMessageBus : IDisposable
    {
        void Publish<T>(T message) where T : IntegrationEvent;
        Task PublishAsync<T>(T message) where T : IntegrationEvent;
        void Subscribe<T>(string subscriptionId, Action<T> onMessage) where T : class;
        void SubscribeAsync<T>(string subscriptionId, Action<T, Task> onMessage) where T : class;
    }
}