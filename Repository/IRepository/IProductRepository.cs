using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product);
        public Task<Product> UpdateAsync(Product product);
        public Task<bool> DeleteAsync(Guid productId);
        public Task<Product> GetProductByNameAsync(string name);
        public Task<Product> GetProductByIdAsync(Guid productId);
        public Task<IEnumerable<Product>> GetAllAsync();
    }
}
