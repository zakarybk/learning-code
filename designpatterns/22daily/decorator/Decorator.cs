using System;
using System.Collections.Generic;

namespace decorator
{
    // The abstract component class
    abstract class RestaurantDish
    {
        public abstract void Display();
    }

    // A concrete component class
    class FreshSalad : RestaurantDish
    {
        private string greens;
        private string cheese;
        private string dressing;

        public FreshSalad(string greens, string cheese, string dressing)
        {
            this.greens = greens;
            this.cheese = cheese;
            this.dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}", greens);
            Console.WriteLine(" Cheese: {0}", cheese);
            Console.WriteLine(" Dressing: {0}", dressing);
        }
    }

    class Pasta : RestaurantDish
    {
        private string pasta;
        private string sauce;

        public Pasta(string pasta, string sauce)
        {
            this.pasta = pasta;
            this.sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine(" Pasta: {0}", pasta);
            Console.WriteLine(" Sauce: {0}", sauce);
        }
    }

    // The abstract decorator class
    abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish dish;

        public Decorator(RestaurantDish dish)
        {
            this.dish = dish;
        }

        public override void Display()
        {
            dish.Display();
        }
    }

    /// A ConcreteDecorator. This class will impart "reponsibilites"
    /// onto the dishes (whether there are enough ingredients for dish)
    class Available : Decorator
    {
        public int available { get; set; }
        protected List<string> customers = new List<string>();

        public Available(RestaurantDish dish, int available) : base(dish)
        {
            this.available = available;
        }

        public void OrderItem(string name)
        {
            if (available > 0)
            {
                customers.Add(name);
                available--;
            }
            else
            {
                Console.WriteLine(
                    "\nNot enough ingredients for {0}'s order!", name
                );
            }
        }

        public override void Display()
        {
            base.Display();

            foreach(var customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}