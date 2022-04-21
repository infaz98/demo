using Application.Modules.Product.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Modules.Product.Commands
{
	public class AddProductCommand : IRequest<Guid>
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
