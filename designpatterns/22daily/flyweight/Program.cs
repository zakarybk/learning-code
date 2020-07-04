using System;

namespace flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Please entre your slider order (B, V, or Q): "
            );
            var order = Console.ReadLine().Trim();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    }
}
