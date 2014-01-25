using System;
using PoolCarManager.Core.Commands;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Web.Commands
{
    public class EditVehicleCommandHandler : ICommandHandler<EditVehicleCommand>
    {
        public void Handle(EditVehicleCommand command)
        {
            using (var session = new PoolCarManagerDataSession())
            {
                var vehicle = session.RepositoryFor<Vehicle>().Get(command.VehicleId);

                vehicle.Registration = command.Registration;
                vehicle.Description = command.Description;

                session.SaveChanges();
            }
        }
    }
}