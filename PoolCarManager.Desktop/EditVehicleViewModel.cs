using System;
using System.Collections.Generic;
using PoolCarManager.Querying;

namespace PoolCarManager.Desktop
{
    public class EditVehicleViewModel
    {
        public Vehicle Vehicle { get; set; }

        public IEnumerable<JourneyListViewModel> Journeys { get; set; }
    }
}