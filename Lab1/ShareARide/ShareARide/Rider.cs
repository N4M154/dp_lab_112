using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
    public class Rider
    {
        public int RiderID;
        public string RiderName;
        public string RiderLocation;
        public double RatingofDriver;
        public string PreferredPayMethod;

        public Rider() { }

        public void ReqRide() { }

        public void BookTrip(string RiderLocation) { }

        public void RateDriver() { }

        public void MakePayment(string PrefferedPayMethod) { }

    }
}
