using ApplicationLayer.Interfaces;
using DomainLayer.Entities;

namespace ApplicationLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }

        public Task<List<Product>> GetAllProduts()
        {
            return _productRepository.ListAllAsync();
        }

        public Task<Product> CreateProduct(Product product)
        {
            return _productRepository.AddAsync(product);
        }

    }
}
