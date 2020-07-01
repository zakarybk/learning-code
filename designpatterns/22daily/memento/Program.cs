using System;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inital supplier and details
            FoodSupplier supplier = new FoodSupplier();
            supplier.Name = "Harold Karstark";
            supplier.Phone = "(482) 555-1172";

            // Save current state
            SupplierMemory memory = new SupplierMemory();
            memory.Memento = supplier.NewMemento();

            // Change supplier details
            supplier.Address = "548 S Main St. Nowhere, KS";

            // Restore to memento (example - wrong address)
            supplier.RestoreMemento(memory.Memento);
        }
    }
}
