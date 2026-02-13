using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductRepository(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            product.CreatedOn = DateTime.UtcNow;
            product.CreatedById = Guid.NewGuid();
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(Guid productId)
        {
            var product = await _dbContext.Products?.FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return false;
            }
            if(!string.IsNullOrEmpty(product.ImageUrl))
            {
                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, product.ImageUrl.TrimStart('/'));
            
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }

            _dbContext.Products.Remove(product);
            return (await _dbContext.SaveChangesAsync()) > 0;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _dbContext.Products
                                    .Include(p => p.Category)
                                    .ToListAsync();
        }

        public async Task<Product> GetProductByNameAsync(string name)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(c => c.Name == name);
            if (product == null)
            {
                return new Product();
            }

            return product;
        }
        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                return new Product();
            }

            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var productFromDb = await _dbContext.Products.FirstOrDefaultAsync(c => c.Id == product.Id);
            if (productFromDb != null)
            {
                productFromDb.ModifiedOn = DateTime.UtcNow;
                productFromDb.ModifiedById = Guid.NewGuid();
                productFromDb.Name = product.Name;
                productFromDb.SKU = product.SKU;
                productFromDb.ImageUrl = product.ImageUrl;
                productFromDb.GrossAmount = product.GrossAmount;
                productFromDb.NetAmount = product.NetAmount;
                productFromDb.TaxAmount = product.TaxAmount;
                productFromDb.Description = product.Description;
                productFromDb.IsAvailable = product.IsAvailable;
                productFromDb.Tag = product.Tag;
                productFromDb.CategoryId = product.CategoryId;
                _dbContext.Products.Update(productFromDb);
                await _dbContext.SaveChangesAsync();
                return productFromDb;
            }
            return product;
        }
    }
}
