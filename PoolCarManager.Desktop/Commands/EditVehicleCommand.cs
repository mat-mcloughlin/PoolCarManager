using System;
using PoolCarManager.Core.Commands;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Commands
{
    public class EditVehicleCommand : ICommand
    {
        public int VehicleId { get; private set; }

        public EditVehicleCommand(int vehicleId)
        {
            VehicleId = vehicleId;
        }
    }
}