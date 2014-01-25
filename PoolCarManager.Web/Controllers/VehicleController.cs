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
    public class VehicleController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<VehicleIndexItemViewModel> viewModel;
            using (var db = new PoolCarManagerDataContext())
            {
                viewModel = db.Vehicles.Select(vehicle =>
                                               new VehicleIndexItemViewModel
                                                   {
                                                       Id = vehicle.Id,
                                                       Registration = vehicle.Registration,
                                                       Description = vehicle.Description
                                                   }).ToList();
            }

            return View(viewModel);
        }

        public ActionResult Add()
        {
            return View(new VehicleAddViewModel());
        }

        [HttpPost]
        public ActionResult Add(VehicleAddViewModel model)
        {
            CommandProcessor.Process(new AddVehicleCommand(model.Registration, model.Description));

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            VehicleEditViewModel model;
            using (var session = new PoolCarManagerDataSession())
            {
                var vehicle = session.RepositoryFor<Vehicle>().Get(id);

                model = new VehicleEditViewModel
                            {
                                Id = vehicle.Id,
                                Registration = vehicle.Registration,
                                Description = vehicle.Description,
                                Journeys = (from j in vehicle.Journeys
                                            select new JourneyListItemViewModel
                                                       {
                                                           Id = j.Id,
                                                           DriverName = j.Driver.Name,
                                                           StartMileage = j.StartMileage,
                                                           EndMileage = j.EndMileage
                                                       }).ToList()
                            };
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(VehicleEditViewModel model)
        {
            CommandProcessor.Process(new EditVehicleCommand(model.Id, model.Registration, model.Description));

            return RedirectToAction("Index");
        }
    }
}
