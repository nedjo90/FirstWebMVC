using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using FirstWebMVC.services;
using FirstWebMVC.ViewModels;

namespace FirstWebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    readonly IProductsService _productsService;

    public HomeController(ILogger<HomeController> logger,
                            IProductsService productsService)
    {
        _logger = logger;
        _productsService = productsService;
    }
    

    public IActionResult Index()
    {
        
        //call service
        var viewModel = new HomeViewModel
        {
            Products = _productsService.GetProducts()
        };
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}