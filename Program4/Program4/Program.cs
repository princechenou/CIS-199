//grade ID: R2206
//class: CIs 199-02
//program 4
//due date: 4/19/2022
//description: display different information about superhoero if the inuts are valid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates class objects
            Superhero firstclass = new Superhero("Aquaman", "atlantis", "telepathic control of aquatic life", 1941 , "utiliing The sacred trident", 'a',true);
            Superhero secondclass = new Superhero("Batman", "Gotham City", "Genuis-level intellect", 0 , "master of Martial Arts", 'b',false);
            Superhero thridclass = new Superhero("Iron Man", "Long Island", "Powered Armor Suit", 1963, "supersonic Flight", 'i',false);

            Console.WriteLine("Original list of super heros");
            Console.WriteLine("---------------------------");

            Superhero[] classes = new Superhero[3];//initialize an array

            //assigns wach each to an individual array
            classes[0] = firstclass;
            classes[1] = secondclass;
            classes[2] = thridclass;

            //this is to go through each class indidvidually
            foreach ( Superhero indiviclass in classes)
                {
                //this displays all of the information in each class
                Console.WriteLine($"{indiviclass}");
                Console.WriteLine();

            }
        }
    }
}
