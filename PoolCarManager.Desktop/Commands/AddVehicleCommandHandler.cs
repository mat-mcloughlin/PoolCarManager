using System.Collections.Generic;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;
using PoolCarManager.Desktop.Events;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop.Commands
{
    public class AddVehicleCommandHandler : ICommandHandler<AddVehicleCommand>
    {
        public void Handle(AddVehicleCommand command)
        {
            var vehicle = new Vehicle();

            using (var dialog = new EditVehicleDialog())
            {
                var viewModel = new EditVehicleViewModel();

                viewModel.Vehicle = vehicle;
                viewModel.Journeys = new List<JourneyListViewModel>();

                dialog.ViewModel = viewModel;

                if (dialog.ShowDialog() != DialogResult.OK) return;

                using (var session = new PoolCarManagerDataSession())
                {
                    session.RepositoryFor<Vehicle>().Add(vehicle);
                    session.SaveChanges();
                }

                DomainEvents.Raise(new VehicleAddedEvent(vehicle));
            }
        }
    }
}