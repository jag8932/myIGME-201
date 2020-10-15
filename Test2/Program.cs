using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace Test2
{
    static class Program
    {
        static void Main()
        {
            MyDerivedClass myObj = new MyDerivedClass(42);

            Console.WriteLine(myObj.myInt);

            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

            friendBirthdays.Add("Date:", new DateTime(2020, 10, 14));
            foreach (var dates in friendBirthdays)
            {
                Console.WriteLine(dates);
            }

            MyDerivedClass objectA = new MyDerivedClass(4);
            MyClass objectB = objectA;
            Console.WriteLine(objectA.myInt);
            Console.WriteLine(objectB.myInt);
        }
    }

    public class MyClass
    {
        public int myInt;
        public MyClass(int nVal)
        {
            this.myInt += nVal;
        }
    }
        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(int nVal) : base(nVal)
            {
                this.myInt = (this.myInt + 2) * 4;
            }
        }
    
}


