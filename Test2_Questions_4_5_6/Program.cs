using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Questions_4_5_6_7
{
    // Name: Jacob Goodwillie
    // Date: 10/14/2020
    /* Description: This is the program for questions 4, 5, 6, and 7.
     * The program is based off the shuml provided in question 4. The program includes
     * UsePhone methods which use a tardis object and a regular phonebooth object as parameters.
     * I added functionality to the timetravel and opendoor functions to test if question 7 works,
     * which it does. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis1 = new Tardis();
            PhoneBooth phonebooth1 = new PhoneBooth();

            // Question 5. UsePhone with the objects tardis and phonebooth
            // passed as parameters.
            UsePhone(tardis1);
            UsePhone(phonebooth1);
        }
        // UsePhone passes in objects  which inherit from the IPhoneInterface interface.
        // As they inherit from IPhoneInterface the objects can call the methods they
        // inherit from it.
        static void UsePhone(object obj)
        {
            // Cast as an IPhoneInterface interface type object
            IPhoneInterface thisObj = (IPhoneInterface)obj;

            // thisObj can now call the interface functions.
            thisObj.MakeCall();
            thisObj.HangUp();

            // Using the is keyword, we can check what type of object obj is.
            // If the object is a Tardis, time travel. If the object is a Phonebooth, open the door.
            if (obj is Tardis)
            {
                Tardis tardisObject = (Tardis)obj;
                tardisObject.TimeTravel();
                
            }
            else if (obj is PhoneBooth)
            {
                PhoneBooth phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
        }
    }

  // Abstract parent phone class. 
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

        public abstract void Connect();
        public abstract void Disconnect();
    }
    // Public phone interface. Added I to PhoneInterface simply for naming
    // convention. 
    public interface IPhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    // RotaryPhone inherits Phone and IPhoneInterface
    public class RotaryPhone : Phone , IPhoneInterface
    {

        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }
    }

    // PushButtonPhon also inherits Phone and IPhoneInterface.
    public class PushButtonPhone : Phone , IPhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }
    }
    // Tardis inherits RotaryPhone.
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        
        // Read only as per shuml instructions.
        public byte WhichDrWho
        {
            get
           {
               return whichDrWho;
           }
        }
        private string femaleSideKick;
        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public void TimeTravel() 
        { 
            // NOT PART OF QUESTION but simply for testing.
            Console.WriteLine("Time traveling woooooooooo");
        }
    }

    // PhoneBooth inherits PushButtonPhone
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() 
        {
            // NOT PART OF QUESTION but simply for testing.
            Console.WriteLine("Creeeek");
        }
        public void CloseDoor() { }
    }
}
