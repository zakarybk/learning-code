using System;

namespace memento
{
    class FoodSupplier
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get { return this.name; }
            set 
            {
                this.name = value;
                Console.WriteLine("Proprietor: " + this.name);
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set
            {
                this.phone = value;
                Console.WriteLine("Phone number: " + this.phone);
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
                Console.WriteLine("Address: " + this.address);
            }
        }

        public FoodSupplierMemento NewMemento()
        {
            Console.WriteLine("\nReturning current state\n");
            return new FoodSupplierMemento(this.name, this.phone, this.address);
        }

        public void RestoreMemento(FoodSupplierMemento memento)
        {
            Console.WriteLine("\nRestoring from memento\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Address = memento.Address;
        }
    }

    class FoodSupplierMemento
    {
       public string Name { get; set; }
       public string Phone { get; set; }
       public string Address { get; set; }

       public FoodSupplierMemento(string name, string phone, string address)
       {
           Name = name;
           Phone = phone;
           Address = address;
       }
    }

    class SupplierMemory
    {
        private FoodSupplierMemento memento;

        public FoodSupplierMemento Memento
        {
            get { return this.memento; }
            set { this.memento = value; }
        }
    }
}