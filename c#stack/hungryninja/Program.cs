using System;
using System.Collections.Generic;


namespace hungryninja
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetTooth Chelsea = new SweetTooth("Chelsea");
            SpiceHound Joseph = new SpiceHound("Joseph");
            Buffet FoodTruck = new Buffet();

            while (Chelsea.IsFull != true)
            {
                IConsumable edible = FoodTruck.Serve();
                Chelsea.Consume(edible);
            }
           
            while (Joseph.IsFull != true)
            {
                IConsumable edible = FoodTruck.Serve();
                Joseph.Consume(edible);
            }

            Console.WriteLine($"Chelsea ate {Chelsea.ConsumptionHistory.Count} items");
            Console.WriteLine($"Joseph ate {Joseph.ConsumptionHistory.Count} items");

            if (Chelsea.ConsumptionHistory.Count > Joseph.ConsumptionHistory.Count)
            {
                Console.WriteLine("Chelsea ate more items.");
            }
            else
            {
                Console.WriteLine("Chelsea ate more items.");
            }
        }
    }
}
