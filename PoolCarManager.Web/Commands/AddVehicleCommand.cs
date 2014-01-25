using System;

namespace PoolCarManager.Web.Commands
{
    public class AddVehicleCommand
    {
        public string Registration { get; set; }
        public string Description { get; set; }

        public AddVehicleCommand(string registration, string description)
        {
            Registration = registration;
            Description = description;
        }
    }
}