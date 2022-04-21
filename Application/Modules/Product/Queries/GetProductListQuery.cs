using Application.Modules.Product.Models;
using MediatR;

namespace Application.Modules.Product.Queries
{
	public class GetProductListQuery : IRequest<List<ProductDto>>
	{
	}
}
