using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE16
{
    
    public class Class1
    {


    }

    //Class: HotDrink
    //Author: Allison Maus
    //Purpose: Creates abstract class HotDrink
    //Restrictions: none
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        //Method: AddSugar
        //Purpose: creates virtual method AddSugar and passes amount type byte
        //Restrictions: none
        public virtual void AddSugar(byte amount)
        {

        }
        public abstract void Steam();

        //constructor for HotDrink
        public HotDrink()
        {

        }
        //constructor for HotDrink that accepts brand string
        public HotDrink(string brand)
        {

        }

    }

    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    //Class: Waiter
    //Author: Allison Maus
    //Purpose: Creates public class Waiter that inherits the interface IMood
    //Restrictions: none

    public class Waiter: IMood
    {
        public string name;

        public string Mood
        {
            get;
        }

        //Method: ServeCustomer
        //Purpose: creates method ServeCustomer and passes cup HotDrink object
        //Restrictions: none
        public void ServeCustomer(HotDrink cup)
        {

        }

    }

    //Class: Waiter
    //Author: Allison Maus
    //Purpose: Creates public class Customer that inherits the interface IMood
    //Restrictions: none

    public class Customer: IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get;
        }
    }

    //Class: CupOfCoffee
    //Author: Allison Maus
    //Purpose: Creates public class CupOfCoffee that inherits from abstract class HotDrink and the interface IMood
    //Restrictions: none

    public class CupOfCoffee: HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        //constructor for CupOfCoffee that accepts brand string and calls base brand
        public CupOfCoffee(string brand): base(brand)
        {
           
        }
    }


    //Class: CupOfTea
    //Author: Allison Maus
    //Purpose: Creates public class CupOfTea that inherits from abstract class HotDrink and the interface IMood
    //Restrictions: none
    public class CupOfTea: HotDrink, ITakeOrder
    {
        public string leafType;


        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        //constructor for CupOfTea that accepts bool cutomerIsWealthy
        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    //Class: CupOfCocoa
    //Author: Allison Maus
    //Purpose: Creates public class CupOfCocoa that inherits from abstract class HotDrink and the interface IMood
    //Restrictions: none
    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCups;

        public bool marshmallows;

        private string source;

        public string Source
        {
            set
            {

            }
        }

        public override void Steam()
        {

        }


        public override void AddSugar(byte amount)
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfCocoa(): this(false)
        {
            
        }

        //constructor for CupOfCocoa that accepst marshmallows type bool and calls base
        public CupOfCocoa(bool marshamllows): base("Expensive Organic Brand")
        {
            
        }

    }
}
