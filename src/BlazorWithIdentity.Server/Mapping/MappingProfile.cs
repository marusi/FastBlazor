using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blazor.Domain.Models;
using BlazorWithIdentity.Shared.DTO;
using BlazorWithIdentity.Shared.DTO.Category;
using BlazorWithIdentity.Shared.DTO.Product;

namespace BlazorWithIdentity.Server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API DTO
            CreateMap<ProductCategory, SaveProductCategoryDTO>();
            CreateMap<ProductCategory, ProductCategoryDTO>();
            CreateMap<ProductCategory, KeyValuePairDTO>();

            CreateMap<Product, ProductDTO>()
               .ForMember(pr => pr.ProductCategory, opt => opt.MapFrom(p => p.ProductCategory))
                .ForMember(pr => pr.ProductName, opt => opt.MapFrom(p => p.ProductName));

            //API DTO to Domain
            CreateMap<SaveProductCategoryDTO, ProductCategory>()
            .ForMember(p => p.Id, opt => opt.Ignore());
            CreateMap<SaveProductDTO, Product>()
           .ForMember(p => p.Id, opt => opt.Ignore());
        }
    }
}
