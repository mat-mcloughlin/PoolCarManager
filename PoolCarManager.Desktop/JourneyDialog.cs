using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop
{
    public partial class JourneyDialog : Form
    {
        private JourneyDialogViewModel _viewModel;
        public JourneyDialogViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                SetBindings();
            }
        }

        public JourneyDialog()
        {
            InitializeComponent();
        }

        private void SetBindings()
        {
            label1.Text = string.Format("Add journey for {0}", ViewModel.Registration);

            driverCombo.ValueMember = "Id";
            driverCombo.DisplayMember = "Name";
            driverCombo.DataSource = ViewModel.Drivers;
            driverCombo.DataBindings.Add(new Binding("SelectedValue", ViewModel, "DriverId"));

            SetTextBoxBinding(fromTextBox, "FromLocation");
            SetTextBoxBinding(toTextBox, "ToLocation");
            SetTextBoxBinding(reasonTextBox, "Reason");
            SetTextBoxBinding(startMileageTextBox, "StartMileage");
            SetTextBoxBinding(endMileageTextBox, "EndMileage");
        }

        private void SetTextBoxBinding(TextBox textBox, string dataMemberName)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add(new Binding("Text", ViewModel, dataMemberName));
        }
    }
}
