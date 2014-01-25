using System;

namespace PoolCarManager.Web.Models
{
    public class JourneyListItemViewModel
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public int StartMileage { get; set; }
        public int EndMileage { get; set; }

        public int Distance
        {
            get { return EndMileage - StartMileage; }
        }
    }
}