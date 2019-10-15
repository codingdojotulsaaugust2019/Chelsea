using System;

namespace oopsandbox
{
    public class Vehicle
    {
        public int NumPassengers;
        public Vehicle(int val)
        {
            NumPassengers = val;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(7);
            Console.WriteLine($"My vehicle is holding {myVehicle.NumPassengers} people.");
        }
    }
}
