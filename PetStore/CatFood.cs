namespace PetStore;

public class CatFood : Product
{
    public bool KittenFood { get; set; }

    public CatFood(string name, decimal price, int quantity, string description, bool kittenFood)
        : base(name, price, quantity, description)
    {
        KittenFood = kittenFood;
    }
}