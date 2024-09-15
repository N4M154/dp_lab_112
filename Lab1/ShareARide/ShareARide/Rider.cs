using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
     
    public class Rider:User
    {
        public string PrefferedPaymentMethod {  get; set; }

        /* public Rider(int id,string name,string location,double rating,string preferredpayment):base(id,name,location,rating)
         {
             this.PrefferedPaymentMethod = PrefferedPaymentMethod;
         }*/
        public Rider() : base() { }
        public void RequestRide(string Pickup,string dropoff)
        {

        }
        public void RateDriver(Driver driver) { }
        public void MakePayment(double amount) { }

    }
}
