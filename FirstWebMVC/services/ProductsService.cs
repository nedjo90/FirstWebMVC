using FirstWebMVC.Models;
using FirstWebMVC.repositories;

namespace FirstWebMVC.services;

public class ProductsService: IProductsService
{
    readonly IProductsRepository _productsRepository;

    public ProductsService(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }
    public List<Product> GetProducts()
    {
        return _productsRepository.GetProducts();
    }
}