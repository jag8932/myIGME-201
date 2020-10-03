using System;
using System.Runtime.CompilerServices;



// Name: Jacob Goodwillie
// Date: 10/3/2020
/* Description: CafeLib is a library that holds an abstract hotdrink class
 * and many different drink sub classes. It also has two interfaces, IMood and
 * ITakeOrder. IMood affects the customer and waiter moods while ITakeOrder affects
 * the drinks. The waiter and customer do not inherit from the HotDrink class.
 */
namespace CafeLib.dll
{
    // HotDrink parent class
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        // Adds sugar to sugar field.
        public virtual void AddSugar(byte amount)
        {

        }
        // Makes steam
        public abstract void Steam();

        
        // Constructor accepts brand type
        public HotDrink(string _brand)
        {

        }
   
    }
    // IMood affects the human classes. Recieves a mood.
    public interface IMood
    {
          string Mood { get; }
    }
    // Affects each drink sub class.
    public interface ITakeOrder
    {
         void TakeOrder();
    }
    // Waiter with name and mood. Serves the customer a hot drink type.
    public class waiter: IMood
    {
        public string name;
        public string Mood { get; }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }
    // A customer with a name and creditcard.
    public class Customer: IMood
    {
        public string name;
        public string creditCardNumber;
        public string Mood { get; }
    }
    // CupOfCoffee has a beantype field and inherits from hotdrink and takeorder.
    public class CupOfCoffee: HotDrink, ITakeOrder
    {
        public string beanType;

        public void TakeOrder()
        {

        }
        public override void Steam()
        {

        }

        public CupOfCoffee(string _brand) : base(_brand)
        {
           
        }

            
    }
    // CupOfTea is similar but has a leaftype.
    public class CupOfTea: HotDrink, ITakeOrder
    {
        public string leafType;

        public override void Steam()
        {
            
        }
        public void TakeOrder()
        {

        }
        public CupOfTea(bool customerIsWealthy, string _brand) :base(_brand)
        {

        }
    }
    //CupOfCocoa has a number of cups and a marshmallow bool. Gets and sets a source.
    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            get;
            set;
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
        //Brand is set to expensive organic brand and currently there are no marshmallows unless stated otherwise.
        public CupOfCocoa(string _brand = "Expensive Organic Brand", bool marshmallows = false) :base(_brand)
        {

        }

    }
}
