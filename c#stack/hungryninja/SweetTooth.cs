using System;
using System.Collections.Generic;

class SweetTooth : Ninja
{

    public SweetTooth(string name) : base(name)
    {
        Name = name;
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }

    public override bool IsFull
    {
        get
        {
            if (calorieIntake < 1500)
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
        if (item.IsSweet)
        {
            calorieIntake += 10;
        }
        ConsumptionHistory.Add(item);
        Console.WriteLine(item.GetInfo());
    }
}
