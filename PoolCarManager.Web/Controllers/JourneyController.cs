using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PoolCarManager.Core.Commands;
using PoolCarManager.Model;
using PoolCarManager.Querying;
using PoolCarManager.Web.Commands;
using PoolCarManager.Web.Models;

namespace PoolCarManager.Web.Controllers
{
    public class JourneyController : Controller
    {
        public ActionResult Add(int id)
        {
            JourneyAddViewModel model;
            using (var session = new PoolCarManagerDataSession())
            {
                var vehicle = session.RepositoryFor<Vehicle>().Get(id);

                model = new JourneyAddViewModel
                            {
                                VehicleId = vehicle.Id,
                                Registration = vehicle.Registration,
                                Drivers = session.RepositoryFor<Driver>().GetAll(driver => true)
                            };
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(JourneyAddViewModel model)
        {
            CommandProcessor.Process(new AddJourneyCommand
                                         {
                                             VehicleId = model.VehicleId,
                                             DriverId = model.DriverId,
                                             FromLocation = model.FromLocation,
                                             ToLocation = model.ToLocation,
                                             Reason = model.Reason,
                                             StartMileage = model.StartMileage,
                                             EndMileage = model.EndMileage
                                         });

            return RedirectToAction("Index", "Vehicle");
        }

    }
}
