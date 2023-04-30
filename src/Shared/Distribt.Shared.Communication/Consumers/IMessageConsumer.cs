
namespace Distribt.Shared.Communication.Consumers
{
    public interface IMessageConsumer
    {
        Task StartAsync(CancellationToken cancelToken = default);
    }

    public interface IMessageConsumer<T> : IMessageConsumer
    {
    }
}
