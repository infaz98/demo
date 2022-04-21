using Application.Modules.Product.Models;
using Application.Modules.Product.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Modules.Product.Commands
{
	public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Guid>
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;
		
		public AddProductCommandHandler(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public async Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
		{
			var product = _mapper.Map<Domain.Entities.Product>(request);
			await _productRepository.AddAsync(product);
			return product.Id;
		}
	}
}
