using DomainLayer.Entities;

namespace ApplicationLayer.Interfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProduts();
        public Task<Product> CreateProduct(Product product);
    }
}
