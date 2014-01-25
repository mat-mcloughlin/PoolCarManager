using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Events
{
    public class VehicleAddedEvent
    {
        public Vehicle Vehicle { get; set; }

        public VehicleAddedEvent(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
    }
}