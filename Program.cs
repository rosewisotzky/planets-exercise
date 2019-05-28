using System;
using System.Collections.Generic;

namespace planets_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wow, a new week, pal! Look at you learning all the learnin'");
            // Here's our new list. We're naming it on the left, so this list is called planetList. Over on the right, we're initializing our list with the empty parens and in our curly bracket we are declaring what exists in our list currently.
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // .Add is just slappin' another planet on our list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");


            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            // .AddRange allows us to combine our two lists. We're adding lastTwoPlanets to planetList, which is why lastTwoPlanets is passed as our argument.
            planetList.AddRange(lastTwoPlanets);

            // .Insert wants us to specify the index value and the string value of what we are placing into our list o' strings.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");


            planetList.Add("Pluto");
            
            // Here we are creating a new list called rockyPlanets with the GetRange method. The value of our new list is the range that starts at 0 and contains 4 items from planetList.
            List<string> rockyPlanets = planetList.GetRange(0, 4);  
            
            // Just checking it works!
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine($"{planet} ");
            };
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (string planet in planetList)
                {
                    Console.WriteLine($"{planet}");
                }
        }
    }
}
