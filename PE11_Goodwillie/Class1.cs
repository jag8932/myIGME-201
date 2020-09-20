using System;

namespace PE11_Goodwillie
{
    // Name: Jacob Goodwillie
    // Date: 9/19/2020
    /* Description: 9 classes that inherit from each other as well as interfaces. 
    */
    public class Vehicles
    {
        public virtual void LoadPassenger() { }
    }

    public class Train : Vehicles
    {

    }
    public class Car : Vehicles
    {

    }

    public interface PassengerCarrier
    {
        void LoadPassenger();
    }

    public interface HeavyLoadCarrier { }

    public class Compact : Car {

        }
    public class SUV : Car
    {

    }
    public class Pickup : Car
    {
        PassengerCarrier LoadVehicle {
        };
    }
    public class PassengerTrain : Train
    {

    }
    public class FreightTrain : Train
    {

    }
    public class _424DoubleBogey : Train
    {

    }
}
