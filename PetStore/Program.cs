using System;
using System.Text.Json;
using PetStore;

namespace PetStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit the application");
            
            // This is where the user makes their decision
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("Please press 1 to add a product");
                Console.WriteLine("Please enter 'exit' to quit the application");

                if (userInput == "1")
                {
                    Console.WriteLine("Choose product type: 1 for CatFood or 2 for DogLeash");
                    
                    string productType = Console.ReadLine();

                    if (productType == "1")
                    {
                        Console.WriteLine("Enter product name: ");
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Enter product price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter product quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter product description: ");
                        string description = Console.ReadLine();
                        
                        Console.WriteLine("Enter weight in pounds: ");
                        double weightPounds = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Is it for Kittens? (true/false): ");
                        bool kittenFood = bool.Parse(Console.ReadLine());
                        
                        CatFood catFood = new CatFood(name, price, quantity, description, weightPounds, kittenFood);
                        
                        // Output created as JSON
                        Console.WriteLine("Product added: ");
                        Console.WriteLine(JsonSerializer.Serialize(catFood));
                    }
                    else if (productType == "2")
                    {
                        Console.WriteLine("Enter product name: ");
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Enter product price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter product quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter product description: ");
                        string description = Console.ReadLine();
                        
                        Console.WriteLine("Enter length in inches: ");
                        int lengthInches = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter material: ");
                        string material = (Console.ReadLine());
                        
                        DogLeash dogLeash = new DogLeash(name, price, quantity, description, lengthInches, material);
                        
                        // Output created as JSON
                        Console.WriteLine("Product added: ");
                        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    }
                    else
                    {
                        Console.WriteLine("Invalid product type selected.");
                    }
                }
                
                userInput = Console.ReadLine();
            }
        }
    }
}

