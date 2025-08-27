namespace DevTrackR.Tracking.Infrastructure.Messaging
{
    public interface IMessageBusService
    {
        Task PublishAsync(object data, string routingKey);
    }
}
