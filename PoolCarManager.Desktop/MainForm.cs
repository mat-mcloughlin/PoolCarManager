using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;
using PoolCarManager.Desktop.Commands;
using PoolCarManager.Desktop.Events;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop
{
    public partial class MainForm : Form, IHandleDomainEvent<VehicleEditedEvent>
    {
        public MainForm()
        {
            InitializeComponent();

            DomainEvents.Subscribe<VehicleEditedEvent>(this);

            LoadVehicles();
        }

        private void LoadVehicles()
        {
            vehicleListView.BeginUpdate();
            try
            {
                using (var db = new PoolCarManagerDataContext())
                {
                    var vehicles = db.Vehicles.Select(vehicle => BuildVehicleListItemViewModel(vehicle));

                    foreach (var vehicle in vehicles)
                    {
                        AddOrUpdateListItem(vehicle);
                    }
                }
            }
            finally
            {
                vehicleListView.EndUpdate();
            }
        }

        private static VehicleListItemViewModel BuildVehicleListItemViewModel(Vehicle vehicle)
        {
            return new VehicleListItemViewModel {Id = vehicle.Id, Registration = vehicle.Registration, Description = vehicle.Description};
        }

        private void AddOrUpdateListItem(VehicleListItemViewModel vehicle)
        {
            string key = vehicle.Id.ToString();

            ListViewItem li = vehicleListView.Items[key];
            if (li == null)
            {
                li = new ListViewItem {Name = key, Tag = vehicle, ImageIndex = 0};
                li.SubItems.Add("");
                vehicleListView.Items.Add(li);
            }

            if (li.Text != vehicle.Registration) li.Text = vehicle.Registration;
            if (li.SubItems[1].Text != vehicle.Description) li.SubItems[1].Text = vehicle.Description;
        }
        
        public void HandleDomainEvent(VehicleEditedEvent evt)
        {
            AddOrUpdateListItem(BuildVehicleListItemViewModel(evt.Vehicle));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DomainEvents.Unsubscribe<VehicleEditedEvent>(this);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            CommandProcessor.Process(new AddVehicleCommand());
        }

        private void vehicleDetailsButton_Click(object sender, EventArgs e)
        {
            if (vehicleListView.SelectedItems.Count == 0) return;
            var viewModel = (VehicleListItemViewModel)vehicleListView.SelectedItems[0].Tag;

            CommandProcessor.Process(new EditVehicleCommand(viewModel.Id));
        }

        private void addJourneyButton_Click(object sender, EventArgs e)
        {
            if (vehicleListView.SelectedItems.Count == 0) return;
            var viewModel = (VehicleListItemViewModel)vehicleListView.SelectedItems[0].Tag;
            var vehicleId = viewModel.Id;

            CommandProcessor.Process(new AddJourneyCommand(vehicleId));
        }
    }
}
