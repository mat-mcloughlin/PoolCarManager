using System;

namespace PoolCarManager.Web.Commands
{
    public class EditVehicleCommand
    {
        public int VehicleId { get; private set; }
        public string Registration { get; private set; }
        public string Description { get; private set; }

        public EditVehicleCommand(int vehicleId, string registration, string description)
        {
            VehicleId = vehicleId;
            Registration = registration;
            Description = description;
        }
    }
}