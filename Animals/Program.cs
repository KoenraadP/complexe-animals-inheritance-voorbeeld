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
            Animal a = new Animal(3,true,53);

            // impliciet wordt er altijd .ToString() toegepast
            // wanneer je gewoon een 'class' instance in de console plaatst
            // om hier iets specifieks te zien moet je een override methode
            // in de class instellen voor ToString()
            Console.WriteLine(a);

            Dog d = new Dog("Labrador", 12);
            Console.WriteLine(d);

            // Talk methode uittesten
            // Console.WriteLine(a.Talk());
            // Console.WriteLine(d.Talk());
            d.Talk();
        }
    }
}
