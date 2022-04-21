using Application.Modules.Product.Models;
using Application.Modules.Product.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		private readonly DbSet<Product> _product;

		public ProductRepository(DataContext dbContext) : base(dbContext)
		{
			_dataContext = dbContext;
			_product = _dataContext.Set<Product>();
		}

		public async Task<List<Product>> GetAllProducts()
		{
			return await _product.ToListAsync();
		}
	}
}
