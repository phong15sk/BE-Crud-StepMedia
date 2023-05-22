using AutoMapper;
using WebAPI.Entities;
using WebAPI.Models.Categories;

namespace WebAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Categories, CategoriesResponse>();
        }
    }
}
