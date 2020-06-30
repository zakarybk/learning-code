using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.86;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;
        }
    }
}
