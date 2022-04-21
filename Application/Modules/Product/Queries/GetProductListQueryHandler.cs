using Application.Modules.Product.Models;
using Application.Modules.Product.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Modules.Product.Queries
{
	public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductDto>>
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

		public GetProductListQueryHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}
		public async Task<List<ProductDto>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
		{
			var products = await _productRepository.GetAllProducts();
			return _mapper.Map<List<ProductDto>>(products);
		}
	}
}
