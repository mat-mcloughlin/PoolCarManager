using System;
using PoolCarManager.Core.Commands;

namespace PoolCarManager.Desktop.Commands
{
    public class AddJourneyCommand : ICommand
    {
        public int VehicleId { get; private set; }

        public AddJourneyCommand(int vehicleId)
        {
            VehicleId = vehicleId;
        }
    }
}