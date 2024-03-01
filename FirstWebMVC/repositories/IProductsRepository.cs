using FirstWebMVC.Models;

namespace FirstWebMVC.repositories;

public interface IProductsRepository
{
    List<Product> GetProducts();
}