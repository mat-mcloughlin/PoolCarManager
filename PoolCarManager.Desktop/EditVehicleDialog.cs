using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;
using PoolCarManager.Desktop.Commands;
using PoolCarManager.Desktop.Events;
using PoolCarManager.Model;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop
{
    public partial class EditVehicleDialog : Form, IHandleDomainEvent<JourneyAddedEvent>
    {
        private EditVehicleViewModel _viewModel;

        public EditVehicleViewModel ViewModel
        {
            get {
                return _viewModel;
            }
            set {
                _viewModel = value;
                SetBindings();
            }
        }

        public EditVehicleDialog()
        {
            InitializeComponent();

            DomainEvents.Subscribe<JourneyAddedEvent>(this);
        }

        private void SetBindings()
        {
            registrationTextBox.DataBindings.Clear();
            descriptionTextBox.DataBindings.Clear();

            registrationTextBox.DataBindings.Add(new Binding("Text", ViewModel.Vehicle, "Registration"));
            descriptionTextBox.DataBindings.Add(new Binding("Text", ViewModel.Vehicle, "Description"));

            journeyListView.BeginUpdate();
            try
            {
                foreach (var journey in ViewModel.Journeys)
                {
                    AddOrUpdateJourneyInListView(journey);
                }
            }
            finally
            {
                journeyListView.EndUpdate();
            }
        }

        private void AddOrUpdateJourneyInListView(JourneyListViewModel journey)
        {
            string key = journey.Id.ToString();
            ListViewItem li = journeyListView.Items[key];

            if (li == null)
            {
                li = new ListViewItem {Name = key, Tag = journey};
                li.SubItems.Add("");
                li.SubItems.Add("");
                li.SubItems.Add("");
                journeyListView.Items.Add(li);
            }

            SetListViewSubItemText(li.SubItems[0], journey.DriverName);
            SetListViewSubItemText(li.SubItems[1], journey.StartMileage.ToString());
            SetListViewSubItemText(li.SubItems[2], journey.EndMileage.ToString());
            SetListViewSubItemText(li.SubItems[3], journey.Distance.ToString());
        }

        private static void SetListViewSubItemText(ListViewItem.ListViewSubItem subItem, string text)
        {
            if (subItem.Text != text) subItem.Text = text;
        }

        private void addJourneyButton_Click(object sender, EventArgs e)
        {
            CommandProcessor.Process(new AddJourneyCommand(ViewModel.Vehicle.Id));
        }

        public void HandleDomainEvent(JourneyAddedEvent evt)
        {
            JourneyListViewModel journey;
            using (var session = new PoolCarManagerDataContext())
            {
                journey = (from j in session.Journeys
                           where j.Id == evt.Journey.Id
                           select new JourneyListViewModel
                                      {
                                          Id = evt.Journey.Id,
                                          DriverName = evt.Journey.Driver.Name,
                                          StartMileage = evt.Journey.StartMileage,
                                          EndMileage = evt.Journey.EndMileage
                                      }).SingleOrDefault();
            }

            AddOrUpdateJourneyInListView(journey);
        }

        private void EditVehicleDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            DomainEvents.Unsubscribe<JourneyAddedEvent>(this);
        }
    }
}
