using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync() 
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
