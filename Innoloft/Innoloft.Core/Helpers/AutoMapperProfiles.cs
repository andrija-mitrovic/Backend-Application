using AutoMapper;
using Innoloft.Core.DTOs;
using Innoloft.Core.Models;

namespace Innoloft.Core.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDetailDto>();
            CreateMap<Product, ProductListDto>()
                .ForMember(dest => dest.ContactPerson, opt => {
                    opt.MapFrom(src => src.User.Username + "\n" + src.User.Phone);
                });
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();

            CreateMap<ProductType, ProductTypeDetailDto>();

            CreateMap<User, UserDetailDto>();

            CreateMap<Address, AddressDetailDto>();

            CreateMap<Company, CompanyDetailDto>();

            CreateMap<Geo, GeoDetailDto>();
        }
    }
}
