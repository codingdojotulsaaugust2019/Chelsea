using System;
using System.Collections.Generic;

class SpiceHound : Ninja
{

    public SpiceHound(string name) : base(name)
    {
        Name = name;
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }

    public override bool IsFull
    {
        get
        {
            if (calorieIntake < 1200)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("I'm Full!");
                    return true;
                }
        }
    }
    public override void Consume(IConsumable item)
    {
        calorieIntake += item.Calories;
        if (item.IsSpicy)
        {
            calorieIntake -= 5;
        }
        ConsumptionHistory.Add(item);
        Console.WriteLine(item.GetInfo());
    }
}
