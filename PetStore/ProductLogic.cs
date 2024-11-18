namespace PetStore;

public class ProductLogic
{
    private List<Product> _products;
    private Dictionary<string, DogLeash> _dogLeashes;
    private Dictionary<string, CatFood> _catFoods;

    public ProductLogic()
    {
        _products = new List<Product>();
        _dogLeashes = new Dictionary<string, DogLeash>();
        _catFoods = new Dictionary<string, CatFood>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        
        // Check type of product and add it to the appropriate dictionary
        if (product is DogLeash dogLeash)
        {
            _dogLeashes[product.Name] = dogLeash;
        }
        else if (product is CatFood catFood)
        {
            _catFoods[product.Name] = catFood;
        }
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
    
    public List<CatFood> GetAllCatFoods()
    {
        return new List<CatFood>(_catFoods.Values);
    }

    public List<DogLeash> GetAllDogLeashes()
    {
        return new List<DogLeash>(_dogLeashes.Values);
    }

    public DogLeash GetDogLeashByName(string name)
    {
        try
        {
            return _dogLeashes[name];
        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
            return null; // Return null if the dog leash isn't found
        }
    }
    
    public CatFood GetCatFoodByName(string name)
    {
        try
        {
            return _catFoods[name];
        }
        catch (KeyNotFoundException)
        {
            // Handle the case where the cat food isn't found
            return null;
        }
    }

}