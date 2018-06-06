using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsTestWebApp.Models
{
    public static class FlightBLL
    {

      public static List<FlightDAO> GetFlights()
      {
            return FlightDAL.GetFlights();
      }

        public static List<AirportDAO> GetAirports()
        {
            return FlightDAL.GetAirports();
        }


        public static void AddFlight(FlightDAO flight)
        {
            FlightDAL.SaveFlight(flight);
        }

    }
}