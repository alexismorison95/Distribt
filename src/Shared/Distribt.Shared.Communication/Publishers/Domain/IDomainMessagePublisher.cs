﻿using Distribt.Shared.Communication.Messages;

namespace Distribt.Shared.Communication.Publishers.Domain
{
    public interface IDomainMessagePublisher
    {
        Task Publish(object message, Metadata? metadata = null, string? routingKey = null, CancellationToken cancellationToken = default);

        Task PublishMany(IEnumerable<object> messages, Metadata? metadata = null, string? routingKey = null, CancellationToken cancellationToken = default);
    }
}
