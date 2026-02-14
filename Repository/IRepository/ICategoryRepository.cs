using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category, string userId);
        public Task<Category> UpdateAsync(Category category, string userId);
        public Task<bool> DeleteAsync(Guid categoryId);
        public Task<Category> GetCategoryByNameAsync(string name);
        public Task<Category> GetCategoryByIdAsync(Guid categoryId);

        public Task<IEnumerable<Category>> GetAllAsync();
    }
}
