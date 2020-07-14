using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            Patron patron = new Patron();
            patron.SetCommand((int)Command.Add);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.SetCommand((int)Command.Add);
            patron.SetMenuItem(new MenuItem("Veg Burger", 2, 2.59));
            patron.ExecuteCommand();

            patron.SetCommand((int)Command.Add);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowOrder();

            patron.SetCommand((int)Command.Remove);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowOrder();

            patron.SetCommand((int)Command.Modify);
            patron.SetMenuItem(new MenuItem("Veg Burger", 4, 2.59));
            patron.ExecuteCommand();

            patron.ShowOrder();
        }
    }
}
