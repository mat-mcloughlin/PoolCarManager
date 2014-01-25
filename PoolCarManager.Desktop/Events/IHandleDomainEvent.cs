namespace PoolCarManager.Desktop.Events
{
    public interface IHandleDomainEvent<TEvent>
    {
        void HandleDomainEvent(TEvent evt);
    }
}