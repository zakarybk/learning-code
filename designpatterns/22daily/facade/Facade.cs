using System;

namespace facade
{
    class Patron
    {
        private string name;

        public Patron(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }

    class FoodItem { public int DishID; }

    interface KitchenSection
    {
        FoodItem PrepDish(int dishID);
    }

    class Order
    {
        public FoodItem Appetiser;
        public FoodItem Entree;
        public FoodItem Drink;
    }

    class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            return new FoodItem { DishID = dishID };
        }
    }

    class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            return new FoodItem { DishID = dishID };
        }
    }

    class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            return new FoodItem { DishID = dishID };
        }
    }

    class Server
    {
        private ColdPrep coldPrep = new ColdPrep();
        private HotPrep hotPrep = new HotPrep();
        private Bar bar = new Bar();

        public Order PlaceOrder(
            Patron patron, 
            int coldAppID, 
            int hotEntreeID, 
            int drinkID
        ){
            Console.WriteLine(
                "{0} places order for "
                + "cold app #{1}, "
                + "hot entree #{2}, "
                + "and drink #{3}.",
                patron.Name,
                coldAppID.ToString(),
                hotEntreeID.ToString(),
                drinkID.ToString()
            );

            Order order = new Order();

            order.Appetiser = coldPrep.PrepDish(coldAppID);
            order.Entree = hotPrep.PrepDish(hotEntreeID);
            order.Drink = bar.PrepDish(drinkID);

            return order;
        }
    }

}