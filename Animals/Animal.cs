using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public int Legs { get; set; }
        public bool CanFly { get; set; }
        public int AverageLifeExpectancy { get; set; }

        public Animal(int legs, bool canFly, int averageLifeExpectancy)
        {
            Legs = legs;
            CanFly = canFly;
            AverageLifeExpectancy = averageLifeExpectancy;
        }

        public Animal(int averageLifeExpectancy)
        {
            AverageLifeExpectancy = averageLifeExpectancy;
        }

        public override string ToString()
        {
            string canFly = "can";

            // !CanFly is hetzelfde als CanFly == false
            if (!CanFly)
            {
                canFly = "can't";
            }

            return "This animal has " + Legs + " legs, " 
                + canFly + " fly and has an average life expectancy of " 
                + AverageLifeExpectancy + " years.";
        }

        //public string Talk()
        //{
        //    return "Random animal noises";
        //}

        public void Talk()
        {
            Console.WriteLine("Random animal noises");
        }
    }
}
