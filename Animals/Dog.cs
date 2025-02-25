using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // alle properties, constructors, methodes, ...
    // overerven van Animal
    class Dog : Animal
    {
        // unieke properties die niet bij Animal horen enkel bij Dog
        public string Breed { get; set; }

        public Dog(string breed, int averageLifeExpectancy)
            : base(averageLifeExpectancy)
        {
            // iedere hond heeft 4 poten
            Legs = 4;
            // geen enkele hond kan vliegen
            CanFly = false;
            // de Breed property is uniek voor Dog
            // AverageLifeExpectancy is geërfd van Animal dus wordt
            // al ingevuld via de base class constructor
            Breed = breed;
        }
        
        public new void Talk()
        {
            // eerst Talk vanuit base class uitvoeren
            base.Talk();
            // nu unieke onderdelen van Dog Talk
            Console.WriteLine("Woof woof!");
        }

    }
}
