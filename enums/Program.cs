using System.Reflection.Metadata;
using System.Collections.Generic;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"{Planets.Mercury} is planet {(int)Planets.Mercury}");
            String name = Planets.Earth.ToString();
            int radius = (int)PlanetsRadius.Earth;
            Console.WriteLine($"planet: {name}");
            Console.WriteLine($"radius: {radius} km");
        }

        enum Planets
        {
            Mercury = 1,
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Jupiter = 5,
            Saturn = 6,
            Uranus = 7,
            Neptune = 8,
            Pluto = 9
        }

        enum PlanetsRadius
        {
            Mercury = 2439,
            Venus = 6052,
            Earth = 6378,
            Mars = 3396,
            Jupiter = 71492,
            Saturn = 60268,
            Uranus = 25559,
            Neptune = 24764,
            Pluto = 11780
        }

    }

    










};