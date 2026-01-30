using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAsync(string name)
        {
            var product = await _db.Products.FirstOrDefaultAsync(c => c.Name == name);

            if (product == null)
            {
                return false;
            }

            _db.Products.Remove(product);
            return (await _db.SaveChangesAsync()) > 0;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product> GetProductsByNameAsync(string name)
        {
            var product = await _db.Products.FirstOrDefaultAsync(c => c.Name == name);
            if (product == null)
            {
                return new Product();
            }

            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var productFromDb = await _db.Products.FirstOrDefaultAsync(c => c.Id == product.Id);
            if (productFromDb != null)
            {
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
                _db.Products.Update(productFromDb);
                await _db.SaveChangesAsync();
                return productFromDb;
            }
            return product;
        }
    }
}
