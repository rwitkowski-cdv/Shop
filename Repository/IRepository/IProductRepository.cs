using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product product, string userId);
        public Task<Product> UpdateAsync(Product product, string userId);
        public Task<bool> DeleteAsync(Guid productId);
        public Task<Product> GetProductByNameAsync(string name);
        public Task<Product> GetProductByIdAsync(Guid productId);
        public Task<IEnumerable<Product>> GetAllAvailableAsync();
    }
}
