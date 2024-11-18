using System;
using System.Text.Json;
using PetStore;

namespace PetStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var productLogic =new ProductLogic();
            
            string userInput = string.Empty;

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View products");
                Console.WriteLine("Type 'exit' to quit the application.");

                if (userInput == "1")
                {
                    Console.WriteLine("\nChoose product type: 1 for CatFood or 2 for DogLeash");
                    
                    string productType = Console.ReadLine();

                    if (productType == "1")
                    {
                        Console.WriteLine("Enter CatFood name: ");
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Enter CatFood price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter CatFood quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter CatFood description: ");
                        string description = Console.ReadLine();
                        
                        // Console.WriteLine("Enter weight in pounds: ");
                        // double weightPounds = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Is it for Kittens? (true/false): ");
                        bool kittenFood = bool.Parse(Console.ReadLine());
                        
                        CatFood catFood = new CatFood(name, price, quantity, description, kittenFood);
                        productLogic.AddProduct(catFood);
                        Console.WriteLine("CatFood product added successfully!");
                    }
                    else if (productType == "2")
                    {
                        Console.WriteLine("Enter DogLeash name: ");
                        string name = Console.ReadLine();
                        
                        Console.WriteLine("Enter DogLeash price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter DogLeash quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter DogLeash description: ");
                        string description = Console.ReadLine();
                        
                        Console.WriteLine("Enter length in inches: ");
                        int lengthInches = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter material: ");
                        string material = (Console.ReadLine());
                        
                        DogLeash dogLeash = new DogLeash(name, price, quantity, description, lengthInches, material);
                        productLogic.AddProduct(dogLeash);
                        Console.WriteLine("DogFood product added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product type selected.");
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("\nView products:");
                    Console.WriteLine("1. View all products");
                    Console.WriteLine("2. View CatFood products");
                    Console.WriteLine("3. View DogLeash products");
                    
                    string viewType = Console.ReadLine();

                    if (viewType == "1")
                    {
                        Console.WriteLine("\nAll Products:");
                        foreach (var product in productLogic.GetAllProducts())
                        {
                            Console.WriteLine(JsonSerializer.Serialize(product));
                        }
                    }
                    
                    else if (viewType == "2")
                    {
                        Console.WriteLine("\nCatFood Products:");
                        Console.WriteLine("1. See all CatFood products.");
                        Console.WriteLine("2. Lookup CatFood product by name.");

                        string catFoodChoice = Console.ReadLine();
                        if (catFoodChoice == "1")
                        {
                            foreach (var catFood in productLogic.GetAllCatFoods())
                            {
                                Console.WriteLine(JsonSerializer.Serialize(catFood));
                            }
                        }
                        else if (catFoodChoice == "2")
                        {
                            Console.WriteLine("Enter the name of the CatFood to lookup:");
                            string name = Console.ReadLine();
                            var catFood = productLogic.GetCatFoodByName(name);

                            if (catFood != null)
                            {
                                Console.WriteLine("CatFood found:");
                                Console.WriteLine(JsonSerializer.Serialize(catFood));
                            }
                            else
                            {
                                Console.WriteLine($"CatFood with name '{name}' not found.");
                            }
                        }
                    }
                    
                    else if (viewType == "3")
                    {
                        
                        Console.WriteLine("\nDogLeash Products:");
                        Console.WriteLine("1. See all DogLeash products.");
                        Console.WriteLine("2. Lookup DogLeash product by name.");

                        string dogLeashChoice = Console.ReadLine();
                        if (dogLeashChoice == "1")
                        {
                            foreach (var dogLeash in productLogic.GetAllDogLeashes())
                            {
                                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                            }
                        }
                        else if (dogLeashChoice == "2")
                        {
                            Console.WriteLine("Enter the name of the DogLeash to lookup:");
                            string name = Console.ReadLine();
                            var dogLeash = productLogic.GetDogLeashByName(name);

                            if (dogLeash != null)
                            {
                                Console.WriteLine("DogLeash found:");
                                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                            }
                            else
                            {
                                Console.WriteLine($"DogLeash with name '{name}' not found.");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid product type selected.");
                    }
                }
                
                userInput = Console.ReadLine();
            }
            
            Console.WriteLine("\nGoodbye!");
        }
    }
}

