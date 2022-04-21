using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Product> products { get; set; }
	}
}
