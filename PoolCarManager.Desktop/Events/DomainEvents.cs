using System;
using System.Collections.Generic;

namespace PoolCarManager.Desktop.Events
{
    public class DomainEvents
    {
        private static readonly IDictionary<Type, IList<object>> __subscriberMap = new Dictionary<Type, IList<object>>();

        public static void Subscribe<TEvent>(IHandleDomainEvent<TEvent> subscriber)
        {
            if (subscriber == null) throw new ArgumentNullException("subscriber");

            IList<object> subscribers = GetSubscribers<TEvent>();

            subscribers.Add(subscriber);
        }

        private static IList<object> GetSubscribers<TEvent>()
        {
            Type key = typeof(TEvent);
            IList<object> subscribers;
            if (!__subscriberMap.TryGetValue(key, out subscribers))
            {
                subscribers = new List<object>();
                __subscriberMap.Add(key, subscribers);
            }
            return subscribers;
        }

        public static void Unsubscribe<TEvent>(IHandleDomainEvent<TEvent> subscriber)
        {
            
        }

        public static void Raise<TEvent>(TEvent evt)
        {
            foreach (var subscriber in GetSubscribers<TEvent>())
            {
                ((IHandleDomainEvent<TEvent>)subscriber).HandleDomainEvent(evt);
            }
        }
    }
}