using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;
using PoolCarManager.Desktop.Events;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Commands
{
    class AddJourneyCommandHandler : ICommandHandler<AddJourneyCommand>
    {
        public void Handle(AddJourneyCommand command)
        {
            using (var dialog = new JourneyDialog())
            {
                Journey journey;
                using (var session = new PoolCarManagerDataSession())
                {
                    Vehicle vehicle = session.RepositoryFor<Vehicle>().Get(command.VehicleId);

                    dialog.ViewModel = new JourneyDialogViewModel(
                        vehicle.Registration,
                        session.RepositoryFor<Driver>().GetAll(driver => true)
                        );
                
                    if (dialog.ShowDialog() != DialogResult.OK) return;

                    JourneyDialogViewModel model = dialog.ViewModel;
                    journey = vehicle.AddJourney(model.DriverId, model.FromLocation, model.ToLocation, model.Reason, model.StartMileage, model.EndMileage);
                }

                DomainEvents.Raise(new JourneyAddedEvent(journey));
            }
        }
    }
}