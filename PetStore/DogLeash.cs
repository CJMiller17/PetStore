namespace PetStore;

public class DogLeash : Product
{
    public int LengthInches { get; set; }
    public string Material { get; set; }

    public DogLeash(string name, decimal price, int quantity, string description, int lengthInches, string material)
        : base(name, price, quantity, description)
    {
        LengthInches = lengthInches;
        Material = material;
    }
}