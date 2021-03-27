using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniteTest2Q4
{
    //Class: Program
    //Author: Allison Maus
    //Purpose: Unit Test 2 Questions 4 - 7
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: Unit Test 2 Questions 4 - 7
        //Restrictions: none

        static void Main(string[] args)
        {
            //create new Tardis object 
            Tardis tardis = new Tardis();
            //create new PhoneBooth object
            PhoneBooth phonebooth = new PhoneBooth();


        }
        //Method: UsePhone
        //purpose:  Accepts object and calls MakeCall and HangUp by the interface
        //restrictions: none
        static void UsePhone(object obj)
        {
            //create variable of PhoneInterface type
            PhoneInterface p;
            p = (PhoneInterface)obj;

            //call methods using the interface 
            p.MakeCall();
            p.HangUp();

            //check type of object passed to method  
            Type type = obj.GetType();
            //if object is of the type PhoneBooth
            if (type.Equals(typeof(PhoneBooth)))
            {
                // OpenDoor only belongs to PhoneBooth, so we need a PhoneBooth reference variable to output that
                PhoneBooth pb = (PhoneBooth)obj;
                pb.OpenDoor();
            }
            //else if object is of the type Tardis 
            else if (type.Equals(typeof(Tardis)))
            {
                // TimeTravel only belongs to Tardis, so we need a Tardis reference variable to output that
                Tardis t = (Tardis)obj;
                t.TimeTravel();
            }
        }
    }

    //Class: Phone
    //Purpose: create public class phone
    //Restrictions: none
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }


    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    //Class: RotaryPhone 
    //Purpose: create public class RotaryPhone that inherits parent class phone and the interface PhoneInterface
    //Restrictions: none
    public class RotaryPhone: Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {
            
        }
    }
    //Class: PushButtonPhone
    //Purpose: create public class PushBottomPhone that inherits parent class Phone and the interface PhoneInterface
    //Restrictions: none
    public class PushButtonPhone: Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }

    }
    //Class: Tardis
    //Purpose: creates public class Tardis that inherits from parent class RotaryPhone 
    //Restrictions: none
    public class Tardis: RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }

        public void TimeTravel()
        {

        }

        //create overrides for operators so that the 10th doctor is always greater than the others

        public static bool operator <(Tardis t1, Tardis t2)
        {

            if (t1.whichDrWho == 10)
            {
                return false;
            }
            else
            {
                return (t1.whichDrWho < t2.whichDrWho);
            }
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return true;
            }
            else
            {
                return (t1.whichDrWho > t2.whichDrWho);
            }
        }
        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if(t1.whichDrWho==10)
            {
                return false;
            }
                return (t1.whichDrWho <= t2.whichDrWho);

        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return true;
            }
            return (t1.whichDrWho >= t2.whichDrWho);
        }
        public static bool operator ==(Tardis t1, Tardis t2)
        {
            return (t1.whichDrWho == t2.whichDrWho);
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            return (t1.whichDrWho != t2.whichDrWho);
        }
    }
    //Class: PhoneBooth 
    //Purpose: creates public class PhoneBooth that inherits from the parent class PushButtonPhone
    //Restrictions: none
    public class PhoneBooth: PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }

    }

}
