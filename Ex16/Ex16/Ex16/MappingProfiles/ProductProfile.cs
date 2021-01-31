using AutoMapper;
using Ex16.DTO;
using Ex16.Models;

namespace Ex16.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductCreate, Product>()
                .ForMember(dst => dst.Id, opt => opt.Ignore());

            CreateMap<ProductUpdate, Product>()
                .ForMember(dst => dst.Id, opt => opt.Ignore());
        }
    }
}
