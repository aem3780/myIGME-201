using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: PE11
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: Reference vehicles.dll
        //Restrictions: none
        static void Main(string[] args)
        {
            //create and initailize vehicle object
            Vehicle vehicleObject = new SUV();

            //if th eobject uses the IPassengerCarrier interface call AddPassenger method
            if (vehicleObject is IPassengerCarrier)
            {
                AddPassenger(vehicleObject);
            }


        }
        //Method: AddPassenger
        //Purpose: calls LoadPassenger method when passed a valid object
        //Restrictions: none
        public static void AddPassenger(object vehicle)
        {
            //declare IPassengerCarrier reference variable
            IPassengerCarrier iVehicle = (IPassengerCarrier)vehicle;

            //call LoadPassenger method with reference to the interface
            iVehicle.LoadPassenger();

            //convert iVehicle to string and print to console
            Console.WriteLine(iVehicle.ToString());
        }
    }
}
