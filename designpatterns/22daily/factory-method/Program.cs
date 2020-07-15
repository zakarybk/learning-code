using System;
using System.Collections.Generic;

namespace factory_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkeySandwich = new TurkeySandwich();
            var dagwood = new Dagwood();

            Console.WriteLine("\nTurkey Sandwich contains:\n");
            PrintIngredients(turkeySandwich.ingredients);

            Console.WriteLine("\nDagwood contains:\n");
            PrintIngredients(dagwood.ingredients);
        }

        private static void PrintIngredients(List<Ingredient> ingredients)
        {
            foreach (Ingredient ingredient in ingredients)
                Console.WriteLine(ingredient.GetType().Name);
        }
    }
}
