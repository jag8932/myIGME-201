using System;
using System.Collections.Generic;

namespace PetApp
{
    class Program
    {
        // Name: Jacob Goodwillie
        // Date: 9/26/2020
        /* Description: This program stores child classes in a class list and displays their methods
         * based on their parent class and derived interfaces. The main program loops 50 times and 
         * generates a random number between 1 and 10. If that number is 1 then either a cat or dog is
         * added to the list. 
         */
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                if (rand.Next(1, 11) == 1)
                {
                    // 50% chance of adding a dog
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a new dog!");
                        dog = new Dog("1W00F", "GoodBoy", 5);
                        pets.petList.Add(dog);
                        Console.WriteLine("Dog's name => " + dog.Name);
                        Console.WriteLine("Dog's age => " + dog.age);
                        Console.WriteLine("Dog's license => " + dog.license);
                        dog.Eat();
                        dog.GotoVet();
                        dog.NeedWalk();
                        dog.Play();
                        dog.Bark();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You bought a new cat!");
                        cat = new Cat();
                        cat.Name = "Tabby";
                        cat.age = 10;
                        pets.petList.Add(cat);
                        Console.WriteLine("Cat's name => " + cat.Name);
                        Console.WriteLine("Cat's age => " + cat.age);
                        cat.Eat();
                        cat.Purr();
                        cat.Play();
                        cat.GotoVet();
                        cat.Scratch();
                        Console.WriteLine();

                    }

                } else if (rand.Next(1, 1) != 1 && pets.petList.Count > 0)
                {
                    thisPet = pets.petList[rand.Next(0, pets.petList.Count)];

                } 
               
               
            }
        }
    }


    // Class pets stores the list of pet objects. It has several methods to add, remove, and to remove
    // certain indexed objects.
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }
        // Gets count of list.
        public int Count
        {
            get;
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEI)
        {
            petList.RemoveAt(petEI);
        }

    }
    // This class is the parent class for the dog and cat classes.
    // Methods they share are declared in this abstract class. It also
    // stores the name and age of the pets.
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name
        {
           get { return name; }
           set { name = value; }
        }

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();
    
    }
    // The dog class will inherit properties from the IDog interface but not the ICat interface.
    interface IDog
    {
     public void  Eat();
        public void Play();
        public void Bark();
        public void NeedWalk();
        public void GotoVet();
    }

    // The cat class will inherit from the ICat interface but not IDog.
    interface ICat
    {
        public void Eat();
        public void Play();
        public void Scratch();
        public void Purr();
    }

    // Cat class inherits from pet and ICat. It has its own methods and shared methods with class dog. 
    // Unique to this class is purr and scratch. 
    public class Cat: Pet, ICat
    {
        public override void Play()
        {
            Console.WriteLine(this.Name + " brushes against your leg in and starts to play with your shoe laces.");
        }
        public override void Eat()
        {
            Console.WriteLine(this.Name + " starts to eat from their bowl, they paw at you for more.");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " doesn't look so well. A visit to the vet might make things better");
        }
        public void Scratch()
        {
            Console.WriteLine("You feel a sharp pain and look down to see " + this.Name + " scratching your leg.");
        }
        public void Purr()
        {
            Console.WriteLine("prrrrr .... prrrrr... prrrr");
        }
    }

    // Class dog inherits from class pet and interface IDog. 
    // Unique to this class is bark and need walk.
    public class Dog : Pet, IDog
    {
        public string license;

        public Dog(string license, string name, int age) {
            this.license = license;
            this.Name = name;
            this.age = age;
            }
        public override void Eat()
        {
            Console.WriteLine(this.Name + " is eating their food.");
        }
        public override void Play()
        {
            Console.WriteLine(this.Name + " puts a ball in your lap. They want to play with it.");
        }
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " is feeling sick. Take them to the vet.");
        }

        public void Bark() 
        {
            Console.WriteLine(this.Name + " says: Bark! Bark! Bark! Bark!");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + " brings you their leash, they want you to take them outside.");
        }
    }
}
