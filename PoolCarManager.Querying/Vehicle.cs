using System;
using PoolCarManager.Core;

namespace PoolCarManager.Querying
{
    public partial class Vehicle : IIdentifiable
    {
        public Journey AddJourney(int driverId, string fromLocation, string toLocation, string reason, int startMileage, int endMileage)
        {
            var journey = new Journey
                              {
                                  DriverId = driverId,
                                  FromLocation = fromLocation,
                                  ToLocation = toLocation,
                                  Reason = reason,
                                  StartMileage = startMileage,
                                  EndMileage = endMileage
                              };
            Journeys.Add(journey);

            return journey;
        }
    }
}