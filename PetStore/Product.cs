namespace PetStore;

public class Product
{
   public string Name {get; set;}
   public decimal Price {get; set;}
   public int Quantity {get; set;}
   public string Description {get; set;}

   public Product(string name, decimal price, int quantity, string description)
   {
      Name = name;
      Price = price;
      Quantity = quantity;
      Description = description;
   }
}