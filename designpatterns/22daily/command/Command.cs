using System;
using System.Linq;
using System.Collections.Generic;

namespace command
{
    enum Command
    {
        Default,
        Add,
        Modify,
        Remove
    }

    public class MenuItem
    {
        public string name;
        public int amount;
        public double price;

        public MenuItem(string name, int amount, double price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Amount: " + amount.ToString());
            Console.WriteLine("Price: " + price.ToString());
        }
    }

    // The invoker class
    public class Patron
    {
        private OrderCommand orderCommand;
        private MenuItem menuItem;
        private FastFoodOrder order;

        public Patron()
        {
            order = new FastFoodOrder();
        }

        public void SetCommand(int option)
        {
            orderCommand = new CommandFactory().GetCommand(option);
        }

        public void SetMenuItem(MenuItem item)
        {
            menuItem = item;
        }

        public void ExecuteCommand()
        {
            order.ExecuteCommand(orderCommand, menuItem);
        }

        public void ShowOrder()
        {
            order.ShowItems();
        }
    }

    public class CommandFactory
    {
        public OrderCommand GetCommand(int option)
        {
            switch (option)
            {
                case (int)Command.Add:
                    return new AddCommand();
                case (int)Command.Modify:
                    return new ModifyCommand();
                case (int)Command.Remove:
                    return new RemoveCommand();
                default:
                    return new AddCommand();
            }
        }
    }

    // The receiver
    public class FastFoodOrder
    {
        public List<MenuItem> items;

        public FastFoodOrder()
        {
            items = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.items, item);
        }

        public void ShowItems()
        {
            foreach (var item in items)
                item.Display();

            Console.WriteLine("--------------------------");
        }
    }

    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem item);
    }

    // A concrete command
    public class AddCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem item)
        {
            order.Add(item);
        }
    }

    public class RemoveCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem item)
        {
            order.Remove(order.Where(x=>x.name == item.name).First());
        }
    }

    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> order, MenuItem newItem)
        {
            var item = order.Where(x => x.name == newItem.name).First();
            item.price = newItem.price;
            item.amount = newItem.amount;
        }
    }
}