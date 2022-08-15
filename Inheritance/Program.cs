using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var b = new Bird();
            b.Beak = 1;
            b.Sleep = true;
            b.Fly = true;
            b.TwoLegs = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var r = new Reptile();


            r.HasTongue = true;
            r.HasTail = true;
            r.IsDangerous = true;
            r.AreMammals = true;
        
            var myAnimals = new Animal[] {b, r};

            foreach (var item in myAnimals)
            {
                Console.WriteLine($"It is {item.Age} years old.");
                Console.WriteLine($"The color of this animal is {item.Color}.");
                Console.WriteLine($"The name of the animal is {item.Name}.");
                Console.WriteLine($"The animal prefers to eat {item.Eat}.");
                Console.WriteLine();
            }
        }
           
	}
       
    }

	