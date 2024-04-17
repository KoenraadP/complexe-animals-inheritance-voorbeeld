using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(3,true,1000);
            //Dog dog = new Dog(14, "herdershond");
            //Bird bird = new Bird(3, new[] {"Rood", "Groen"});
            Dog dog = new Dog(4, false, 14, "Herdershond");
            Bird bird = new Bird(2, true, 3, new[] {"Rood", "Groen"});

            Console.WriteLine(animal);
            Console.WriteLine(dog);
            Console.WriteLine(dog.Talk());
            Console.WriteLine(bird);
            Console.WriteLine(bird.Talk());
        }
    }
}
