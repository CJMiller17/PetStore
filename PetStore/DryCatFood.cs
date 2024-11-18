namespace PetStore;

public class DryCatFood : CatFood
{
    public double WeightPounds { get; set; }

    public DryCatFood(string name, decimal price, int quantity, string description, bool kittenFood, double weightPounds)
        : base(name, price, quantity, description, kittenFood)
    {
        WeightPounds = weightPounds;
    } 
}