﻿
using Application.Modules.Product.Commands;
using Application.Modules.Product.Models;
using AutoMapper;
using Domain.Entities;

namespace API.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ProductDto, Product>().ReverseMap();
			CreateMap<AddProductCommand, Product>().ReverseMap();
		}
	}
}
