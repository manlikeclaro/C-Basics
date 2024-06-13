using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car Ford = new Car("Mustang", "Red", 1969);
            // Car Opel = new Car("Astra", "White", 2005);

            // Console.WriteLine(Ford.model);
            // Console.WriteLine(Opel.model);
            // Opel.Honk();
            //
            // Console.WriteLine("Enter the name of the car: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Enter the make of the car: ");
            // string make = Console.ReadLine();
            // Console.WriteLine("Enter the hp of the car: ");
            // int hp = Convert.ToInt32(Console.ReadLine());
            //
            // CarTwo ferrari = new CarTwo(name, make, hp);
            // Console.WriteLine($"The car is a {ferrari.Name} {ferrari.make} with {ferrari.hp} hp!");

            Animal donkey = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();
            
            donkey.animalSound();
            dog.animalSound();
            cat.animalSound();
            
            Console.ReadKey();
        }
    }

    class CarTwo
    {
        private string name;
        public string make;
        public int hp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public CarTwo(string nameParam, string makeParam, int hpParam)
        {
            Name = nameParam;
            make = makeParam;
            hp = hpParam;
        }
    }
}