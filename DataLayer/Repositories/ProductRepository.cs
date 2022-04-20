
using ApplicationLayer.Interfaces;
using DomainLayer.Entities;

namespace DataLayer.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext dbContext) : base(dbContext)
        {
        }

    }
}
