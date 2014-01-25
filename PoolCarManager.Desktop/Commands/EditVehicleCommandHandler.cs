using System;
using System.Linq;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;
using PoolCarManager.Desktop.Events;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Commands
{
    public class EditVehicleCommandHandler : ICommandHandler<EditVehicleCommand>
    {
        public void Handle(EditVehicleCommand command)
        {
            using (var dialog = new EditVehicleDialog())
            {
                using (var session = new PoolCarManagerDataSession())
                {
                    Vehicle vehicle = session.RepositoryFor<Vehicle>().Get(command.VehicleId);
                    var journeys = (from j in vehicle.Journeys
                                        select new JourneyListViewModel
                                                   {
                                                       Id = j.Id,
                                                       DriverName = j.Driver.Name,
                                                       StartMileage = j.StartMileage,
                                                       EndMileage = j.EndMileage
                                                   }).ToList();

                    var model = new EditVehicleViewModel
                                    {
                                        Vehicle = vehicle,
                                        Journeys = journeys
                                    };

                    dialog.ViewModel = model;

                    if (dialog.ShowDialog() != DialogResult.OK) return;

                    session.SaveChanges();

                    DomainEvents.Raise(new VehicleEditedEvent(vehicle));
                }
            }

        }
    }
}