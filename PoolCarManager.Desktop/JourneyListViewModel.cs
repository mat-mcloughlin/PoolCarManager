using System;

namespace PoolCarManager.Desktop
{
    public class JourneyListViewModel
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