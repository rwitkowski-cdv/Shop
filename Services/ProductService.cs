using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync() 
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<List<Product>> FilterProductsByCategoryAsync(Guid categoryId)
        {
            return (await _productRepository.GetAllAsync()).Where(p => p.CategoryId == categoryId).ToList();
        }

        public async Task<List<Product>> FilterProductsByNameAsync(string searchText)
        {
            
            return (await _productRepository.GetAllAsync()).Where(p => p.Name.Contains(searchText,StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}
