using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlightsTestWebApp.Models;

namespace FlightsTestWebApp.Controllers
{
    public class FlightController : Controller
    {
        // GET: Flight
        public ActionResult Index()
        {
            return View(FlightBLL.GetFlights());
        }

        public ActionResult NewFlight()
        {
            ViewData["Airports"] = FlightBLL.GetAirports();

            return View();
        }

        public void SaveFlight(FlightDAO flight)
        {
            FlightBLL.AddFlight(flight);
        }


    }
}