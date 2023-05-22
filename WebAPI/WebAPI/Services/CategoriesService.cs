using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;
using WebAPI.Helpers;
using WebAPI.Models.Categories;

namespace WebAPI.Services
{
    public interface ICategoriesService
    {
        Task<List<CategoriesResponse>> GetCategories();
    }
    public class CategoriesService : ICategoriesService
    {
        private DataContext _dataContext;
        private readonly IMapper _mapper;

        public CategoriesService(
            DataContext dataContext,
            IMapper mapper
            )
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<List<CategoriesResponse>> GetCategories() 
        {
            var categories = await _dataContext.Categories.ToListAsync();

            if (categories == null || !categories.Any())
            {
                return new List<CategoriesResponse>();
            }

            return _mapper.Map<List<Categories>, List<CategoriesResponse>>(categories);
        }
    }
}
