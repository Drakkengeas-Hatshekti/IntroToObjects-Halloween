using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a new trick or treater
            var batman = new TrickOrTreater(new Person(13, "Ben", "Male"), "Batman");
            batman.AddCandy("Skittles");
            batman.AddCandy("Snickers");

            Console.WriteLine(batman.Costume + "'s bag has " + batman.Bag.CandyCount() + " pieces of candy in it");

            var smurf = new TrickOrTreater(new Person(11, "Alex", "Male"), "Papa Smurf");
            smurf.AddCandy("Nerds");
            smurf.AddCandy("Tootsie pop");
            smurf.AddCandy("3 Musketeers");

            Console.WriteLine(smurf.Costume + " is my costume this year.");
            Console.WriteLine("I only have " + smurf.Bag.CandyCount() + " pieces of candy!");

            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Kitkat");
            smurf.AddCandy("Babe Ruth");

            Console.WriteLine("I have " + smurf.Bag.NumberOfCandyVarieties() + " types of candy.");

            var person = new Person(19, "Alaric", "MAN");

            

            Console.ReadKey();
        }
    }
}
