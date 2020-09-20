using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Goodwillie
{
    class Program
    {
        static void Main(string[] args)
        {

               Cat cat = new Cat("Snowball"); 
        
       
        }
    }



    class Cat
    {

        public string name;
        public int age;
        public string color;

        public Cat(string _name, int _age, string  _color)
        {
            name = _name;
            age = _age;
            color = _color;
            whatIsCat();
        }
        public Cat()
        {
            name = "Hi";
            age = 4;
            color = "red";
        }
        public Cat(string name)
        {
            this.name = name;
            age = 4;
            color = "red";
            whatIsCat();

        }

        public void whatIsCat()
        {
            Console.WriteLine("Its name is {0} and its age is {1}. This is a {2} colored cat.", name, age, color);
        }
    }
}