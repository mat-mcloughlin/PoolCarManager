using System;
using System.Collections.Generic;

namespace PoolCarManager.Web.Models
{
    public class VehicleEditViewModel
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public string Description { get; set; }
        public IEnumerable<JourneyListItemViewModel> Journeys { get; set; }
    }
}