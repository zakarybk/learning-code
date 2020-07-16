﻿using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;

            RecipeFactory factory;
            switch (input)
            {
                case 'A':
                    factory = new AdulstCuisineFactory();
                    break;
                case 'C':
                    factory = new KidCuisineFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);
        }
    }
}
