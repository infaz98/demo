using Application.Interfaces;
using Application.Modules.Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Modules.Product.Persistence
{
    public interface IProductRepository : IAsyncRepository<Domain.Entities.Product>
    {
        Task<List<Domain.Entities.Product>> GetAllProducts();
    }
}
