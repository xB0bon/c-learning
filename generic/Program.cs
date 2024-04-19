using System.Reflection.Metadata;
using System.Collections.Generic;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };
            
            Display(intArray);
            Display(doubleArray);
            Display(stringArray);
        }

        public static void Display<Thing>(Thing[] array) // pozwala na każdy rodzaj array
        {
            foreach (Thing thing in array)
            {
                Console.WriteLine(thing);
            }
        }

        

    }

    










};