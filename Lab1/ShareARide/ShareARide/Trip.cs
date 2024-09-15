using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareARide
{
    public class Trip
    {
        public int TripID;
        public Rider Rider;
        public Driver Driver;
        public string PickupLocation;
        public string DropOffLocation;
        public double Fare;
        public string Status;
        public double Distance;
        public RideType RideType;

        public Trip(Rider rider,Driver driver)//pickup and dropoff can change so it shouldn't be in this constructor.
        {
            this.Rider = rider;
            /*this.PickupLocation = pickup;
            this.DropOffLocation = dropoff;*/
            this.Driver = driver;

        }


        public void AssignDriver(Driver dr) 
        {
            if(dr.IsAvailable)
            {
                Status = "Driver available";
                Console.WriteLine($"{dr} has been assigned.");
            }
            else
            {
                Status = "Driver is not available";
                Console.WriteLine($"{dr} is not available.");
            }
        }

        public double CalculateFareCarpool(double distance,RideType rdtp)
        {

            
            return Fare = distance * rdtp.FareCoefficient("Carpool");
        }

        public double CalculateFareLuxury(double distance, RideType rdtp)
        {


            return Fare = distance * rdtp.FareCoefficient("Luxury");
        }
        public double CalculateFareBiker(double distance, RideType rdtp)
        {


            return Fare = distance * rdtp.FareCoefficient("Biker");
        }


    }
}
