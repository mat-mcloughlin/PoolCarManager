using System;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Events
{
    public class VehicleEditedEvent
    {
        public Vehicle Vehicle { get; private set; }

        public VehicleEditedEvent(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
    }
}