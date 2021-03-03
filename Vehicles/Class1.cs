using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    //Class: Vehicle
    //Author: Allie Maus
    //Purpose: creates a public abstract class Vehicle
    //Restrictions: none
    public abstract class Vehicle
    {
        //Method: LoadPassenger
        //Purpose: Empty virtual function LoadPassenger
        //Restrictions: none
        public virtual void LoadPassenger()
        {

        }
    }
    //Class:Car
    //Author: Allie Maus
    //Purpose: creates a public abstract Car that inherits from Vehicle
    //Restrictions: none
    public abstract class Car: Vehicle
    {

    }

    //Class: Train
    //Author: Allie Maus
    //Purpose: creates a public abstract class Train that inherits from Vehicle
    //Restrictions: none
    public abstract class Train: Vehicle
    {

    }
    
    //creates public interface IPassengerCarrier
    public interface IPassengerCarrier
    {

        void LoadPassenger();
    }
    //creates public interface IHeavyLoadCarrier
    public interface IHeavyLoadCarrier
    {

    }
    //Class: SUV
    //Author: Allie Maus
    //Purpose: creates a public class SUV that inherits from Car and has the interface
    //IPassengerCarrier
    //Restrictions: none
    public class SUV: Car, IPassengerCarrier
    {

    }
    //Class: Pickup
    //Author: Allie Maus
    //Purpose: creates a public class Pickup that inherits from Car and has the interfaces
    //IPassengerCarrier and IHeavyLoadCarrier
    //Restrictions: none
    public class Pickup: Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }
    //Class: Compact
    //Author: Allie Maus
    //Purpose: creates a public class Compact that inherits from Car and has the interface
    //IPassengerCarrier
    //Restrictions: none
    public class Compact: Car, IPassengerCarrier
    {

    }
    //Class: FreightTrain
    //Author: Allie Maus
    //Purpose: creates a public class FreightTrain that inherits from Train and has the interface
    //IHeavyLoadCarrier
    //Restrictions: none
    public class FreightTrain: Train, IHeavyLoadCarrier
    {

    }
    //Class: _424DoubleBogey
    //Author: Allie Maus
    //Purpose: creates a public class _424DoubleBogey that inherits from Train and has the interface
    //IHeavyLoadCarrier
    //Restrictions: none
    public class _424DoubleBogey: Train, IHeavyLoadCarrier
    {

    }

}
