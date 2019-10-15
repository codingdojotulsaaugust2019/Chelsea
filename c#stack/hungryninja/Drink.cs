class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}
    
    public string GetInfo()
    {
        return $"Drink: {Name}, Calories: {Calories}, Spice? {IsSpicy}. Sweet? {IsSweet}.";
    }
    
    public Drink (string Name, int Calories, bool IsSpicy, bool IsSweet)
    {
        this.Name = Name;
        this.Calories = Calories;
        this.IsSpicy = IsSpicy;
        this.IsSweet = IsSweet;
    }
}   
