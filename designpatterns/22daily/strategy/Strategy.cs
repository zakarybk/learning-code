using System;

namespace strategy
{
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it.");
        }
    }

    class CookMethod
    {
        private string food;
        private CookStrategy strategy;

        public void SetCookStrategy(CookStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetFood(string name)
        {
            this.food = name;
        }

        public void Cook()
        {
            strategy.Cook(food);
            Console.WriteLine();
        }
    }
}