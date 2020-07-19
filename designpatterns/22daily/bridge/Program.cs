using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SendOrder sendOrder = new SendDairyFreeOrder();
            sendOrder.restaurant = new DinerOrders();
            sendOrder.Send();

            sendOrder.restaurant = new FancyRestaurantOrders();
            sendOrder.Send();

            sendOrder = new SendGlutenFreeOrder();
            sendOrder.restaurant = new DinerOrders();
            sendOrder.Send();

            sendOrder.restaurant = new FancyRestaurantOrders();
            sendOrder.Send();
        }
    }
}
