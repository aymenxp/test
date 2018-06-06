using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsTestWebApp.Models
{
    public static class FlightDAL
    {
        static flightdbEntities db;

        static FlightDAL()
        {
            db = new flightdbEntities();
        }

        public static List<FlightDAO> GetFlights()
        {
            List<FlightDAO> ListFlights = db.Flights.Select(x => new FlightDAO
            {
                Id = x.Id,
                Arriving_Time = x.Arriving_Time,
                Departure_aeroport = x.Departure_aeroport,
                Departure_Time = x.Departure_Time,
                Destination_aeroport = x.Destination_aeroport,
                FlightNumber = x.FlightNumber
            }
            ).ToList();

            return ListFlights;
        }


        public static void SaveFlight(FlightDAO flight)
        {
            Flight f = new Flight();

            f.Arriving_Time = flight.Arriving_Time;
            f.Departure_aeroport = flight.Departure_aeroport;
            f.Departure_Time = flight.Departure_Time;
            f.Destination_aeroport = flight.Destination_aeroport;
            f.FlightNumber = flight.FlightNumber;

            db.Flights.Add(f);
            db.SaveChanges();
        }


        public static List<AirportDAO> GetAirports()
        {
            List<AirportDAO> ListAirports = db.Airports.Select(x => new AirportDAO
            {
                Id = x.Id,
                Name = x.Name,
                GPSX1 = x.GPSX,
                GPSY1 = x.GPDY,
                State = x.State
            }
            ).ToList();

            return ListAirports;
        }

    }
}