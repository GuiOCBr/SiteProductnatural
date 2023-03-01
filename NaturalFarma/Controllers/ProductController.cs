using Microsoft.AspNetCore.Mvc;
using NaturalFarma.Repositories;
using NaturalFarma.Repositories.Interfaces;
using NaturalFarma.ViewModels;

namespace NaturalFarma.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)

        {
            _productRepository = productRepository;
        }
        public IActionResult List()
        {
            //var products = _productRepository.Products;

            //return View(products);

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.Products;
            productListViewModel.CurrentCategory = "Categoria atual";

            return View(productListViewModel);  
        }
    }
}
