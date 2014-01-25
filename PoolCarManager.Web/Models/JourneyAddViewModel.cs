using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PoolCarManager.Querying;

namespace PoolCarManager.Web.Models
{
    public class JourneyAddViewModel
    {
        public string Registration { get; set; }

        public IEnumerable<Driver> Drivers { get; set; }

        public int VehicleId { get; set; }

        [Required]
        [Display(Name = "Driver")]
        public int DriverId { get; set; }

        [Required]
        [Display(Name = "From")]
        public string FromLocation { get; set; }

        [Required]
        [Display(Name = "To")]
        public string ToLocation { get; set; }

        [Required]
        [Display(Name = "Reason")]
        public string Reason { get; set; }

        [Required]
        [Display(Name = "Start Mileage")]
        public int StartMileage { get; set; }

        [Required]
        [Display(Name = "End Mileage")]
        public int EndMileage { get; set; }
    }
}