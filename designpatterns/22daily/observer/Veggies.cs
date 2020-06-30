using System;
using System.Collections.Generic;

namespace observer
{

    abstract class Vegtable
    {
        private double pricePerPound;
        protected string name = "Unknown";
        private List<IRestaurant> restaurants = new List<IRestaurant>();

        public Vegtable(double pricePerPound)
        {
            this.pricePerPound = pricePerPound;
        }
        public void Attach(IRestaurant restaurant)
        {
            this.restaurants.Add(restaurant);
        }
        public void Detach(IRestaurant restaurant)
        {
            this.restaurants.Remove(restaurant);
        }
        public void Notify()
        {
            foreach (IRestaurant restaurant in this.restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }
        public double PricePerPound
        {
            get { return this.pricePerPound; }
            set
            {
                if (this.pricePerPound != value)
                {
                    this.pricePerPound = value;
                    Notify();
                }
            }
        }

        public string Name
        {
            get { return this.name; }
        }
    }

    class Carrots : Vegtable
    {
        public Carrots(double price) : base(price)
        {
            this.name = "carrot";
        }
    }

    interface IRestaurant
    {
        void Update(Vegtable veggies);
    }

    class Restaurant : IRestaurant
    {
        private string name;
        private Vegtable veggies;
        private double purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            this.name = name;
            this.purchaseThreshold = purchaseThreshold;
        }
        public void Update(Vegtable veggie)
        {
            Console.WriteLine(
                "Notified {0} of {1}'s price change to {2:C} per pound.",
                this.name, veggie.Name, veggie.PricePerPound
            );
            if (veggie.PricePerPound < this.purchaseThreshold)
            {
                Console.WriteLine(this.name + " wants to buy some " + veggie.Name);
            }
        }
    }
}