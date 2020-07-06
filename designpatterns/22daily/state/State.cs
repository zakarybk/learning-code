using System;

namespace state
{
    abstract class Doneness
    {
        protected Steak steak;
        protected double temperature;
        protected double lowerTemp;
        protected double upperTemp;
        protected bool safeToEat;

        public Steak Steak
        {
            get { return steak; }
            set { steak = value; }
        }

        public double Temperature
        {
            get { return temperature; }
        }

        public abstract void IncreaseTemperature(double temp);
        public abstract void DecreaseTemperature(double temp);
        public abstract void DonenessCheck();

    }

    class Uncooked : Doneness
    {
        public Uncooked(double temperature, Steak steak)
        {
            this.temperature = temperature;
            this.steak = steak;
            Initialise();
        }
        public Uncooked(Doneness state)
        {
            temperature = 0;
            steak = state.Steak;
            Initialise();
        }

        public void Initialise()
        {
            lowerTemp = 0;
            upperTemp = 130;
            safeToEat = false;
        }

        public override void IncreaseTemperature(double temp)
        {
            temperature += temp;
            DonenessCheck();
        }

        public override void DecreaseTemperature(double temp)
        {
            temperature -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (temperature > upperTemp)
                steak.State = new Rare(this);
        }
    }

    class Rare : Doneness
    {
        public Rare(Doneness state) : this(state.Temperature, state.Steak) {}
        public Rare(double temperature, Steak steak)
        {
            this.temperature = temperature;
            this.steak = steak;
            Initialise();
        }

        public void Initialise()
        {
            lowerTemp = 130;
            upperTemp = 139.9;
            safeToEat = true;
        }

        public override void IncreaseTemperature(double temp)
        {
            temperature += temp;
            DonenessCheck();
        }

        public override void DecreaseTemperature(double temp)
        {
            temperature -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (temperature > upperTemp)
                steak.State = new MediumRare(this);
            else if (temperature < lowerTemp)
                steak.State = new Uncooked(this);
        }
    }

    class MediumRare : Doneness
    {
        public MediumRare(Doneness state) : this(state.Temperature, state.Steak) {}

        public MediumRare(double temperature, Steak steak)
        {
            this.temperature = temperature;
            this.steak = steak;
            Initialise();
        }

        public void Initialise()
        {
            lowerTemp = 140;
            upperTemp = 154.9;
            safeToEat = true;
        }

        public override void IncreaseTemperature(double temp)
        {
            temperature += temp;
            DonenessCheck();
        }

        public override void DecreaseTemperature(double temp)
        {
            temperature -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (temperature > upperTemp)
                steak.State = new Medium(this);
            else if (temperature < lowerTemp)
                steak.State = new Rare(this);
        }
    }

    class Medium : Doneness
    {
        public Medium(Doneness state) : this(state.Temperature, state.Steak) {}

        public Medium(double temperature, Steak steak)
        {
            this.temperature = temperature;
            this.steak = steak;
            Initialise();
        }

        public void Initialise()
        {
            lowerTemp = 155;
            upperTemp = 169.9;
            safeToEat = true;
        }

        public override void IncreaseTemperature(double temp)
        {
            temperature += temp;
            DonenessCheck();
        }

        public override void DecreaseTemperature(double temp)
        {
            temperature -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (temperature > upperTemp)
                steak.State = new WellDone(this);
            else if (temperature < lowerTemp)
                steak.State = new Medium(this);
        }
    }

    class WellDone : Doneness
    {
        public WellDone(Doneness state) : this(state.Temperature, state.Steak) {}

        public WellDone(double temperature, Steak steak)
        {
            this.temperature = temperature;
            this.steak = steak;
            Initialise();
        }

        public void Initialise()
        {
            lowerTemp = 170;
            upperTemp = 230;
            safeToEat = true;
        }

        public override void IncreaseTemperature(double temp)
        {
            temperature += temp;
            DonenessCheck();
        }

        public override void DecreaseTemperature(double temp)
        {
            temperature -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (temperature < lowerTemp)
                steak.State = new Medium(this);
        }
    }

    class Steak
    {
        private Doneness state;
        private string beefCut;

        public Steak(string beefCut)
        {
            this.beefCut = beefCut;
            state = new Uncooked(0.0, this);
        }

        public double Temperature
        {
            get { return state.Temperature; }
        }

        public Doneness State
        {
            get { return state; }
            set { state = value; }
        }

        public void IncreaseTemperature(double amount)
        {
            state.IncreaseTemperature(amount);
            Console.WriteLine("Increased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", Temperature);
            Console.WriteLine(" Statis is {0}", state.GetType().Name);
            Console.WriteLine("");
        }

        public void DecreaseTemperature(double amount)
        {
            state.DecreaseTemperature(amount);
            Console.WriteLine("Decreased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", Temperature);
            Console.WriteLine(" Statis is {0}", state.GetType().Name);
            Console.WriteLine("");
        }
    }
}