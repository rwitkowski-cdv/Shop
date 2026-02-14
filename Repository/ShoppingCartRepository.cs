using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ShoppingCartRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> ClearCartAsync(string? userId)
        {
            var cartItems = await _dbContext.ShoppingCart.Where(c => c.UserId == userId).ToListAsync();
            _dbContext.ShoppingCart.RemoveRange(cartItems);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<ShoppingCart>> GetAllAsync(string? userId)
        {
            return await _dbContext.ShoppingCart.Where(c => c.UserId == userId).Include(c => c.Product).ToListAsync();
        }

        public async Task<bool> UpdateCartAsync(string userId, Guid product, int updatedByValue)
        {
            if (string.IsNullOrEmpty(userId)) 
                return false;

            var cart = await _dbContext.ShoppingCart.FirstOrDefaultAsync(c => c.UserId == userId && c.ProductId == product);

            if (cart == null)
            {
                cart = new ShoppingCart
                {
                    Id = Guid.Empty,
                    CreatedOn = DateTime.UtcNow,
                    CreatedById = Guid.Parse(userId),
                    UserId = userId,
                    ProductId = product,
                    Quantity = updatedByValue
                };
                await _dbContext.ShoppingCart.AddAsync(cart);
            }
            else 
            {
                cart.Quantity += updatedByValue;
                if (cart.Quantity <= 0)
                {
                    _dbContext.ShoppingCart.Remove(cart);
                }
            }
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
