using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsTestWebApp.Models
{
    public class FlightDAO
    {
        private int _Id;
        private string _FlightNumber;
        private int? _Departure_aeroport;
        private int? _Destination_aeroport;
        private TimeSpan? _Departure_Time;
        private TimeSpan? _Arriving_Time;

        public int Id { get => _Id; set => _Id = value; }
        public string FlightNumber { get => _FlightNumber; set => _FlightNumber = value; }
        public int? Departure_aeroport { get => _Departure_aeroport; set => _Departure_aeroport = value; }
        public int? Destination_aeroport { get => _Destination_aeroport; set => _Destination_aeroport = value; }
        public TimeSpan? Departure_Time { get => _Departure_Time; set => _Departure_Time = value; }
        public TimeSpan? Arriving_Time { get => _Arriving_Time; set => _Arriving_Time = value; }
    }

    public class AirportDAO
    {
        private int _Id;
        private string _Name;
        private int? GPSX;
        private int? GPSY;
        private string _State;

        public int Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public int? GPSX1 { get => GPSX; set => GPSX = value; }
        public int? GPSY1 { get => GPSY; set => GPSY = value; }
        public string State { get => _State; set => _State = value; }
    }
}