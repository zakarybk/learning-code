using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Steak account = new Steak("T-Bone");

            account.IncreaseTemperature(120);
            account.IncreaseTemperature(15);
            account.IncreaseTemperature(15);
            account.DecreaseTemperature(10);
            account.DecreaseTemperature(15);
            account.IncreaseTemperature(20);
            account.IncreaseTemperature(20);
            account.IncreaseTemperature(20);
        }
    }
}
