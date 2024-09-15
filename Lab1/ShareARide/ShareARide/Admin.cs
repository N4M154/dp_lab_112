using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
    public class Admin
    {
        public int AdminID {  get; set; }
        public string AdminName { get; set; }
        public string Role {  get; set; }

        public Admin() { }
        public void ManageDriver(Driver driver) { }
        public void ManageRider(Rider rider) { }
        public void ViewTripHistory(Trip trip) { }

        public void HandleDispute() { }
    }
}
