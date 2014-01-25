using System;
using System.Collections.Generic;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop
{
    public class JourneyDialogViewModel
    {
        public string Registration { get; private set; }
        public IEnumerable<Driver> Drivers { get; private set; }
        public int DriverId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public string Reason { get; set; }
        public int StartMileage { get; set; }
        public int EndMileage { get; set; }

        public JourneyDialogViewModel(string registration, IEnumerable<Driver> drivers)
        {
            Registration = registration;
            Drivers = drivers;
        }
    }
}