using System.Reflection.Metadata;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = new List<string>();
            
            foods.Add("pizza");
            foods.Add("Kebab");
            foods.Add("Burger");
            foods.Add("Chocolate");
            
            //foods.Remove("Chocolate");
            foods.Insert(0, "Apple");

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

        }
    }

    
    
    

    

    
};