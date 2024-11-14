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

    public DogLeash GetDogLeashByName(string name)
    {
        return _dogLeashes.ContainsKey(name) ? _dogLeashes[name] : null;
    }
}