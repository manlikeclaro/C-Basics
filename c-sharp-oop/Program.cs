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
            CarTwo car = new CarTwo("Ferrari", "S-350 Spider", 6500);
            
            Animal donkey = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            try
            {
                donkey.animalSound();
                dog.animalSound();
                cat.animalSound();

                car.carFunc();
                // Console.WriteLine(donkey.array[10]);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

}