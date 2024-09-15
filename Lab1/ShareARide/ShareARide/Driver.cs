using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
    public class Driver:User
    {
        public string VehicleType { get; set; }
        public bool IsAvailable { get; set; }

       /* public Driver(int id, string name,string location,double rating,string vehicletype*//*, bool available*//*) :base(id,name,location,rating)
        {
            this.VehicleType = VehicleType;
            this.IsAvailable = true;
        }*/
        public Driver() : base() { }

        public void AcceptRide() { }
        public void RateRider(Rider rider) { }
        
        public void StartTrip()
        {
            Console.WriteLine("The trip has started");
        }



        




    }
}
