using FirstWebMVC.Models;

namespace FirstWebMVC.services;

public interface IProductsService
{
    List<Product> GetProducts();
}