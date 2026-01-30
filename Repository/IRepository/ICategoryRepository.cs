using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category);
        public Task<Category> UpdateAsync(Category category);
        public Task<bool> DeleteAsync(string name);
        public Task<Category> GetCategoryByNameAsync(string name);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}
