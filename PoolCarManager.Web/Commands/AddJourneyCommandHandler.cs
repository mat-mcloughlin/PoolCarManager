using System;
using PoolCarManager.Core.Commands;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Web.Commands
{
    public class AddJourneyCommandHandler : ICommandHandler<AddJourneyCommand>
    {
        public void Handle(AddJourneyCommand command)
        {
            using (var session = new PoolCarManagerDataSession())
            {
                var vehicle = session.RepositoryFor<Vehicle>().Get(command.VehicleId);

                vehicle.AddJourney(command.DriverId, command.FromLocation, command.ToLocation, command.Reason, command.StartMileage, command.EndMileage);
            }
        }
    }
}