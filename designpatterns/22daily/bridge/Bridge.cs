using System;

namespace bridge
{
    /*
    /// What the bridge avoids
    interface IOrder {}
    class DairyFreeOrder : IOrder {}
    class GlutenFreeOrder :IOrder {}

    interface IDinerOrder : IOrder {}
    class DinerDairyFreeOrder : DairyFreeOrder, IDinerOrder {}
    class DinerGlutenFreeOrder : GlutenFreeOrder, IDinerOrder {}

    interface IFancyRestaurantOrder : IOrder {}
    class FancyRestaurantDairyFreeOrder : DairyFreeOrder, IFancyRestaurantOrder {}
    class FancyRestaurantGlutenFreeOrder : GlutenFreeOrder, IFancyRestaurantOrder {}
    */

    // Implementer
    public interface IOrderingSystem
    {
        void Place(string order);
    }

    // Abstraction which represnts the sent order and maintains a 
    // reference to the restaurant where the order is going
    public abstract class SendOrder
    {
        public IOrderingSystem restaurant;

        public abstract void Send();
    }

    // RefinedAbstract
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            restaurant.Place("Dairy-Free order");
        }
    }

    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            restaurant.Place("Gluten free order");
        }
    }

    // ConcreteImplementer
    public class DinerOrders: IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Diner.");
        }
    }

    public class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine(
                "Placing order for " + order + " at the Fancy Restaurant."
            );
        }
    }


}