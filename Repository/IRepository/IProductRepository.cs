using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product);
        public Task<Product> UpdateAsync(Product product);
        public Task<bool> DeleteAsync(string name);
        public Task<Product> GetProductsByNameAsync(string name);
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}
