
namespace Distribt.Shared.Communication.Consumers.Manager
{
    public interface IConsumerManager<TMessage>
    {
        void RestartExecution();

        void StopExecution();

        CancellationToken GetCancellationToken();
    }
}
