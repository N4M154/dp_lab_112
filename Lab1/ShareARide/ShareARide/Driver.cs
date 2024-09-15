using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
    public class Driver
    {
        public int DriverID;
        public string DriverName;
        public string VehicleType;
        public string DriverLocation;
        public double RatingofRider;
        public bool IsAvailable;

        public void AcceptRide() { }
        public void RateRider() { }

        public void UpdateLocation(string DriverLocation) { }

        public void StartTrip() { }




    }
}
