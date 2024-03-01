using FirstWebMVC.Models;

namespace FirstWebMVC.repositories;

public class ProductsRepository : IProductsRepository
{
    public List<Product> GetProducts()
    {
        // call Api
        var products = new List<Product>();
        
        products.Add( new Product
            (
                1,
                "Black Bag",
                "A black bag - nice !",
                $"/assets/images/black_bag.jpg",
                $"Some place France",
                50m
            )
            );
        products.Add( new Product
            (
                2,
                "Red Shirt",
                "A red shirt - nice !",
                $"/assets/images/RedShirt.png",
                $"Some place France",
                15m
            )
            );
        return products;
    }
}