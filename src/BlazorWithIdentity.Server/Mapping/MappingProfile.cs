using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Blazor.Domain.Models;
using BlazorWithIdentity.Shared.DTO;
using BlazorWithIdentity.Shared.DTO.Category;
using BlazorWithIdentity.Shared.DTO.Option;
using BlazorWithIdentity.Shared.DTO.OptionValue;
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

            CreateMap<Product, SaveProductDTO>();
            CreateMap<Product, ProductDTO>()
               .ForMember(pr => pr.ProductCategory, opt => opt.MapFrom(p => p.ProductCategory))
                .ForMember(pr => pr.ProductName, opt => opt.MapFrom(p => p.ProductName));

            CreateMap<Option, SaveOptionDTO>();
            CreateMap<Option, OptionDTO>()
               .ForMember(pr => pr.Product, opt => opt.MapFrom(p => p.Product))
                .ForMember(pr => pr.OptionName, opt => opt.MapFrom(p => p.OptionName));

            CreateMap<OptionValue, SaveOptionValueDTO>();
            CreateMap<OptionValue, OptionValueDTO>()
               .ForMember(pr => pr.Option, opt => opt.MapFrom(p => p.Option))
                .ForMember(pr => pr.OptionValueName, opt => opt.MapFrom(p => p.OptionValueName));

            //API DTO to Domain
            CreateMap<SaveProductCategoryDTO, ProductCategory>()
            .ForMember(p => p.Id, opt => opt.Ignore())
            .ForMember(p => p.Name, opt => opt.MapFrom(pr => pr.Name));

            CreateMap<SaveProductDTO, Product>()
           .ForMember(p => p.Id, opt => opt.Ignore())
            .ForMember(p => p.ProductName, opt => opt.MapFrom(pr => pr.ProductName));
            //.ForMember(p => p.ProductCategoryId, opt => opt.MapFrom(pr => pr.ProductCategoryId));

            CreateMap<SaveOptionDTO, Option>()
           .ForMember(p => p.Id, opt => opt.Ignore());

            CreateMap<SaveOptionValueDTO, OptionValue>()
           .ForMember(p => p.Id, opt => opt.Ignore());
        }
    }
}
