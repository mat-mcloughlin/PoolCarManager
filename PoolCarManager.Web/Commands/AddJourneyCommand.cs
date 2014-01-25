using System;

namespace PoolCarManager.Web.Commands
{
    public class AddJourneyCommand
    {
        public int DriverId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public string Reason { get; set; }
        public int StartMileage { get; set; }
        public int EndMileage { get; set; }
        public int VehicleId { get; set; }
    }
}