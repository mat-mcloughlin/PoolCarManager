using System;
using PoolCarManager.Core.Commands;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Web.Commands
{
    public class AddVehicleCommandHandler : ICommandHandler<AddVehicleCommand>
    {
        public void Handle(AddVehicleCommand command)
        {
            var vehicle = new Vehicle
                              {
                                  Registration = command.Registration
                              };

            using (var session = new PoolCarManagerDataSession())
            {
                session.RepositoryFor<Vehicle>().Add(vehicle);
                session.SaveChanges();
            }
        }
    }
}