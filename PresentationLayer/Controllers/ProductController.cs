using ApplicationLayer.Interfaces;
using AutoMapper;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public readonly IMapper _mapper;

        public ProductController(
             IMapper mapper,
             IProductService productService
            )
        {
            _productService = productService;   
            _mapper = mapper;
        }

        // GET: ProductController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProduts();
            var mappedProducts = _mapper.Map<List<ProductViewModel>>(products);
            ViewData["products"] = mappedProducts;
            return View();
        }

        // POST: ProductController
        [HttpPost]
		public async Task<IActionResult> Index(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productViewModel);
                await _productService.CreateProduct(product);
            }

            var products = await _productService.GetAllProduts();
            var mappedProducts = _mapper.Map<List<ProductViewModel>>(products);
            ViewData["products"] = mappedProducts;

            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


 

        // POST: ProductController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: ProductController/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
