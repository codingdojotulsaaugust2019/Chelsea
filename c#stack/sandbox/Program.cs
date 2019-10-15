using System;
using System.Collections.Generic;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> bikes = new List<string>();
        bikes.Add("Kawasaki");
        bikes.Add("Triumph");
        bikes.Add("BMW");
        bikes.Add("Moto Guzzi");
        bikes.Add("Suzuki");
        Console.WriteLine(bikes[2]);
        }
    }
}
