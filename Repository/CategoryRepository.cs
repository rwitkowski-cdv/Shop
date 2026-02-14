using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Category> CreateAsync(Category category, string userId)
        {
            category.CreatedOn = DateTime.UtcNow;
            category.CreatedById = Guid.Parse(userId);
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return category;
        }

        public async Task<bool> DeleteAsync(Guid categoryId)
        {
            var category = await GetCategoryByIdAsync(categoryId);

            if (category == null)
            {
                return false;
            }
            try
            {
                _db.Categories.Remove(category);
                return (await _db.SaveChangesAsync()) > 0;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByNameAsync(string name)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Name == name);
            if (category == null)
            {
                return new Category();
            }

            return category;
        }

        public async Task<Category> GetCategoryByIdAsync(Guid categoryId)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            if (category == null)
            {
                return new Category();
            }

            return category;
        }

        public async Task<Category> UpdateAsync(Category category, string userId)
        {
            var categoryFromDb = await _db.Categories.FirstOrDefaultAsync(c => c.Id == category.Id);
            if (categoryFromDb != null)
            {
                categoryFromDb.ModifiedOn = DateTime.UtcNow;
                categoryFromDb.ModifiedById = Guid.Parse(userId);
                categoryFromDb.Name = category.Name;
                _db.Categories.Update(categoryFromDb);
                await _db.SaveChangesAsync();
                return categoryFromDb;
            }
            return category;
        }
    }
}
