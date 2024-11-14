namespace PetStore;

public class CatFood : Product
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }

    public CatFood(string name, decimal price, int quantity, string description, double weightPounds, bool kittenFood)
        : base(name, price, quantity, description)
    {
        WeightPounds = weightPounds;
        KittenFood = kittenFood;
    }
}