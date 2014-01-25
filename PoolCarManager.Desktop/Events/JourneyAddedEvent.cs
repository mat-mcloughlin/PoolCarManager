using System;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Events
{
    public class JourneyAddedEvent
    {
        public Journey Journey { get; private set; }

        public JourneyAddedEvent(Journey journey)
        {
            Journey = journey;
        }
    }
}