using PE12;
using System;

namespace PE12
{
    // Name: Jacob Goodwillie
    // Date: 9/23/2020
    // Description: In this program, a child class derives fields and a function from
    // a parent class and displays returns its private string to the console.
    class Program
    {
        static void Main(string[] args)
        {

            // Create an object from a derived class.
            var myClass = new MyDerivedClass();
            // Give the object string something to output.
            myClass.MyString = "Hello world.";
           
            // Outputs myClass GetString function.
            Console.WriteLine(myClass.GetString());

        }
    }

    // Parent Class
    class MyClass
    {
        // Private string declared.
        private string myString;

        // Write only field created. It doesn't return myString but it sets it equal to its value. Notice no get command.
        public string MyString
        {
            set { myString = value; }
        }

        // Returns the private myString which should equal MyString.
        public virtual string GetString()
        {
            return myString;
        }
    }
}
// Derived class
class MyDerivedClass : MyClass
{
    // Returns the base GetString method.
    public override string GetString()
    {
        return base.GetString();
    }

}
