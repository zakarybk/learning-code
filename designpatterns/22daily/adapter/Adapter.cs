using System;
using System.Collections.Generic;

namespace adapter
{
    public enum TemperatureType
    {
        Fahrenheit,
        Celsius
    }

    // Legacy API
    class MeatDatabase
    {
        public float GetSafeCookTemp(string meat, TemperatureType tempType)
        {
            meat = meat.ToLower();
            if (tempType == TemperatureType.Fahrenheit)
                switch (meat)
                {
                    case "beef":
                    case "pork":
                    case "veal":
                        return 145f;
                    
                    case "chicken":
                    case "turkey":
                    default:
                        return 165f;
                }
            else if (tempType == TemperatureType.Celsius)
                switch (meat)
                {
                    case "beef":
                    case "pork":
                    case "veal":
                        return 64f;
                    
                    case "chicken":
                    case "turkey":
                    default:
                        return 74f;
                }
            throw new ArgumentException("Unknown temperature type: " + tempType.ToString());
        }

        public int GetCaloriesPer100g(string meat)
        {
            meat = meat.ToLower();

            switch (meat)
            {
                case "beef": return 250;
                case "veal": return 172;
                case "pork": return 242;
                case "chicken": return 239;
                case "turkey": return 189;
                default: return 0;
            }
        }

        public double GetProteinPer100g(string meat)
        {
            meat = meat.ToLower();

            switch (meat)
            {
                case "beef": return 26;
                case "veal": return 24;
                case "pork": return 21;
                case "chicken": return 27;
                case "turkey": return 29;
                default: return 0d;
            }
        }
    }

    class Meat
    {
        protected string name;
        protected Dictionary<TemperatureType, float> safeCookTemperature
            = new Dictionary<TemperatureType, float>();
        protected double caloredPer100g;
        protected double proteinPer100g;

        public Meat(string meat)
        {
            name = meat;
        }

        public virtual void LoadData()
        {
            Console.WriteLine("\nMeat: {0} ---------", name);
        }
    }

    class MeatDetails : Meat
    {
        private MeatDatabase meatDatabase;

        public MeatDetails(string name) : base(name) {}

        public override void LoadData()
        {
            meatDatabase = new MeatDatabase();

            safeCookTemperature[TemperatureType.Fahrenheit]
                = meatDatabase.GetSafeCookTemp(name, TemperatureType.Fahrenheit);
            safeCookTemperature[TemperatureType.Celsius]
                = meatDatabase.GetSafeCookTemp(name, TemperatureType.Celsius);

            caloredPer100g = meatDatabase.GetCaloriesPer100g(name);
            proteinPer100g = meatDatabase.GetProteinPer100g(name);

            base.LoadData();
            Console.WriteLine(
                " Safe Cook Temp (F): {0}",
                safeCookTemperature[TemperatureType.Fahrenheit]
            );
            Console.WriteLine(
                " Safe Cook Temp (C): {0}",
                safeCookTemperature[TemperatureType.Celsius]
            );
            Console.WriteLine(" Calories per 100g {0}", caloredPer100g);
            Console.WriteLine(" Protein per 100g {0}", proteinPer100g);
        }
    }
}